using ECommerce.Application.IRepositories.Web.Restautrants;
using ECommerce.Domain.Entity.Web;
using ECommerce.Persistence.Context;

namespace ECommerce.Persistence.Repositories.Web.Restautrants
{
    public class RestaurantWriteRepository : WriteRepository<Resturant>, IRestaurantWriteRepository
    {
        public RestaurantWriteRepository(AppDbContext context) : base(context)
        {
        }
    }
}
