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
        bool IsUserExist(string username);
        bool VerifyPassword(string password, string passwordHash);
        string GetPasswordHashByUsername(string username);
    }
}