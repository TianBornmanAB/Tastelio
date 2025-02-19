namespace Tastelio.Application.DataTransferObjects;

public class EstablishmentDto : BaseDto
{
    public required string Name { get; set; }
    public required decimal Latitude { get; set; }
    public required decimal Longitude { get; set; }
}
