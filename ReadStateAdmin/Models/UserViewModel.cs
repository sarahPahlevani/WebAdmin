using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateAdmin.Models
{
    public class DashboardAccess
    {
        public string name { get; set; }
        public bool accessToPage { get; set; }
        public bool accessCreate { get; set; }
        public bool accessGet { get; set; }
        public bool accessUpdate { get; set; }
        public bool accessDelete { get; set; }
        public bool accessModify { get; set; }
    }

    public class EstateAccess
    {
        public string name { get; set; }
        public bool accessToPage { get; set; }
        public bool accessCreate { get; set; }
        public bool accessGet { get; set; }
        public bool accessUpdate { get; set; }
        public bool accessDelete { get; set; }
        public bool accessModify { get; set; }
    }

    public class BasicInformationAccess
    {
        public string name { get; set; }
        public bool accessToPage { get; set; }
        public bool accessCreate { get; set; }
        public bool accessGet { get; set; }
        public bool accessUpdate { get; set; }
        public bool accessDelete { get; set; }
        public bool accessModify { get; set; }
    }

    public class ProjectAccess
    {
        public string name { get; set; }
        public bool accessToPage { get; set; }
        public bool accessCreate { get; set; }
        public bool accessGet { get; set; }
        public bool accessUpdate { get; set; }
        public bool accessDelete { get; set; }
        public bool accessModify { get; set; }
    }

    public class UsersAccess
    {
        public string name { get; set; }
        public bool accessToPage { get; set; }
        public bool accessCreate { get; set; }
        public bool accessGet { get; set; }
        public bool accessUpdate { get; set; }
        public bool accessDelete { get; set; }
        public bool accessModify { get; set; }
    }

    public class AgentsAccess
    {
        public string name { get; set; }
        public bool accessToPage { get; set; }
        public bool accessCreate { get; set; }
        public bool accessGet { get; set; }
        public bool accessUpdate { get; set; }
        public bool accessDelete { get; set; }
        public bool accessModify { get; set; }
    }

    public class UserGroup
    {
        public int id { get; set; }
        public string name { get; set; }
        public string staticCode { get; set; }
        public DashboardAccess dashboardAccess { get; set; }
        public EstateAccess estateAccess { get; set; }
        public BasicInformationAccess basicInformationAccess { get; set; }
        public ProjectAccess projectAccess { get; set; }
        public UsersAccess usersAccess { get; set; }
        public AgentsAccess agentsAccess { get; set; }
    }

    public class UserViewModel
    {
        public int id { get; set; }
        public int? authenticationProviderId { get; set; }
        public string authenticationProviderAccessToken { get; set; }
        public string userName { get; set; }
        public string passwordHash { get; set; }
        public string passwordSalt { get; set; }
        public bool isActive { get; set; }
        public bool isConfirmed { get; set; }
        public bool hasExternalAuthentication { get; set; }
        public string activationKey { get; set; }
        public string resetPasswordKey { get; set; }
        public DateTime registrationDate { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleName { get; set; }
        public string email { get; set; }
        public string phone01 { get; set; }
        public string phone02 { get; set; }
        public string address01 { get; set; }
        public string address02 { get; set; }
        public string zipCode { get; set; }
        public string userPicture { get; set; }
        public string userPictureTumblr { get; set; }
        public UserGroup userGroup { get; set; }
        public int? languageId { get; set; }
        public string token { get; set; }
        public int? agentId { get; set; }
        public int? realEstateId { get; set; }
        public bool? isResponsible { get; set; }
        public bool isAgent { get; set; }
        public string activationLink { get; set; }
        public bool hasPublishingAuthorization { get; set; }
    }


    public class RegisterViewModel
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string recaptchaToken { get; set; }
        public string realEstateName { get; set; }
    }
}
