using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models;

public class Event
{
    [Key]
    public int IdEvent { get; set; }

    [Required]
    [StringLength(200)]
    public required string EventName { get; set; }

    [Required]
    [StringLength(500)]
    public required string Description { get; set; }

    [Required]
    public required EventType Type { get; set; }
    public DateTime DateCreated { get; set; } = DateTime.UtcNow;

    public bool IsActive { get; set; } = true;

    public double? Value { get; set; }
    public double? Rating { get; set; }
    public bool isPrivate { get; set; } = false;
    public User? IdUser { get; set; }

    public Group? IdGroup { get; set; }
}
