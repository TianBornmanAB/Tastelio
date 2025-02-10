using Tastelio.Application.DataTransferObjects;
using Tastelio.Domain.Entities;

namespace Tastelio.Application.Services;

public interface IBaseService<TDto, TEntity> where TDto : BaseDto 
                                             where TEntity : BaseEntity
{
    Task Add(TDto dto);
    Task<TDto?> Get(Guid id);
    Task<IEnumerable<TDto>> Get(IEnumerable<Guid> ids);
    Task Update(TDto dto);
    Task Delete(Guid id);
}
