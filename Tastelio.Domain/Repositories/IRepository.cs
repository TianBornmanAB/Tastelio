namespace Tastelio.Domain.Repositories;

public interface IRepository<T>
{
    Task Add(T entity);
    Task<T?> Get(Guid id);
    Task<IEnumerable<T>> Get(IEnumerable<Guid> ids);
    Task Update(T entity);
    Task Delete(T entity);
}
