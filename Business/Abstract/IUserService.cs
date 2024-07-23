using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        List<User> GetAll();

        void Add(User user);
        void Update(User user);
        void Delete(User user);

        bool IsUserExist(string username);
        bool VerifyPassword(string password, string passwordHash);
        string GetPasswordHashByUsername(string username);
        void UpdateLastActiveTime(string username);
    }
}
