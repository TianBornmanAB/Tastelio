namespace Tastelio.Application.DataTransferObjects;

public class BaseDto
{
    public Guid Id { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime? DateUpdated { get; set; }
}
