namespace Tastelio.Domain.Entities;

public class Patron : BaseEntity
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }

    #region Relationships

    public List<Reservation>? Reservations { get; set; }

    #endregion
}
