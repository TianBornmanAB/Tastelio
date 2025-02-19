using Microsoft.EntityFrameworkCore;
using Tastelio.Domain.Entities;
using Tastelio.Domain.Repositories;
using Tastelio.Persistence;

namespace Tastelio.Infrastructure.Repositories;

public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
{
    private readonly TastelioContext context;
    protected readonly DbSet<TEntity> dbSet;

    public BaseRepository(TastelioContext context)
    {
        this.context = context;
        dbSet = context.Set<TEntity>();
    }

    public virtual async Task AddAsync(TEntity entity)
    {
        await dbSet.AddAsync(entity);
        await context.SaveChangesAsync();
    }

    public virtual async Task<TEntity?> GetAsync(Guid id)
    {
        return await dbSet.FindAsync(id);
    }

    public virtual async Task<IEnumerable<TEntity>> GetAsync(int page, int pageSize)
    {
        return await dbSet.OrderBy(entity => entity.DateCreated).Skip(page * pageSize).Take(pageSize).ToListAsync();
    }

    public async Task UpdateAsync(TEntity entity)
    {
        entity.DateUpdated = DateTime.Now;

        dbSet.Update(entity);

        context.Entry(entity).Property("DateCreated").IsModified = false;
        await context.SaveChangesAsync();
    }

    public virtual Task DeleteAsync(TEntity entity)
    {
        dbSet.Remove(entity);
        return context.SaveChangesAsync();
    }
}
