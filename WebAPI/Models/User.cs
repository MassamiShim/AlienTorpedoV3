using System.ComponentModel.DataAnnotations;

namespace AlienTorpedoV3.Models
{
    public class User
    {
         public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public required string Username { get; set; }

        [Required]
        [EmailAddress]
        public required string Email { get; set; }

        [Required]
        [StringLength(100)]
        public required string Password { get; set; }
    }
}
