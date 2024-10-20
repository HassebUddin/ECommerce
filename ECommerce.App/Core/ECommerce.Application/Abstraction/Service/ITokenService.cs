
using ECommerce.Domain.Entity.Identity;
using ECommerce.Domain.ViewModel.Request.Account;
using ECommerce.Domain.ViewModel.Response;

namespace ECommerce.Application.Abstraction.Service
{
    public interface ITokenService
    {
        Task<AuthResultResponse> VerifyTokenAsync(JwtTokenRequest tokenRequest);
        Task<AuthResultResponse> GenerateJwtTokenAsync(AppUser user);
    }
}
