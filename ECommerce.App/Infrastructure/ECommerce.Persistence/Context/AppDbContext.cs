

using ECommerce.Domain.BaseEntities;
using ECommerce.Domain.Entity.Account;
using ECommerce.Domain.Entity.File;
using ECommerce.Domain.Entity.Identity;
using ECommerce.Domain.Entity.Web;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ECommerce.Persistence.Context
{
    public class AppDbContext : IdentityDbContext<AppUser, AppRole, string>
    {
        public AppDbContext()
        {
            
        }
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public  DbSet<RefreshToken> refreshTokens { get; set; }       
        public DbSet<Image> images { get; set; }
        public DbSet<UserImage> userImages { get; set; }



        public DbSet<Resturant> resturants { get; set; }
        public DbSet<DinnerTable> dinnerTables { get; set; }
        public DbSet<Reservation> reservations { get; set; }
        public DbSet<RestaurantBranch> restaurantBranches { get; set; }
        public DbSet<TimeSlot> timeSlots { get; set; }




        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker.Entries<BaseEntity>();
            foreach (var data in datas)
            {
                _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreateDate = DateTime.UtcNow,
                    EntityState.Modified => data.Entity.UpdateDate = DateTime.UtcNow,
                    _ => data.Entity.CreateDate = DateTime.UtcNow,

                };
            }

            return await base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());   
            base.OnModelCreating(builder);





            //define appuserrole relationship with user and role table;
            builder.Entity<AppUserRole>().HasOne(u => u.Users).WithMany(m => m.UserRoles).HasForeignKey(key => key.UserId).IsRequired();
            builder.Entity<AppUserRole>().HasOne(u => u.Roles).WithMany(m => m.UserRoles).HasForeignKey(key => key.RoleId).IsRequired();


            // Customize the column name for discriminator
            builder.Entity<AppUserRole>(entity =>
            {
                entity.Property<string>("Discriminator")
                      .HasDefaultValue("App UserRole");
            });

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer("Server=DESKTOP-P78AVG1\\SQLEXPRESS;Database=ECommerce;Trusted_Connection=True;Encrypt=False;");
            base.OnConfiguring(optionsBuilder);
        }

    }
}
