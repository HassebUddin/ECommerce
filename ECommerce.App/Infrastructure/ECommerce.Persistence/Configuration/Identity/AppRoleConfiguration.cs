

using ECommerce.Domain.Entity.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.Persistence.Configuration.Identity
{
    public class AppRole_config : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            builder.HasData(new AppRole
            {
                Id = Guid.Parse("E76C4FCF-4443-4CEA-A649-576331C7603E").ToString(),
                Name = "Admin",
                NormalizedName = "Admin".ToUpper()

            }
            , new AppRole
            {
                Id = Guid.Parse("1C9D1DBA-C977-471A-98C5-A2D5F04935C1").ToString(),
                Name = "SuperAdmin",
                NormalizedName = "SuperAdmin".ToUpper()
            }, new AppRole
            {
                Id = Guid.Parse("1E3672E3-8563-49A3-8024-E36D2BF3DCB0").ToString(),
                Name = "User",
                NormalizedName = "User".ToUpper()
            }
            );
        }
    }
}
