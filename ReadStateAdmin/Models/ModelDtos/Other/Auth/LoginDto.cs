using System.ComponentModel.DataAnnotations;

namespace RealEstateAdmin.Models.ModelDtos.Other.Auth
{
    public class LoginDto
    {
        [Required]
        public string UsernameOrEmail { set; get; }
        [Required]
        public string Password { set; get; }
    }
}