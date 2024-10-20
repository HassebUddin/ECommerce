
using ECommerce.Domain.ViewModel.Request.Account;

namespace ECommerce.Application.Abstraction.Service
{
    public interface IAccountService
    {
        Task<object> LoginAsync(LoginRequest request);
        Task<object> RegisterAsync(RegisterRequest request);
        Task<object> ForgotPasswordAsync(ForgetPasswordRequest request);
        Task<object> ResetPasswordAsync( ResetPasswordRequest request);
        Task<object> VerifyTwoFactorTokenAsync(VerifyTwoFactorTokenRequest model);
        Task<object> ConfirmEmail(ConfirmEmailRequest request);
    }
}
