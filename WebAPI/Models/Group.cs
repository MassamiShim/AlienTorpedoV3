using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models;

public class Group
{
    [Key]
    public int IdGroup { get; set; }

    [Required]
    [StringLength(100)]
    public required string GroupName { get; set; }

    [Required]
    [StringLength(500)]
    public required string Description { get; set; }

    public DateTime DateCreated { get; set; } = DateTime.UtcNow;
}
