﻿using eShopSolution.Application.Catalog.DTOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Application.Catalog.Products.Dtos.Public
{
    public class GetProductPagingRequest:PagingRequestBase
    {
        public int CategoryId { get; set; }
    }
}
