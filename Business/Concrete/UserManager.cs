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

        public async Task<List<User>> GetAllAsync()
        {
            return await _userDal.GetAllAsync();
        }

        public async Task AddAsync(User user)
        {
            await _userDal.AddAsync(user);
        }

        public async Task UpdateAsync(User user)
        {
            await _userDal.UpdateAsync(user);
        }

        public async Task DeleteAsync(User user)
        {
            await _userDal.DeleteAsync(user);
        }

        public async Task<bool> IsUserExistAsync(string username)
        {
            return await _userDal.IsUserExistAsync(username);
        }

        public async Task<bool> VerifyPasswordAsync(string password, string passwordHash)
        {
            return await _userDal.VerifyPasswordAsync(password, passwordHash);
        }

        public async Task<string> GetPasswordHashByUsernameAsync(string username)
        {
            return await _userDal.GetPasswordHashByUsernameAsync(username);
        }

        public async Task UpdateLastActiveTimeAsync(string username)
        {
            await _userDal.UpdateLastActiveTimeAsync(username);
        }
    }
}
