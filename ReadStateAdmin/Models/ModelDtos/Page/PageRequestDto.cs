using System.ComponentModel.DataAnnotations;

namespace RealEstateAdmin.Models.ModelDtos.Page
{
    public class PageRequestDto : IPageRequest
    {
        public PageRequestDto()
        {
        }

        public PageRequestDto(int pageSize, int pageNumber)
        {
            PageSize = pageSize;
            PageNumber = pageNumber;
        }

        [Required]
        public int PageNumber { get; set; }

        [Required]
        public int PageSize { get; set; }
    }

    public interface IPageRequest
    {
        int PageNumber { set; get; }
        int PageSize { set; get; }
    }
}
