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
        public List<UserRole> GetAll(Expression<Func<UserRole, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public UserRole Get(Expression<Func<UserRole, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Add(UserRole entity)
        {
            throw new NotImplementedException();
        }

        public void Update(UserRole entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(UserRole entity)
        {
            throw new NotImplementedException();
        }
    }
}
