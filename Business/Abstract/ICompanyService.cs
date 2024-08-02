using Entities;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICompanyService
    {
        Task<List<Company>> GetAllAsync();
        Task<Company> GetByCompanyIdAsync(int companyId);
        Task<Company> GetByCustomerIdAsync(int customerId);
        Task AddAsync(Company company);
        Task UpdateAsync(Company company);
        Task DeleteAsync(Company company);

        Task<List<CompanyDetailDto>> GetCompanyDetailsAsync();
        // Task<List<CompanyDetailDto>> GetCompanyDetailsByNameAsync(string name);

        Task<CompanyById> GetCompanyIdValuesByIdAsync(int companyId);
    }
}
