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
        private IDbContext _dbContext;
        private IPasswordHasher _passwordHasher;

        public AdoNetUserDal(IDbContext dbContext, IPasswordHasher passwordHasher)
        {
            _dbContext = dbContext;
            _passwordHasher = passwordHasher;
        }


        
        public List<User> GetAll(Expression<Func<User, bool>> filter = null)
        {
            _dbContext.OpenConnectionIfClosed();

            SqlCommand sqlCommand = new SqlCommand("Select * from Users", _dbContext.GetConnection());

            SqlDataReader reader = sqlCommand.ExecuteReader();

            List<User> users = new List<User>();

            while (reader.Read())
            {
                User user = new User
                {
                    UserId = Convert.ToInt32(reader["UserId"]),
                    UserRoleId = Convert.ToInt32(reader["UserRoleId"]),
                    Username = reader["Username"].ToString(),
                    PasswordHash = reader["PasswordHash"].ToString(),
                    AccountCreatedTime = Convert.ToDateTime(reader["AccountCreatedTime"]),
                    LastAciveTime = Convert.ToDateTime(reader["LastAciveTime"]),
                    IsActive = Convert.ToBoolean(reader["LastAciveTime"])

                };


                users.Add(user);
            }

            reader.Close();

            _dbContext.CloseConnectionIfOpen();
            return users;
        }

        public User Get(Expression<Func<User, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Add(User user)
        {
            _dbContext.OpenConnectionIfClosed();

            SqlCommand sqlCommand = new SqlCommand("Insert into Users values(@userRoleId, @username, @passwordHash, @accountCreatedTime, @lastActiveTime, @isActive)", _dbContext.GetConnection());


            sqlCommand.Parameters.AddWithValue("@userRoleId", user.UserRoleId);
            sqlCommand.Parameters.AddWithValue("@username", user.Username.ToLower());
            sqlCommand.Parameters.AddWithValue("@passwordHash", _passwordHasher.HashPassword(user.PasswordHash));
            sqlCommand.Parameters.AddWithValue("@accountCreatedTime", user.AccountCreatedTime);
            sqlCommand.Parameters.AddWithValue("@lastActiveTime", user.LastAciveTime);
            sqlCommand.Parameters.AddWithValue("@isActive", user.IsActive);

            sqlCommand.ExecuteNonQuery();

            _dbContext.CloseConnectionIfOpen();


        }

        public void Update(User user)
        {
            throw new NotImplementedException();
        }

        public void Delete(User user)
        {
            throw new NotImplementedException();
        }

        public bool IsUserExist(string username)
        {
            _dbContext.OpenConnectionIfClosed();

            SqlCommand sqlCommand = new SqlCommand("Select Count(*) from users where username = @username", _dbContext.GetConnection());

            sqlCommand.Parameters.AddWithValue("@username", username);

            int count = (int)sqlCommand.ExecuteScalar();
            _dbContext.CloseConnectionIfOpen();
            return count > 0;
        }



        public bool VerifyPassword(string password, string passwordHash)
        {
            return _passwordHasher.VerifyPassword(password, passwordHash);
        }

        public string GetPasswordHashByUsername(string username)
        {
            _dbContext.OpenConnectionIfClosed();

            SqlCommand sqlCommand = new SqlCommand("Select passwordHash from users where username= @username", _dbContext.GetConnection());

            sqlCommand.Parameters.AddWithValue("@username", username);

            SqlDataReader dataReader = sqlCommand.ExecuteReader();

            if (dataReader.Read())
            {
                string hash = dataReader["PasswordHash"].ToString();
                _dbContext.CloseConnectionIfOpen();
                return hash;
            }
            _dbContext.CloseConnectionIfOpen();
            return "null";
        }
    }
}
