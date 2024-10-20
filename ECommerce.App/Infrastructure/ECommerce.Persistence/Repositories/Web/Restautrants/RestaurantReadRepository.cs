using ECommerce.Application.IRepositories.Web.Restautrants;
using ECommerce.Domain.Entity.Web;
using ECommerce.Persistence.Context;

namespace ECommerce.Persistence.Repositories.Web.Restautrants
{
    public class RestaurantReadRepository : ReadRepository<Resturant>, IRestaurantReadRepository
    {
        public RestaurantReadRepository(AppDbContext context) : base(context)
        {
        }
    }
}
