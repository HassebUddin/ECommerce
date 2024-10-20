
using ECommerce.Application.IRepositories.Web.DinnerTables;
using ECommerce.Domain.Entity.Web;
using ECommerce.Persistence.Context;

namespace ECommerce.Persistence.Repositories.Web.DinnerTables
{
    public class DinnerTableWriteRepository : WriteRepository<DinnerTable>, IDinnerTableWriteRepository
    {
        public DinnerTableWriteRepository(AppDbContext context) : base(context)
        {
        }
    }
}
