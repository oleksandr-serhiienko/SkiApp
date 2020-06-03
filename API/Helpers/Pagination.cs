using Microsoft.EntityFrameworkCore.Metadata.Conventions.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Helpers
{
    public class Pagination<T> where T : class
    {
        public Pagination(int pageIndex, int pageSize, int count, IReadOnlyList<T> date)
        {
            PageIndex = pageIndex;
            PageSize = pageSize;
            Count = count;
            Date = date;
        }

        public int PageIndex { get; set; }

        public int PageSize { get; set; }

        public int Count { get; set; }

        public IReadOnlyList<T> Date { get; set; }
    }
}
