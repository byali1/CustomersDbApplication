using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class CompanySectorManager:ICompanyService
    {
        public Task<List<Company>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Company> GetByCompanyIdAsync(int companyId)
        {
            throw new NotImplementedException();
        }

        public Task<Company> GetByCustomerIdAsync(int customerId)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(Company company)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Company company)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Company company)
        {
            throw new NotImplementedException();
        }

        public Task<List<CompanyDetailDto>> GetCompanyDetailsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
