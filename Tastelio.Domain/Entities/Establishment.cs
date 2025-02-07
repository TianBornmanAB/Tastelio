namespace Tastelio.Domain.Entities;

public class Establishment : BaseEntity
{
    public required string Name { get; set; }
    public decimal Latitude { get; set; }
    public decimal Longitude { get; set; }

    #region Relationships

    public List<Reservation>? Reservations { get; set; }

    #endregion
}
