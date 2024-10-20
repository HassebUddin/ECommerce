

using Microsoft.AspNetCore.Identity;

namespace ECommerce.Domain.Entity.Identity
{
    public class AppRole:IdentityRole<string>
    {
        public ICollection<AppUserRole> UserRoles { get; set; } = null!;

    }
}
