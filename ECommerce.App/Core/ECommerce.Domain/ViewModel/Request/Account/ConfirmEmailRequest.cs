

namespace ECommerce.Domain.ViewModel.Request.Account
{
    public class ConfirmEmailRequest
    {
        public string Token { get; set; } = null!;
        public string Email { get; set; } = null!;

    }
}
