using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models;

public class GroupEvent
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int IdGroup { get; set; }

    [Required]
    public int IdEvent { get; set; }

    public DateTime DateCreated { get; set; } = DateTime.UtcNow;
    public DateTime? DateEvent { get; set; }


}
