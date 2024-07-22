using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal: EfEntityRepositoryBase<User, EfCustomersDbContext>, IUserDal
    {
        public bool IsUserExist(string username)
        {
            throw new NotImplementedException();
        }

        public bool VerifyPassword(string password, string passwordHash)
        {
            throw new NotImplementedException();
        }

        public string GetPasswordHashByUsername(string username)
        {
            throw new NotImplementedException();
        }
    }
}
