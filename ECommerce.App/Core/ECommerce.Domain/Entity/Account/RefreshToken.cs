using ECommerce.Domain.BaseEntities;
using ECommerce.Domain.Entity.Identity;


namespace ECommerce.Domain.Entity.Account
{
    public class RefreshToken : BaseEntity
    {

        public string Token { get; set; } = null!;
        public string JwtId { get; set; } = null!; // Map the token with jwtId
        public DateTime AddedDate { get; set; }
        public DateTime ExpiryDate { get; set; } // Refresh token is long lived it could last for months.


        public string UserId { get; set; } = null!; // Linked to the AspNet Identity User Id
        public AppUser User { get; set; } = null!;
    }
}
