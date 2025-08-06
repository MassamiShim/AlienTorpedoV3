using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class User
    {
        [Key]
        public int IdUser { get; set; }

        [Required]
        [StringLength(100)]
        public required string Username { get; set; }

        [Required]
        [EmailAddress]
        public required string Email { get; set; }

        [Required]
        [StringLength(100)]
        public required string Password { get; set; }

        public bool Status { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
    }
}
