

namespace ECommerce.Application.Config
{
    public class JwtConfig
    {
        public string Secret { get; set; } = null!;
        public   int ExpiryTimeFrame { get; set; }
    }
}
