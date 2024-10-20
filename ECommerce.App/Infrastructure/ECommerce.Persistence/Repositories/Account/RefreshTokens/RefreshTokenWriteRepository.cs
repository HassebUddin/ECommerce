using ECommerce.Application.IRepositories.Account.RefreshTokens;
using ECommerce.Domain.Entity.Account;
using ECommerce.Persistence.Context;

namespace ECommerce.Persistence.Repositories.Account.RefreshTokens
{
    public class RefreshTokenWriteRepository : WriteRepository<RefreshToken>, IRefreshTokenWriteRepository
    {
        public RefreshTokenWriteRepository(AppDbContext context) : base(context)
        {
        }
    }
}
