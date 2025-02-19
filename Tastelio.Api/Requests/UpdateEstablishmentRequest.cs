namespace Tastelio.Api.Requests;

public class UpdateEstablishmentRequest : AddEstablishmentRequest
{
    public required Guid Id { get; set; }
}
