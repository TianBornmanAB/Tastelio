using AutoMapper;
using Tastelio.Application.DataTransferObjects;
using Tastelio.Application.Services.Abstractions;
using Tastelio.Domain.Entities;
using Tastelio.Domain.Repositories;

namespace Tastelio.Application.Services;

public class PatronService : BaseService<PatronDto, Patron>, IPatronService
{
    public PatronService(IBaseRepository<Patron> repository, IMapper mapper) : base(repository, mapper)
    {
    }
}
