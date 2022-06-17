using Newtonsoft.Json.Linq;

namespace RealEstateAdmin.Models.ModelDtos.Page
{
    public class PageRequestFilterDto : PageRequestDto
    {
        public PageRequestFilterDto()
        {
        }

        public PageRequestFilterDto(int pageSize, int pageNumber) : base(pageSize, pageNumber)
        {
        }

        public JObject Filter { get; set; }
    }
}
