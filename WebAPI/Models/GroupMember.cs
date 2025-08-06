using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models;

public class GroupMember
{
    [Key]
    [Required]
    public int IdGroupMember { get; set; }

    [Required]
    public int IdUser { get; set; }

    [Required]
    public int IdGroup { get; set; }

    [Required]
    public DateTime DateJoined { get; set; }

    [Required]
    public bool IsAdmin { get; set; }
}
