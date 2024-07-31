using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace DataAccess.Concrete.AdoNet
{
    public class AdoNetCustomerDal : ICustomerDal
    {
        private readonly IDbContext _dbContext;

        public AdoNetCustomerDal(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Customer>> GetAllAsync(Expression<Func<Customer, bool>> filter = null)
        {
            _dbContext.OpenConnectionIfClosed();

            var sqlCommand = new SqlCommand("SELECT * FROM Customers", _dbContext.GetConnection());

            using (var reader = await sqlCommand.ExecuteReaderAsync())
            {
                var customers = new List<Customer>();

                while (await reader.ReadAsync())
                {
                    var customer = new Customer
                    {
                        CustomerId = Convert.ToInt32(reader["CustomerId"]),
                        Name = reader["Name"].ToString(),
                        LastName = reader["LastName"].ToString()
                    };

                    customers.Add(customer);
                }

                return customers;
            }
        }

        public async Task<Customer> GetAsync(Expression<Func<Customer, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public async Task AddAsync(Customer customer)
        {
            _dbContext.OpenConnectionIfClosed();

            var sqlCommand = new SqlCommand("INSERT INTO Customers (Name, LastName) VALUES (@Name, @LastName)", _dbContext.GetConnection());

            sqlCommand.Parameters.AddWithValue("@Name", customer.Name);
            sqlCommand.Parameters.AddWithValue("@LastName", customer.LastName);

            await sqlCommand.ExecuteNonQueryAsync();

            _dbContext.CloseConnectionIfOpen();
        }

        public async Task UpdateAsync(Customer customer)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
