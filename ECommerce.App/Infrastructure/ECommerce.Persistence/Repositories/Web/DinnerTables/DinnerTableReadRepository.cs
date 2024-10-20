

using ECommerce.Application.IRepositories.Web.DinnerTables;
using ECommerce.Domain.Entity.Web;
using ECommerce.Persistence.Context;

namespace ECommerce.Persistence.Repositories.Web.DinnerTables
{
    public class DinnerTableReadRepository : ReadRepository<DinnerTable>, IDinnerTableReadRepository
    {
        public DinnerTableReadRepository(AppDbContext context) : base(context)
        {
        }
    }
}
