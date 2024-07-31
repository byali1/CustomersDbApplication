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
    public class AdoNetCountryDal : ICountryDal
    {
        public Task<List<Country>> GetAllAsync(Expression<Func<Country, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<Country> GetAsync(Expression<Func<Country, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(Country entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Country entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Country entity)
        {
            throw new NotImplementedException();
        }
    }
}
