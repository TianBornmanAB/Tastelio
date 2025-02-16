namespace Tastelio.Application.DataTransferObjects;

public class PatronDto : BaseDto
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
}
