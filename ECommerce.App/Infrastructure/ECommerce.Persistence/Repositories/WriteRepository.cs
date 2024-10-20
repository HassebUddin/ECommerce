
using ECommerce.Application.IRepositories;
using ECommerce.Domain.BaseEntities;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using ECommerce.Persistence.Context;

namespace ECommerce.Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        public AppDbContext _context;

        public WriteRepository(AppDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public async Task<bool> AddAsync(T entity)
        {
            EntityEntry entry = await Table.AddAsync(entity);
            return entry.State == EntityState.Added;

        }

        public async Task<bool> AddRangeAsync(List<T> entity)
        {
            await Table.AddRangeAsync(entity);
            return true;
        }

        public bool Remove(T entity)
        {
            EntityEntry entry = Table.Remove(entity);
            return entry.State == EntityState.Deleted;
        }

        public bool RemoveRange(List<T> entity)
        {
            Table.RemoveRange(entity);
            return true;
        }

        public async Task<bool> RemoveAsync(string id)
        {
            var entity = await Table.FirstOrDefaultAsync(x => x.Id == id);
            return Remove(entity!);
        }


        public bool Update(T entity)
        {
            Table.Update(entity);
            return true;
        }

        public async Task<int> SaveChangeAsync()
                       => await _context.SaveChangesAsync();

    }
}
