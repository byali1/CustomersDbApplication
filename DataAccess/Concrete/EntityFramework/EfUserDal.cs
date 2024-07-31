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
        public Task<bool> IsUserExistAsync(string username)
        {
            throw new NotImplementedException();
        }

        public Task<bool> VerifyPasswordAsync(string password, string passwordHash)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetPasswordHashByUsernameAsync(string username)
        {
            throw new NotImplementedException();
        }

        public Task UpdateLastActiveTimeAsync(string username)
        {
            throw new NotImplementedException();
        }
    }
}
