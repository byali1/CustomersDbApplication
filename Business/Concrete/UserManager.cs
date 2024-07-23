using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{

    public class UserManager : IUserService
    {
        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public List<User> GetAll()
        {
            return _userDal.GetAll();
        }

        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public void Update(User user)
        {
            _userDal.Update(user);
        }

        public void Delete(User user)
        {
            _userDal.Delete(user);
        }

        public bool IsUserExist(string username)
        {
            return _userDal.IsUserExist(username);
        }

        public bool VerifyPassword(string password, string passwordHash)
        {
            return _userDal.VerifyPassword(password, passwordHash);
        }

        public string GetPasswordHashByUsername(string username)
        {
            return _userDal.GetPasswordHashByUsername(username);
        }

        public void UpdateLastActiveTime(string username)
        {
            _userDal.UpdateLastActiveTime(username);
        }
    }
}
