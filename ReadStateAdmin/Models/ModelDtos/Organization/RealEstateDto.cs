using Microsoft.AspNetCore.Http;
using RealEstateAdmin.Models.DAL.DtoContracts;
using RealEstateAdmin.Models.DAL.Models;
using System;

namespace RealEstateAdmin.Models.ModelDtos.Organization
{
    public class RealEstateDto
    {
        public int Id { get; set; }
        public int LanguageIdDefault { get; set; }
        public string Name { get; set; }
        public string Address01 { get; set; }
        public string Address02 { get; set; }
        public string Phone01 { get; set; }
        public string Phone02 { get; set; }
        public string Phone03 { get; set; }
        public string Fax { get; set; }
        public string ZipCode { get; set; }
        public string Email { get; set; }
        public string WebsiteUrl { get; set; }
        public string MetadataJson { get; set; }
        public VmRealEstateMetadata Metadata { get; set; }
        public string DateFormat { get; set; }
        public int CurrencyId { get; set; }
        public string Domain { get; set; }
        public string Logo { get; set; }
        public string LogoMobile { get; set; }
        public string HeaderBackground { get; set; }
        public string HeaderPicture { get; set; }
        public IFormFile LogoFile { get; set; }
        public IFormFile LogoMobFile { get; set; }
        public IFormFile HeaderBackgroundFile { get; set; }
        public IFormFile HeaderPicFile { get; set; }
        public bool Deleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int? UserAccountId_DeleteBy { get; set; }

    }
}
