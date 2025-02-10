using Tastelio.Domain.Entities;
using Tastelio.Domain.Repositories;
using Tastelio.Persistence;

namespace Tastelio.Infrastructure.Repositories;

public class PatronRepository : BaseRepository<Patron>, IPatronRepository
{
    public PatronRepository(TastelioContext context) : base(context)
    {
    }
}
