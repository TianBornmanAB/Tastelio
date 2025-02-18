namespace Tastelio.Api.Requests;

public class UpdatePatronRequest : AddPatronRequest
{
    public required Guid Id { get; set; }
}
