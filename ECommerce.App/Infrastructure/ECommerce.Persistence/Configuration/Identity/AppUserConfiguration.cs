
using ECommerce.Domain.Entity.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.Persistence.Configuration.Identity
{
    public class AppRoleConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            var admin = new AppUser
            {
                
                Id = Guid.Parse("45121CFB-6A63-4950-9D67-68437D1BC43F").ToString(),
                FullName = "Admin",
                Email = "admin@gmail.com",
                UserName = "admin@gmail.com",
                NormalizedEmail = "admin@gmail.com".ToUpper(),
                NormalizedUserName = "admin@gmail.com".ToUpper(),
                Address = "surjany",
                City = "Karahi",
                Country = "Pakistan",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                SecurityStamp = Guid.NewGuid().ToString(),
                Gender = "Male",
            //    Profession = "Dot Net",
                PhoneNumber = "283748927387",


            };

            var superadmin = new AppUser
            {
                


                Id = Guid.Parse("8FC73959-CC3D-47D2-A017-DEA6DF68AE94").ToString(),
                FullName = "SuperAdmin",
                Email = "superadmin@gmail.com",
                UserName = "superadmin@gmail.com",
                NormalizedEmail = "superadmin@gmail.com".ToUpper(),
                NormalizedUserName = "superadmi@gmail.com".ToUpper(),
                Address = "north nazimabad",
                City = "Karahi",
                Country = "Pakistan",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                SecurityStamp = Guid.NewGuid().ToString(),
                Gender = "Male",
             //   Profession = "Sale Expert",
                PhoneNumber = "283748927387"

            };

            var user = new AppUser
            {

                Id = Guid.Parse("7FC73959-CC3D-47D2-A017-DEA6DF68AE94").ToString(),
                FullName = "User",
                Email = "user@gmail.com",
                UserName = "user@gmail.com",
                NormalizedEmail = "user@gmail.com".ToUpper(),
                NormalizedUserName = "user@gmail.com".ToUpper(),
                Address = "north nazimabad",
                City = "Karahi",
                Country = "Pakistan",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                SecurityStamp = Guid.NewGuid().ToString(),
                Gender = "Male",
              //  Profession = "Networking Expert",
                PhoneNumber = "283748927387"

            };

            user.PasswordHash = GenerateHash(user, "user@123");
            admin.PasswordHash = GenerateHash(admin, "admin@123");
            superadmin.PasswordHash = GenerateHash(superadmin, "superadmin@123");

            builder.HasData(user, admin, superadmin);




        }
        private string GenerateHash(AppUser appUser, string password)
        {
            var hash = new PasswordHasher<AppUser>();
            return hash.HashPassword(appUser, password);

        }
    }
}
