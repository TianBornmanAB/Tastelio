namespace Tastelio.Domain.Entities;

public class Reservation : BaseEntity
{
    public required Guid PatronId { get; set; }

    public required Guid EstablishmentId { get; set; }

    public required DateTime Date { get; set; }

    public required int SeatCount { get; set; }

    #region Relationships

    public Patron? Patron { get; set; }

    public Establishment? Establishment { get; set; }

    #endregion
}
