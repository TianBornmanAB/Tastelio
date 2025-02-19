using System.ComponentModel.DataAnnotations;

namespace Tastelio.Domain.Entities;

public class BaseEntity
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();
    public required DateTime DateCreated { get; set; } = DateTime.Now;
    public DateTime? DateUpdated { get; set; }
    public bool Active { get; set; } = true;
}
