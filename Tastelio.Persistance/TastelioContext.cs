using Microsoft.EntityFrameworkCore;
using Tastelio.Domain.Entities;

namespace Tastelio.Persistence;

public class TastelioContext : DbContext
{
    public required DbSet<Patron> Patrons { get; set; }
    public required DbSet<Establishment> Establishments { get; set; }
    public required DbSet<Reservation> Reservations { get; set; }

    public TastelioContext(DbContextOptions<TastelioContext> contextOptions) : base(contextOptions) { }
}
