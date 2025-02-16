using Tastelio.Application.DataTransferObjects;
using Tastelio.Domain.Entities;

namespace Tastelio.Application.Services.Abstractions;

public interface IPatronService : IBaseService<PatronDto, Patron>
{
}
