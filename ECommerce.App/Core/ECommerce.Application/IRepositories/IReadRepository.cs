

using ECommerce.Domain.BaseEntities;
using System.Linq.Expressions;

namespace ECommerce.Application.IRepositories
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll(bool tracking = true);
        Task<T> GetByIdAsync(string id, bool tracking = true);


        Task<T> GetSingleAsync(Expression<Func<T, bool>> expression, bool tracking = true);
        IQueryable<T> GetWhere(Expression<Func<T, bool>> expression, bool tracking = true);


    }
}
