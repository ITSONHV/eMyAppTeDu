using eShopSolution.ViewModels.Common;
using eShopSolution.ViewModels.System.Employees;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Application.System.Employees
{
    public interface IEmployeeService
    {
        Task<int> Create(EmployeeCreateRequest request);

        Task<int> Update(EmployeeUpdateRequest request);

        Task<int> Delete(int employeeId);

        Task<EmployeeViewModel> GetById(int employeeId);

        Task<List<EmployeeViewModel>> GetAll();

        Task<bool> UpdateSalary(int employtId, decimal newSalaryBasic, decimal newSalaryInsurance);

        Task AddViewcount(int employeeId);

        Task<ApiSuccessResult<PageResult<EmployeeViewModel>>> GetEmployeePaging(GetEmployeePagingRequest request);

        Task<PageResult<EmployeeViewModel>> GetAllByCategoryId(string languageId, GetEmployeePagingRequest request);
    }
}