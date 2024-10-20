

using ECommerce.Application.Abstraction.Service;
using ECommerce.Application.Config;
using ECommerce.Application.IRepositories.Account.RefreshTokens;
using ECommerce.Application.Messages;
using ECommerce.Domain.Entity.Account;
using ECommerce.Domain.Entity.Identity;
using ECommerce.Domain.ViewModel.Request.Account;
using ECommerce.Domain.ViewModel.Response;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ECommerce.Infrastructure.Service
{
    public class TokenService : ITokenService
    {
        private readonly JwtConfig _jwtConfig;
        private readonly TokenValidationParameters _tokenValidationParameters;

        private readonly UserManager<AppUser> _userManager;

        private readonly IRefreshTokenWriteRepository _refreshTokenWriteRepository;
        private readonly IRefreshTokenReadRepository _refreshTokenReadRepository;
        public TokenService(IOptions<JwtConfig> options, TokenValidationParameters tokenValidationParameters,
            UserManager<AppUser> userManager, IRefreshTokenWriteRepository refreshTokenWriteRepository,
            IRefreshTokenReadRepository refreshTokenReadRepository)
        {
            _jwtConfig = options.Value;
            _tokenValidationParameters = tokenValidationParameters;
            _userManager = userManager;
            _refreshTokenWriteRepository = refreshTokenWriteRepository;
            _refreshTokenReadRepository = refreshTokenReadRepository;
        }




        public async Task<AuthResultResponse> GenerateJwtTokenAsync(AppUser user)
        {

            var jwtTokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_jwtConfig.Secret);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject =await  GetClaimsAsync(user),
                Expires = DateTime.UtcNow.AddHours(_jwtConfig.ExpiryTimeFrame),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = jwtTokenHandler.CreateToken(tokenDescriptor);
            var jwtToken = jwtTokenHandler.WriteToken(token);

            var refreshToken = new RefreshToken()
            {
                JwtId = token.Id,
                UserId = user.Id,
                AddedDate = DateTime.UtcNow,
                ExpiryDate = DateTime.UtcNow.AddHours(_jwtConfig.ExpiryTimeFrame),
                Token = RandomString(25) + Guid.NewGuid()
            };

            await _refreshTokenWriteRepository.AddAsync(refreshToken);
            await _refreshTokenWriteRepository.SaveChangeAsync();

            return new AuthResultResponse()
            {
                Token = jwtToken,
                Success = true,
                RefreshToken = refreshToken.Token
            };
        }
        public async Task<AuthResultResponse> VerifyTokenAsync(JwtTokenRequest tokenRequest)
        {
            var jwtTokenHandler = new JwtSecurityTokenHandler();

            // This validation function will make sure that the token meets the validation parameters
            // and its an actual jwt token not just a random string
            var principal = jwtTokenHandler.ValidateToken(tokenRequest.Token, _tokenValidationParameters, out var validatedToken);

            // Now we need to check if the token has a valid security algorithm
            if (validatedToken is JwtSecurityToken jwtSecurityToken)
            {
                var result = jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase);

                if (result == false)
                    return null!;

                else
                {
                    // Will get the time stamp in unix time
                    var utcExpiryDate = long.Parse(principal.Claims.FirstOrDefault(x => x.Type == JwtRegisteredClaimNames.Exp)!.Value);

                    // we convert the expiry date from seconds to the date
                    var expDate = UnixTimeStampToDateTime(utcExpiryDate);

                    if (expDate > DateTime.UtcNow)
                        throw new Exception(JwtTokenMessage.TokenNotExpire);

                    // Check the token we got if its saved in the db
                    var storedRefreshToken = await _refreshTokenReadRepository.GetSingleAsync(x => x.Token == tokenRequest.RefreshToken);

                    if (storedRefreshToken == null)
                        throw new Exception(JwtTokenMessage.InvalidToken);

                    


                    // we are getting here the jwt token id
                    var jti = principal.Claims.SingleOrDefault(x => x.Type == JwtRegisteredClaimNames.Jti)!.Value;

                    // check the id that the recieved token has against the id saved in the db
                    if (storedRefreshToken.JwtId != jti)
                        throw new Exception(JwtTokenMessage.InvalidToken);





                    var dbUser = await _userManager.FindByIdAsync(storedRefreshToken.UserId);


                    await _refreshTokenWriteRepository.RemoveAsync(storedRefreshToken.UserId);
                    await _refreshTokenWriteRepository.SaveChangeAsync();
                    return await GenerateJwtTokenAsync(dbUser);
                   

                }

            }

            throw new Exception(JwtTokenMessage.InvalidToken);


        }




        private DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToUniversalTime();
            return dtDateTime;
        }
        private string RandomString(int length)
        {
            var random = new Random();
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private async Task<ClaimsIdentity> GetClaimsAsync(AppUser user)
        {
            var claims = new List<Claim>
    {
        new Claim("Id", user.Id),
        new Claim(JwtRegisteredClaimNames.Email, user.Email),
        new Claim(JwtRegisteredClaimNames.Sub, user.Email),
        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
        new Claim(JwtRegisteredClaimNames.Name,user.Email)
    };

            // Retrieve user roles
            var roles = await _userManager.GetRolesAsync(user);
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role)); // Add each role as a claim
            }

            return new ClaimsIdentity(claims);
        }



    }
}
