using System.ComponentModel.DataAnnotations;

namespace OneSalonManager.API.DTOs
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        
        [Required]
        [StringLength(8, MinimumLength= 4, ErrorMessage = "Length should be between 4 and 8 characters.")]
        public string Password { get; set; }
    }
}