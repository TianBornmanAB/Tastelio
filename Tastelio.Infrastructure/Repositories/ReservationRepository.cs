using Tastelio.Domain.Entities;
using Tastelio.Domain.Repositories;
using Tastelio.Persistence;

namespace Tastelio.Infrastructure.Repositories;

public class ReservationRepository : BaseRepository<Reservation>, IReservationRepository
{
    public ReservationRepository(TastelioContext context) : base(context)
    {
    }
}
