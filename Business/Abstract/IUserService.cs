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
        Task<List<User>> GetAllAsync();

        Task AddAsync(User user);
        Task UpdateAsync(User user);
        Task DeleteAsync(User user);

        Task<bool> IsUserExistAsync(string username);
        Task<bool> VerifyPasswordAsync(string password, string passwordHash);
        Task<string> GetPasswordHashByUsernameAsync(string username);
        Task UpdateLastActiveTimeAsync(string username);
    }
}
