using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.AdoNet
{
    public class AdoNetCompanySectorDal:ICompanySectorDal
    {
        public Task<List<CompanySector>> GetAllAsync(Expression<Func<CompanySector, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<CompanySector> GetAsync(Expression<Func<CompanySector, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(CompanySector entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(CompanySector entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(CompanySector entity)
        {
            throw new NotImplementedException();
        }
    }
}
