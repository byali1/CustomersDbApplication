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
    public class AdoNetCityDal : ICityDal
    {
        public Task<List<City>> GetAllAsync(Expression<Func<City, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<City> GetAsync(Expression<Func<City, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(City entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(City entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(City entity)
        {
            throw new NotImplementedException();
        }
    }
}
