
using ECommerce.Domain.Entity.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.Persistence.Configuration.Identity
{
    public class AppUserRoleConfiguration : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            builder.HasData(new AppUserRole
            {
                RoleId = Guid.Parse("E76C4FCF-4443-4CEA-A649-576331C7603E").ToString(),
                UserId = Guid.Parse("45121CFB-6A63-4950-9D67-68437D1BC43F").ToString()
            }, new AppUserRole
            {
                RoleId = Guid.Parse("1C9D1DBA-C977-471A-98C5-A2D5F04935C1").ToString(),
                UserId = Guid.Parse("8FC73959-CC3D-47D2-A017-DEA6DF68AE94").ToString()

            }, new AppUserRole
            {
                RoleId = Guid.Parse("1E3672E3-8563-49A3-8024-E36D2BF3DCB0").ToString(),
                UserId = Guid.Parse("7FC73959-CC3D-47D2-A017-DEA6DF68AE94").ToString()

            }

           );
        }
    }
}
