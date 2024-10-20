

using ECommerce.Application.IRepositories.Web.RestaurantBranchs;
using ECommerce.Domain.Entity.Web;
using ECommerce.Persistence.Context;

namespace ECommerce.Persistence.Repositories.Web.RestaurantBranchs
{
    public class RestaurantBranchReadRepository : ReadRepository<RestaurantBranch>, IRestaurantBranchReadRepository
    {
        public RestaurantBranchReadRepository(AppDbContext context) : base(context)
        {
        }
    }
}
