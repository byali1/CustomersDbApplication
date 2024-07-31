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
    public class AdoNetPersonGenderDal:IPersonGenderDal
    {
        public Task<List<PersonGender>> GetAllAsync(Expression<Func<PersonGender, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<PersonGender> GetAsync(Expression<Func<PersonGender, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(PersonGender entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(PersonGender entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(PersonGender entity)
        {
            throw new NotImplementedException();
        }
    }
}
