using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
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

       
        public List<User> GetAll()
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
    }
}
