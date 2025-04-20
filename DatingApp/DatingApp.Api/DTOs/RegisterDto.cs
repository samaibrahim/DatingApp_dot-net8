using System.ComponentModel.DataAnnotations;

namespace DatingApp.Api.DTOs
{
    public class RegisterDto
    {
        [Required]
        [StringLength(20, MinimumLength = 4)]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
