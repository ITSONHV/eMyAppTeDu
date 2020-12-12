using eShopSolution.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModels.System.Employees
{
    public class GetEmployeePagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
    }
}