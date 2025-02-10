using Tastelio.Domain.Entities;
using Tastelio.Domain.Repositories;
using Tastelio.Persistence;

namespace Tastelio.Infrastructure.Repositories;

public class EstablishmentRepository : BaseRepository<Establishment>, IEstablishmentRepository
{
    public EstablishmentRepository(TastelioContext context) : base(context)
    {
    }
}
