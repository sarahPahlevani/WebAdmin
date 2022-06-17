using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RealEstateAdmin.Models.ModelDtos.Page
{
    public class PageResultDto<T>
    {
        public int Count { get; set; }
        public IEnumerable<T> Items { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int Total { get; set; }

    }
}
