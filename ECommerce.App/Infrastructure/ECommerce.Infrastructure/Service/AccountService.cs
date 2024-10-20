
using AutoMapper;
using ECommerce.Application.Abstraction.Service;
using ECommerce.Application.Enums;
using ECommerce.Application.Helper;
using ECommerce.Application.Messages;
using ECommerce.Domain.Entity.Identity;
using ECommerce.Domain.ViewModel.Request.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using System.Text;

namespace ECommerce.Infrastructure.Service
{
    public class AccountService:IAccountService
    {
        private readonly IMapper _mapper;


        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;


        private readonly ITokenService _tokenService;
        private readonly IEmailService _emailService;

        public AccountService(IMapper mapper, UserManager<AppUser> userManager, 
            SignInManager<AppUser> signInManager, ITokenService tokenService, 
            IEmailService emailService)
        {
            _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenService = tokenService;
            _emailService = emailService;
        }

        
        
        public async Task<object> LoginAsync(LoginRequest request)
         {
            var user = await _userManager.FindByEmailAsync(request.Email);
            if (user == null)
                throw new Exception(AccountMessage.TryAntotherEmail);

            var result = await _userManager.CheckPasswordAsync(user, request.Password);
            if (!result)
                throw new Exception(AccountMessage.TryAntotherPassword);
          
             await _signInManager.SignOutAsync();
             await _signInManager.PasswordSignInAsync(user, request.Password, request.RememberMe, false);
           
            if (user.TwoFactorEnabled)
            {
                var OTP = await _userManager.GenerateTwoFactorTokenAsync(user,"Email");
                await _emailService.SendMailAsync(request.Email,"Confirm Your OTP", $"Please confirm your OTP by <b>{OTP}</b>", true);
                return AccountMessage.SendOTP;

            }

           
            var authResult = await _tokenService.GenerateJwtTokenAsync(user);
            return new
            {
                Token = authResult.Token,
                RefresToken = authResult.RefreshToken,
                Message = AccountMessage.LoginSuccessed,
                Status = StatusCodeEnum.OK
            };



        }
        public async Task<object> RegisterAsync(RegisterRequest request)
        {
           
             var user = _mapper.Map<AppUser>(request);
             var result = await _userManager.CreateAsync(user, request.Password);
            if (!result.Succeeded)
                throw new Exception(result.Errors.Select(x=>x.Description).FirstOrDefault());

            //add default role
            await  _userManager.AddToRoleAsync(user, "User");

            //send confirmation email
            var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            var callbackUrl = UrlBuilderHelper.EmailConfirmationLink( WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(token)), user.Email);
            await _emailService.SendMailAsync(request.Email, "Confirm Your Email", $"Please confirm your account by <a href={callbackUrl}> clicking here </a>", true);
         
            return AccountMessage.ConfirmEmail;

        }

       
        
        
        public async Task<object> ForgotPasswordAsync(ForgetPasswordRequest request)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);
            if (user == null)
                 throw new Exception(AccountMessage.TryAntotherEmail);

            var code = await _userManager.GeneratePasswordResetTokenAsync(user);
            var callbackUrl = UrlBuilderHelper.ResetPasswordCallbackLink(WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code)), user.Email);
            await _emailService.SendMailAsync(request.Email,"Reset Password",
                $"Please reset your password by: <a href={callbackUrl}>clicking here</a>",true);

            return AccountMessage.ConfirmEmail;
        }     
        public async Task<object> ResetPasswordAsync(ResetPasswordRequest request)
        {
           

            var user = await _userManager.FindByEmailAsync(request.Email);
            if (user == null)
                throw new Exception(AccountMessage.TryAntotherEmail);
        

            var result = await _userManager.ResetPasswordAsync(user, Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(request.Token)),request.NewPassword);
            if (!result.Succeeded)
                throw new Exception(result.Errors.Select(x => x.Description).FirstOrDefault());


            //send confirmation email
            await _emailService.SendMailAsync(request.Email, "Reset Password Sucessfully", "<b>your password is successfully Reset</b>", true);
            return AccountMessage.ResetPasswordSuccessed;
        }





        public async Task<object> ConfirmEmail(ConfirmEmailRequest request)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);
            if (user == null)
                throw new Exception(AccountMessage.TryAntotherEmail);

           



            //confirm email
            var result = await  _userManager.ConfirmEmailAsync(user, Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(request.Token)));
            if(!result.Succeeded)
                 throw new Exception(result.Errors.Select(x=>x.Description).FirstOrDefault());  

          
            return AccountMessage.EmailConfirmSuccessed;        

        }

        public async Task<object> VerifyTwoFactorTokenAsync(VerifyTwoFactorTokenRequest model)
        {
           
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
                throw new Exception(AccountMessage.TryAntotherEmail);

            


            // Validate the 2FA token
            var result = await _userManager.VerifyTwoFactorTokenAsync(user, "Email",model.Token);
            if (!result)
                throw new Exception(AccountMessage.InvlaidOTP);


              await  _signInManager.SignInAsync(user, false);
             var authResult = await _tokenService.GenerateJwtTokenAsync(user);
            return new 
            {
                Token = authResult.Token,
                RefresToken = authResult.RefreshToken,
                Message = AccountMessage.OTPVerfiySuccessed,
                Status = StatusCodeEnum.OK
            };
 
        }

    }
}
