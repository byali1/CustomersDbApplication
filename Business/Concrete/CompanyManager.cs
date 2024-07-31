using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class CompanyManager : ICompanyService
    {
        private ICompanyDal _companyDal;

        public CompanyManager(ICompanyDal companyDal)
        {
            _companyDal = companyDal;
        }

        public async Task<List<Company>> GetAllAsync()
        {
            return await _companyDal.GetAllAsync();
        }

        public async Task<Company> GetByCompanyIdAsync(int companyId)
        {
            return await _companyDal.GetAsync(c=> c.CompanyId == companyId);
        }

        public async Task<Company> GetByCustomerIdAsync(int customerId)
        {
            return await _companyDal.GetAsync(c => c.CustomerId == customerId);
        }


        public async Task AddAsync(Company company)
        {
            await _companyDal.AddAsync(company);
        }

        public async Task UpdateAsync(Company company)
        {
            await _companyDal.UpdateAsync(company);
        }

        public async Task DeleteAsync(Company company)
        {
            await _companyDal.DeleteAsync(company);
        }

        public async Task<List<CompanyDetailDto>> GetCompanyDetailsAsync()
        {
            return await _companyDal.GetCompanyDetailsAsync();
        }

        
    }
}
