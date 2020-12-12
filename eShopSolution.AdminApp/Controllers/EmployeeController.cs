using eShopSolution.AdminApp.Services;
using eShopSolution.ViewModels.System.Employees;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.AdminApp.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeApiClient _employeeApiClient;
        private readonly IConfiguration _configuration;

        public EmployeeController(IEmployeeApiClient employeeApiClient, IConfiguration configuration)
        {
            _employeeApiClient = employeeApiClient;
            _configuration = configuration;
        }

        public async Task<IActionResult> Index(string keyword, int pageIndex = 1, int pageSize = 10)
        {
            var sessions = HttpContext.Session.GetString("token");
            var request = new GetEmployeePagingRequest()
            {
                BearerToken = sessions,
                Keyword = keyword,
                PageIndex = pageIndex,
                PageSize = pageSize
            };
            ViewBag.Keyword = keyword;
            var data = await _employeeApiClient.GetEmployeesPagings(request);
            return View(data.ResultObj);
        }
    }
}