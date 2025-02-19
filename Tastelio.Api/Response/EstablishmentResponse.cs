namespace Tastelio.Api.Response;

public class EstablishmentResponse
{
    public required Guid Id { get; set; }
    public required string Name { get; set; }
    public required decimal Latitude { get; set; }
    public required decimal Longitude { get; set; }
}
