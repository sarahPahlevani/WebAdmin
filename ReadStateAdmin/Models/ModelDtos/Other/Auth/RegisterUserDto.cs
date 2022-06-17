using System.ComponentModel.DataAnnotations;
using RealEstateAdmin.Models.DAL.Contracts;

namespace RealEstateAdmin.Models.ModelDtos.Other.Auth
{
    public class RegisterUserDto
    {
        [Required]
        public string Firstname { set; get; }
        public string Middlename { set; get; }
        [Required]
        public string Lastname { set; get; }
        [Required]
        public string Username { set; get; }
        [Required]
        public string Email { set; get; }
        [Required]
        public string Password { set; get; }
        public string RecaptchaToken { get; set; }
        public int? RealEstateId { get; set; }
    }
}