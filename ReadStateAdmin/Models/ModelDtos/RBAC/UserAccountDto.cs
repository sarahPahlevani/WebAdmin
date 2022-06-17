using RealEstateAdmin.Models.DAL.DtoContracts;
using RealEstateAdmin.Models.DAL.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace RealEstateAdmin.Models.ModelDtos.RBAC
{
    public class UserAccountDto
    {
        public int Id { get; set; }
        public int? AuthenticationProviderId { get; set; }
        public string AuthenticationProviderAccessToken { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public bool? IsActive { get; set; }
        public bool IsConfirmed { get; set; }
        public bool HasExternalAuthentication { get; set; }
        public string ActivationKey { get; set; }
        public string ResetPasswordKey { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Email { get; set; }
        public string Phone01 { get; set; }
        public string Phone02 { get; set; }
        public int? CountryId { get; set; }
        public string CountryName { get; set; }
        public string City { get; set; }
        public string Address01 { get; set; }
        public string Address02 { get; set; }
        public string ZipCode { get; set; }
        public string VatCode { get; set; }
        public string UserPicture { get; set; }
        public string UserPictureTumblr { get; set; }
        public string ReferralCode { get; set; }

        public Other.UserGroupMetadata UserGroup { get; set; }
        public int? LanguageId { get; set; }
        public string Token { get; set; }
        public int? AgentId { get; set; }
        public int? RealEstateId { get; set; }
        public bool? IsResponsible { get; set; }
        public bool IsAgent { get; set; }
        public string ActivationLink { get; set; }
        public bool HasPublishingAuthorization { get; set; }

    }
}
