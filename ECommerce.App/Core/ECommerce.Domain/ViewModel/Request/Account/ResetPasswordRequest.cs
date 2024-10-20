namespace ECommerce.Domain.ViewModel.Request.Account
{
    public class ResetPasswordRequest
    {
        public string NewPassword { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Token { get; set; } = null!;
    }
}
