

namespace ECommerce.Domain.ViewModel.Request.Account
{
    public class VerifyTwoFactorTokenRequest
    {
        public string Email { get; set; } = null!;

        public string Token { get; set; } = null!;
    }
}
