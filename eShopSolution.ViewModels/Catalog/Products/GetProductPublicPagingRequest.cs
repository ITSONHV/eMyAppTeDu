﻿using eShopSolution.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModels.Catalog.Products
{
    public class GetProductPublicPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}
