using System.ComponentModel.DataAnnotations;

namespace Dating.App.API.DTOs
{
    public class LoginDto
    {
        [Required]
        public string Username { get; set; }
        [Required]

        public string Password { get; set; }
    }
}
