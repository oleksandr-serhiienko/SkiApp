using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Core.Specifications
{
    public class ProductSpecParams
    {
        private const int MaxPageSize = 50;

        public int PageIndex { get; set; } = 1;

        private int pageSize = 6;

        public int PageSize
        {
            get => pageSize;
            set => pageSize = (value > MaxPageSize) ? MaxPageSize : value;
        }
        public int? BrandId { get; set; }

        public int? TypeId { get; set; }
        
        public string Sort { get; set; }

        private string serach;

        public string Search
        {
            get => serach;
            set => serach = value.ToLower();
        }
    }
}
