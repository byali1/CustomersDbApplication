using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using DataAccess.Abstract.PasswordHashing;
using Entities.Concrete;

namespace DataAccess.Concrete.AdoNet
{
    public class AdoNetUserDal : IUserDal
    {
        private readonly IDbContext _dbContext;
        private readonly IPasswordHasher _passwordHasher;

        public AdoNetUserDal(IDbContext dbContext, IPasswordHasher passwordHasher)
        {
            _dbContext = dbContext;
            _passwordHasher = passwordHasher;
        }

        public async Task<List<User>> GetAllAsync(Expression<Func<User, bool>> filter = null)
        {
            _dbContext.OpenConnectionIfClosed();

            using (var sqlCommand = new SqlCommand("Select * from Users", _dbContext.GetConnection()))
            {
                using (var reader = await sqlCommand.ExecuteReaderAsync())
                {
                    var users = new List<User>();

                    while (await reader.ReadAsync())
                    {
                        var user = new User
                        {
                            UserId = Convert.ToInt32(reader["UserId"]),
                            UserRoleId = Convert.ToInt32(reader["UserRoleId"]),
                            Username = reader["Username"].ToString(),
                            PasswordHash = reader["PasswordHash"].ToString(),
                            AccountCreatedTime = Convert.ToDateTime(reader["AccountCreatedTime"]),
                            LastAciveTime = Convert.ToDateTime(reader["LastAciveTime"]),
                            IsActive = Convert.ToBoolean(reader["IsActive"])
                        };

                        users.Add(user);
                    }

                    return users;
                }
            }
        }

        public async Task<User> GetAsync(Expression<Func<User, bool>> filter)
        {
            // Filtre uygulanması gereken özel sorgu yazımı yapılmalıdır.
            throw new NotImplementedException();
        }

        public async Task AddAsync(User user)
        {
            _dbContext.OpenConnectionIfClosed();

            using (var sqlCommand = new SqlCommand("Insert into Users (UserRoleId, Username, PasswordHash, AccountCreatedTime, LastActiveTime, IsActive) values (@userRoleId, @username, @passwordHash, @accountCreatedTime, @lastActiveTime, @isActive)", _dbContext.GetConnection()))
            {
                sqlCommand.Parameters.AddWithValue("@userRoleId", user.UserRoleId);
                sqlCommand.Parameters.AddWithValue("@username", user.Username.ToLower());
                sqlCommand.Parameters.AddWithValue("@passwordHash", _passwordHasher.HashPassword(user.PasswordHash));
                sqlCommand.Parameters.AddWithValue("@accountCreatedTime", user.AccountCreatedTime);
                sqlCommand.Parameters.AddWithValue("@lastActiveTime", user.LastAciveTime);
                sqlCommand.Parameters.AddWithValue("@isActive", user.IsActive);

                await sqlCommand.ExecuteNonQueryAsync();
            }
        }

        public async Task UpdateAsync(User user)
        {
            // Güncelleme işlemi yapılmalıdır.
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(User user)
        {
            // Silme işlemi yapılmalıdır.
            throw new NotImplementedException();
        }

        public async Task<bool> IsUserExistAsync(string username)
        {
            _dbContext.OpenConnectionIfClosed();

            using (var sqlCommand = new SqlCommand("Select Count(*) from Users where Username = @username", _dbContext.GetConnection()))
            {
                sqlCommand.Parameters.AddWithValue("@username", username);

                var count = (int)await sqlCommand.ExecuteScalarAsync();
                return count > 0;
            }
        }

        public async Task<bool> VerifyPasswordAsync(string password, string passwordHash)
        {
            return await Task.FromResult(_passwordHasher.VerifyPassword(password, passwordHash));
        }

        public async Task<string> GetPasswordHashByUsernameAsync(string username)
        {
            _dbContext.OpenConnectionIfClosed();

            using (var sqlCommand = new SqlCommand("Select PasswordHash from Users where Username = @username", _dbContext.GetConnection()))
            {
                sqlCommand.Parameters.AddWithValue("@username", username);

                using (var dataReader = await sqlCommand.ExecuteReaderAsync())
                {
                    if (await dataReader.ReadAsync())
                    {
                        return dataReader["PasswordHash"].ToString();
                    }
                }
            }

            return "null";
        }

        public async Task UpdateLastActiveTimeAsync(string username)
        {
            _dbContext.OpenConnectionIfClosed();

            using (var sqlCommand = new SqlCommand("Update Users Set LastActiveTime = @dateTimeNow Where Username = @username", _dbContext.GetConnection()))
            {
                sqlCommand.Parameters.AddWithValue("@dateTimeNow", DateTime.Now);
                sqlCommand.Parameters.AddWithValue("@username", username);

                await sqlCommand.ExecuteNonQueryAsync();
            }
        }
    }
}
