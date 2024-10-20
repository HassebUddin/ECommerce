
using ECommerce.Domain.BaseEntities;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Application.IRepositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        public DbSet<T> Table { get; }

    }
}
