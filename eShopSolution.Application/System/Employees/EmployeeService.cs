using eShopSolution.Data.EF;
using eShopSolution.ViewModels.Common;
using eShopSolution.ViewModels.System.Employees;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace eShopSolution.Application.System.Employees
{
    public class EmployeeService : IEmployeeService
    {
        private readonly EShopDBContext _context;

        public EmployeeService(EShopDBContext context)
        {
            _context = context;
        }

        public Task AddViewcount(int employeeId)
        {
            throw new NotImplementedException();
        }

        public Task<int> Create(EmployeeCreateRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(int employeeId)
        {
            throw new NotImplementedException();
        }

        public Task<PageResult<EmployeeViewModel>> GetAllByCategoryId(string languageId, GetEmployeePagingRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<ApiSuccessResult<PageResult<EmployeeViewModel>>> GetEmployeePaging(GetEmployeePagingRequest request)
        {
            var query = from e in _context.InfoEmployees select new { e };
            if (!string.IsNullOrEmpty(request.Keyword))
            {
                query = query.Where(x => x.e.MA_NV.Contains(request.Keyword) || x.e.HO_TEN.Contains(request.Keyword));
            }
            //3. Paging
            int totalRow = await query.CountAsync();

            var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
                .Take(request.PageSize)
                .Select(x => new EmployeeViewModel()
                {
                    Id = x.e.Id,
                    DVCS_ID = x.e.DVCS_ID,
                    MA_NV = x.e.MA_NV,
                    HO_TEN = x.e.HO_TEN,
                    MA_PB = x.e.MA_PB,
                    NGAY_SINH = x.e.NGAY_SINH,
                    GIOI_TINH = x.e.GIOI_TINH,
                    TON_GIAO = x.e.TON_GIAO,
                    DAN_TOC = x.e.DAN_TOC,
                    HON_NHAN = x.e.HON_NHAN,
                    QUOC_TICH = x.e.QUOC_TICH,
                    CMND = x.e.CMND,
                    NGAY_CAP = x.e.NGAY_CAP,
                    NOI_CAP = x.e.NOI_CAP,
                    QUE_QUAN = x.e.QUE_QUAN,
                    NOI_SINH = x.e.NOI_SINH,
                    DTDD = x.e.DTDD,
                    EMAIL = x.e.EMAIL,
                    DIA_CHI = x.e.DIA_CHI,
                    LUONG_CB = x.e.LUONG_CB.ToString("#,###"),
                    LUONG_BH = x.e.LUONG_BH.ToString("#,###")
                }).ToListAsync();

            //4. Select and projection
            var pagedResult = new PageResult<EmployeeViewModel>()
            {
                TotalRecords = totalRow,
                PageIndex = request.PageIndex,
                PageSize = request.PageSize,
                Items = data
            };
            return new ApiSuccessResult<PageResult<EmployeeViewModel>>(pagedResult);
        }

        public Task<EmployeeViewModel> GetById(int employeeId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<EmployeeViewModel>> GetAll()
        {
            var query = from e in _context.InfoEmployees
                        select new { e };
            var data = await query.Select(x => new EmployeeViewModel()
            {
                Id = x.e.Id,
                DVCS_ID = x.e.DVCS_ID,
                MA_NV = x.e.MA_NV,
                HO_TEN = x.e.HO_TEN,
                MA_PB = x.e.MA_PB,
                NGAY_SINH = x.e.NGAY_SINH,
                GIOI_TINH = x.e.GIOI_TINH,
                TON_GIAO = x.e.TON_GIAO,
                DAN_TOC = x.e.DAN_TOC,
                HON_NHAN = x.e.HON_NHAN,
                QUOC_TICH = x.e.QUOC_TICH,
                CMND = x.e.CMND,
                NGAY_CAP = x.e.NGAY_CAP,
                NOI_CAP = x.e.NOI_CAP,
                QUE_QUAN = x.e.QUE_QUAN,
                NOI_SINH = x.e.NOI_SINH,
                DTDD = x.e.DTDD,
                EMAIL = x.e.EMAIL,
                DIA_CHI = x.e.DIA_CHI,
                LUONG_CB = x.e.LUONG_CB.ToString("#,###"),
                LUONG_BH = x.e.LUONG_BH.ToString("#,###")
            }).ToListAsync();

            return data;
        }

        public Task<ApiResult<PageResult<GetEmployeePagingRequest>>> GetUsersPaging(GetEmployeePagingRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(EmployeeUpdateRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateSalary(int employtId, decimal newSalaryBasic, decimal newSalaryInsurance)
        {
            throw new NotImplementedException();
        }
    }
}