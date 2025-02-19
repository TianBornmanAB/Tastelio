namespace Tastelio.Domain.Entities;

public class Establishment : BaseEntity
{
    public required string Name { get; set; }
    public required decimal Latitude { get; set; }
    public required decimal Longitude { get; set; }

    #region Relationships

    public List<Reservation>? Reservations { get; set; }

    #endregion
}
