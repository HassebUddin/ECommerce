
using ECommerce.Application.IRepositories.Web.RestaurantBranchs;
using ECommerce.Domain.Entity.Web;
using ECommerce.Persistence.Context;

namespace ECommerce.Persistence.Repositories.Web.RestaurantBranchs
{
    public class RestaurantBranchWriteRepository : WriteRepository<RestaurantBranch>, IRestaurantBranchWriteRepository
    {
        public RestaurantBranchWriteRepository(AppDbContext context) : base(context)
        {
        }
    }
}
