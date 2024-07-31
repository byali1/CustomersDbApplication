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
    public class AdoNetPersonIdentityTypeDal:IPersonIdentityTypeDal
    {
        public Task<List<PersonIdentityType>> GetAllAsync(Expression<Func<PersonIdentityType, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<PersonIdentityType> GetAsync(Expression<Func<PersonIdentityType, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(PersonIdentityType entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(PersonIdentityType entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(PersonIdentityType entity)
        {
            throw new NotImplementedException();
        }
    }
}
