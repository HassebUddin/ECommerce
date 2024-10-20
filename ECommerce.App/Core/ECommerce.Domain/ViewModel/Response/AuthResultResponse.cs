namespace ECommerce.Domain.ViewModel.Response
{
    public class AuthResultResponse
    {
        public string Token { get; set; } = null!;
        public string RefreshToken { get; set; } = null!;
        public bool Success { get; set; }
        public List<string> Errors { get; set; } = null!;

    }
}
