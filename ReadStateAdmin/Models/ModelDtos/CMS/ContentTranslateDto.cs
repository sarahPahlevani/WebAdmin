using System.ComponentModel.DataAnnotations;

namespace RealEstateAdmin.Models.ModelDtos.CMS
{
    public class ContentTranslateDto
    {
        public int Id { get; set; }

        [Required]
        public int ContentId { get; set; }

        public DAL.Models.Content Content { get; set; }

        [Required]
        public int LanguageId { get; set; }

        public DAL.Models.Language Language { get; set; }

        [Required]
        public string Title { get; set; }

        public string Body { get; set; }

    }
}
