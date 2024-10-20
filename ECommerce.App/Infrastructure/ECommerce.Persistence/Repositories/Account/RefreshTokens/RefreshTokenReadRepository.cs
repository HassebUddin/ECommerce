using ECommerce.Application.IRepositories.Account.RefreshTokens;
using ECommerce.Domain.Entity.Account;
using ECommerce.Persistence.Context;

namespace ECommerce.Persistence.Repositories.Account.RefreshTokens
{
    internal class RefreshTokenReadRepository : ReadRepository<RefreshToken>, IRefreshTokenReadRepository
    {
        public RefreshTokenReadRepository(AppDbContext context) : base(context)
        {
        }
    }
}
