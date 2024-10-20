using ECommerce.Application.IRepositories;
using ECommerce.Domain.Entity.Identity;
using ECommerce.Persistence.Context;
using ECommerce.Persistence.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;


namespace ECommerce.Persistence
{
    public static class ServiceExtensions
    {
        public static void AddPersistence(this IServiceCollection service)
        {
            //inject Dbcontext
            service.AddDbContext<AppDbContext>(op => op.UseSqlServer("Server=DESKTOP-P78AVG1\\SQLEXPRESS;Database=ECommerce;Trusted_Connection=True;Encrypt=False;"));

            //Inject Identity

            service.AddIdentity<AppUser, AppRole>(options =>
            {
                options.SignIn.RequireConfirmedEmail = true;

               
                //password requirement
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequiredLength = 0;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredUniqueChars = 0;
                options.Password.RequireDigit = false;

                options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-_@.";

                ////lockout requirement
                //options.Lockout.DefaultLockoutTimeSpan=TimeSpan.FromMinutes(10);
                //options.Lockout.MaxFailedAccessAttempts = 5;

            })
                .AddRoleManager<RoleManager<AppRole>>()
                .AddEntityFrameworkStores<AppDbContext>()
                .AddDefaultTokenProviders();

            //inject idenity cookie
            service.ConfigureApplicationCookie(option =>
            {
                var cookieBuilder = new CookieBuilder();
                cookieBuilder.Name = "ETicket";

                option.Cookie = cookieBuilder;
                // option.LoginPath = new PathString("/account/login");
                //option.AccessDeniedPath = new PathString("/account/access-denied");
            });
            //token lifetime
            service.Configure<DataProtectionTokenProviderOptions>(option =>
            {
                option.TokenLifespan = TimeSpan.FromMinutes(3);
            });


            //injcet Generic Repositroy
            service.AddScoped(typeof(IReadRepository<>), typeof(ReadRepository<>));

            //inject Reqpository
            var Respositories = Assembly.GetExecutingAssembly().GetTypes().Where(x => x.IsClass && !x.IsAbstract && x.Name.EndsWith("Repository")).ToList();
            foreach (var Respository in Respositories)
            {
                var IRespository = Respository.GetInterfaces().FirstOrDefault(x => x.Name == $"I{Respository.Name}");
                if (IRespository != null)
                    service.AddScoped(IRespository, Respository);
            }
        }
    }
}
