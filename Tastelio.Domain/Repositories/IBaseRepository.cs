using Tastelio.Domain.Entities;

namespace Tastelio.Domain.Repositories;

public interface IBaseRepository<TEntity> where TEntity : BaseEntity
{
    Task AddAsync(TEntity entity);
    Task<TEntity?> GetAsync(Guid id);
    Task<IEnumerable<TEntity>> GetAsync(IEnumerable<Guid> ids);
    Task UpdateAsync(TEntity entity);
    Task DeleteAsync(TEntity entity);
}
