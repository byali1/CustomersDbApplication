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
    public class AdoNetDistrictDal:IDistrictDal
    {
        public Task<List<District>> GetAllAsync(Expression<Func<District, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<District> GetAsync(Expression<Func<District, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(District entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(District entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(District entity)
        {
            throw new NotImplementedException();
        }
    }
}
