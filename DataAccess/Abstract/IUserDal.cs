using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess;

namespace DataAccess.Abstract
{
    public interface IUserDal:IEntityRepository<User>
    {
        //Özel operasyonlar
        Task<bool> IsUserExistAsync(string username);
        Task<bool> VerifyPasswordAsync(string password, string passwordHash);
        Task<string> GetPasswordHashByUsernameAsync(string username);
        Task UpdateLastActiveTimeAsync(string username);
    }
}