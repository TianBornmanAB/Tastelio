namespace Tastelio.Api.Requests;

public class AddEstablishmentRequest
{
    public required string Name { get; set; }
    public required decimal Latitude { get; set; }
    public required decimal Longitude { get; set; }
}
