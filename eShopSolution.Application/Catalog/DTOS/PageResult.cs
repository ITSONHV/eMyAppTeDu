using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Application.Catalog.DTOS
{
    public class PageResult<T>
    {
        List<T> Items { get; set; }
        public int TotalRecord { get; set; }
    }
}
