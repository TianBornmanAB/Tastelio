using Microsoft.EntityFrameworkCore;
using Tastelio.Domain.Entities;
using Tastelio.Domain.Repositories;
using Tastelio.Persistence;

namespace Tastelio.Infrastructure.Repositories;

public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
{
    private readonly TastelioContext context;
    protected readonly DbSet<T> dbSet;

    public BaseRepository(TastelioContext context)
    {
        this.context = context;
        dbSet = context.Set<T>();
    }

    public virtual async Task AddAsync(T entity)
    {
        await dbSet.AddAsync(entity);
        await context.SaveChangesAsync();
    }

    public virtual async Task<T?> GetAsync(Guid id)
    {
        return await dbSet.FindAsync(id);
    }

    public virtual async Task<IEnumerable<T>> GetAsync(IEnumerable<Guid> ids)
    {
        return await dbSet.Where(entity => ids.Contains(entity.Id)).ToListAsync();
    }

    public async Task UpdateAsync(T entity)
    {
        dbSet.Update(entity);
        await context.SaveChangesAsync();
    }

    public virtual Task DeleteAsync(T entity)
    {
        dbSet.Remove(entity);
        return context.SaveChangesAsync();
    }
}
