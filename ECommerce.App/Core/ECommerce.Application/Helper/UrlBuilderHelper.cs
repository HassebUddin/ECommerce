

namespace ECommerce.Application.Helper
{
    public static class UrlBuilderHelper
    {
        private const string ApplicationUrl = "https://localhost:4200";

        public static string EmailConfirmationLink(string email, string token)
        {
            return $"{ApplicationUrl}/account/confirm-link?email={email}&token={token}";
        }

        public static string ResetPasswordCallbackLink(string token,string email)
        {
            return $"{ApplicationUrl}/account/reset-password?email={email}&token={token}";
        }
    }
}
