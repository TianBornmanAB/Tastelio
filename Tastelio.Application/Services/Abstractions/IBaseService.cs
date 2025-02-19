using Tastelio.Application.DataTransferObjects;
using Tastelio.Domain.Entities;

namespace Tastelio.Application.Services.Abstractions;

public interface IBaseService<TDto, TEntity> where TDto : BaseDto
                                             where TEntity : BaseEntity
{
    Task AddAsync(TDto dto);
    Task<TDto?> GetAsync(Guid id);
    Task<PagedDto<TDto>> GetAsync(PagedDto<TDto> dto);
    Task UpdateAsync(TDto dto);
    Task DeleteAsync(Guid id);
}
