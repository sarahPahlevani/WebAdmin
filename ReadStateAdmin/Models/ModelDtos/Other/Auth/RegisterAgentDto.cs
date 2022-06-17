
using System.ComponentModel.DataAnnotations;

namespace RealEstateAdmin.Models.ModelDtos.Other.Auth
{
    public class RegisterAgentDto : RegisterUserDto
    {
        
        public string RealEstateName { set; get; }

        public bool HasPublishingAuthorization { set; get; }

        public bool IsResponsible { set; get; }
    }
}