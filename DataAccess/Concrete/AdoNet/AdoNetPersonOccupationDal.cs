using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;

namespace DataAccess.Concrete.AdoNet
{
    public class AdoNetPersonOccupationDal: IPersonOccupationDal
    {
        public Task<List<PersonOccupation>> GetAllAsync(Expression<Func<PersonOccupation, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<PersonOccupation> GetAsync(Expression<Func<PersonOccupation, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(PersonOccupation entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(PersonOccupation entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(PersonOccupation entity)
        {
            throw new NotImplementedException();
        }
    }
}
