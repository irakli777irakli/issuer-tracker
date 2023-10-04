using System.ComponentModel.DataAnnotations;

namespace Core.Entitities
{
    public class User
    {
        public int Id { get; set; }
        [StringLength(40)]  
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public DateOnly DateOfBirth { get; set; }

        public DateOnly JoinedAt { get; set; } = DateOnly.FromDateTime(DateTime.Now);

    }
}