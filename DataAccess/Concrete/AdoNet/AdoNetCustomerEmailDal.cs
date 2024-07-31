using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.AdoNet
{
    public class AdoNetCustomerEmailDal : ICustomerEmailDal
    {
        public Task<List<CustomerEmail>> GetAllAsync(Expression<Func<CustomerEmail, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<CustomerEmail> GetAsync(Expression<Func<CustomerEmail, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(CustomerEmail entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(CustomerEmail entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(CustomerEmail entity)
        {
            throw new NotImplementedException();
        }
    }
}
