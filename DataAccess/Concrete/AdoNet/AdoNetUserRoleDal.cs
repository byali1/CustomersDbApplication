using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace DataAccess.Concrete.AdoNet
{
    public class AdoNetUserRoleDal: IUserRoleDal
    {
        public Task<List<UserRole>> GetAllAsync(Expression<Func<UserRole, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<UserRole> GetAsync(Expression<Func<UserRole, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(UserRole entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(UserRole entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(UserRole entity)
        {
            throw new NotImplementedException();
        }
    }
}
