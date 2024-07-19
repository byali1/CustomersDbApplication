using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using System.Data.SqlClient;

namespace DataAccess.Concrete.AdoNet
{
    public class AdoNetCustomerDal : ICustomerDal

    {
        private IDbContext _dbContext;

        public AdoNetCustomerDal(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public List<Customer> GetAll()
        {

            _dbContext.OpenConnectionIfClosed();

            SqlCommand sqlCommand = new SqlCommand("Select * from Customers", _dbContext.GetConnection());

            SqlDataReader reader = sqlCommand.ExecuteReader();

            List<Customer> customers = new List<Customer>();

            while (reader.Read())
            {
                Customer customer = new Customer
                {
                    CustomerId = Convert.ToInt32(reader["CustomerId"]),
                    Name = reader["Name"].ToString(),
                    LastName = reader["LastName"].ToString()
                };


                customers.Add(customer);
            }

            reader.Close();
            _dbContext.GetConnection().Close();
            return customers;
        }



        public void Add(Customer customer)
        {
            _dbContext.OpenConnectionIfClosed();

            SqlCommand sqlCommand = new SqlCommand("Insert into Customers values(@Name, @LastName)", _dbContext.GetConnection());

            sqlCommand.Parameters.AddWithValue("@Name", customer.Name);
            sqlCommand.Parameters.AddWithValue("@LastName", customer.LastName);
            sqlCommand.ExecuteNonQuery();


            _dbContext.CloseConnectionIfOpen();
        }

        public void Update(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
