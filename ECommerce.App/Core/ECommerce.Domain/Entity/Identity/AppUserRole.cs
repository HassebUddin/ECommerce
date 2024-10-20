

using Microsoft.AspNetCore.Identity;

namespace ECommerce.Domain.Entity.Identity
{
    public class AppUserRole:IdentityUserRole<string>
    {

        public AppUser Users { get; set; } = null!;
        public AppRole Roles { get; set; } = null!;

    }
}
