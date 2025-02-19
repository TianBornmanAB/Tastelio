using AutoMapper;
using Tastelio.Application.DataTransferObjects;
using Tastelio.Application.Services.Abstractions;
using Tastelio.Domain.Entities;
using Tastelio.Domain.Repositories;

namespace Tastelio.Application.Services;

public class EstablishmentService : BaseService<EstablishmentDto, Establishment>, IEstablishmentService
{
    public EstablishmentService(IBaseRepository<Establishment> repository, IMapper mapper) : base(repository, mapper)
    {
    }
}
