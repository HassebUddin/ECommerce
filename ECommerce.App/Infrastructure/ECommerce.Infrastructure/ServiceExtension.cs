
using ECommerce.Application.Abstraction.Service.Storage.Azure;
using ECommerce.Application.Abstraction.Service.Storage;
using ECommerce.Infrastructure.Service.Storage.Local;
using Microsoft.Extensions.DependencyInjection;
using ECommerce.Infrastructure.Enums;
using System.Reflection;

namespace ECommerce.Infrastructure
{
    public static class ServiceExtension
    {

        public static void AddInfrastructure(this IServiceCollection services)
        {
            //inject service
            var types = Assembly.GetExecutingAssembly().GetTypes().Where(x => x.IsClass && !x.IsAbstract && x.Name.EndsWith("Service"));
            foreach (var item in types)
            {
                var IService = item.GetInterfaces().FirstOrDefault(x => x.Name == $"I{item.Name}");
                if (IService != null)
                    services.AddScoped(IService, item);
            }


        }

        public static void AddStorage<T>(this IServiceCollection services) where T : class, IStorage
        {
            services.AddScoped<IStorage, T>();

        }


        public static void AddStorage(this IServiceCollection services, StorageType storageType)
        {
            switch (storageType)
            {
                case StorageType.local:
                    services.AddScoped<IStorage, LocalStorage>();
                    break;
                case StorageType.Azure:
                    services.AddScoped<IStorage, IAzureStorage>();
                    break;
                case StorageType.AWS:
                    break;
                default:
                    services.AddScoped<IStorage, LocalStorage>();
                    break;

            }

        }
    }

}
