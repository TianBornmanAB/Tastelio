using AutoMapper;
using Tastelio.Application.DataTransferObjects;
using Tastelio.Application.Services.Abstractions;
using Tastelio.Domain.Entities;
using Tastelio.Domain.Repositories;

namespace Tastelio.Application.Services;

public class BaseService<TDto, TEntity> : IBaseService<TDto, TEntity> where TDto : BaseDto
                                                                                   where TEntity : BaseEntity
{
    private readonly IBaseRepository<TEntity> repository;
    protected readonly IMapper mapper;

    public BaseService(IBaseRepository<TEntity> repository, IMapper mapper)
    {
        this.repository = repository;
        this.mapper = mapper;
    }

    public async Task AddAsync(TDto dto)
    {
        var entity = mapper.Map<TEntity>(dto);

        await repository.AddAsync(entity);
    }

    public async Task<TDto?> GetAsync(Guid id)
    {
        var entity = await repository.GetAsync(id);
        var dto = mapper.Map<TDto>(entity);

        return dto;
    }

    public async Task<IEnumerable<TDto>> GetAsync(IEnumerable<Guid> ids)
    {
        var entities = await repository.GetAsync(ids);
        var dtos = mapper.Map<IEnumerable<TDto>>(entities);

        return dtos;
    }

    public async Task UpdateAsync(TDto dto)
    {
        var entity = mapper.Map<TEntity>(dto);

        await repository.UpdateAsync(entity);
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await repository.GetAsync(id) ?? throw new NullReferenceException();

        await repository.DeleteAsync(entity);
    }
}
