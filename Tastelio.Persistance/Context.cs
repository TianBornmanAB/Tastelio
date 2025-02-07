using Microsoft.EntityFrameworkCore;
using Tastelio.Domain.Entities;

namespace Tastelio.Persistence;

public class Context : DbContext
{
    public required DbSet<Patron> Patrons { get; set; }
    public required DbSet<Establishment> Establishments { get; set; }
    public required DbSet<Reservation> Reservations { get; set; }

    public Context(DbContextOptions<Context> contextOptions) : base(contextOptions) { }
}
