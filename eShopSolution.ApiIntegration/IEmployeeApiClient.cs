using eShopSolution.ViewModels.Common;
using eShopSolution.ViewModels.System.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.ApiIntegration
{
    public interface IEmployeeApiClient
    {
        Task<ApiResult<PageResult<EmployeeViewModel>>> GetEmployeesPagings(GetEmployeePagingRequest request);

        Task<ApiResult<bool>> UpdateEmployee(Guid id, EmployeeUpdateRequest request);

        Task<ApiResult<EmployeeViewModel>> GetById(Guid id);

        Task<ApiResult<bool>> Delete(Guid id);
    }
}