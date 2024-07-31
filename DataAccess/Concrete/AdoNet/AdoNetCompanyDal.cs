using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.AdoNet
{
    public class AdoNetCompanyDal: ICompanyDal
    {
        public Task<List<Company>> GetAllAsync(Expression<Func<Company, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<Company> GetAsync(Expression<Func<Company, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(Company entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Company entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Company entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<CompanyDetailDto>> GetCompanyDetailsAsync(Expression<Func<CompanyDetailDto, bool>> filter = null)
        {
            throw new NotImplementedException();
        }
    }
}
