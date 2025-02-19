namespace Tastelio.Api.Response;

public class PatronResponse
{
    public required Guid Id { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
}
