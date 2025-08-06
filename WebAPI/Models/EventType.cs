using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models;

public class EventType
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public required string Name { get; set; }

}
