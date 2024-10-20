namespace ECommerce.Domain.ViewModel.Request.Account
{
    public class JwtTokenRequest
    {
        public string Token { get; set; } = null!;
        public string RefreshToken { get; set; } = null!;

    }
}
