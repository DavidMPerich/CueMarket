using System.ComponentModel.DataAnnotations;

namespace CueMarket.API.Models.DTO
{
    public class AddUserRequestDto
    {
        [Required]
        [MinLength(3, ErrorMessage = "Name has to be at least 3 characters long.")]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
