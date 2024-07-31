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
    public class AdoNetCustomerAddressDal:ICustomerAddressDal
    {
        public Task<List<CustomerAddress>> GetAllAsync(Expression<Func<CustomerAddress, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<CustomerAddress> GetAsync(Expression<Func<CustomerAddress, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(CustomerAddress entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(CustomerAddress entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(CustomerAddress entity)
        {
            throw new NotImplementedException();
        }
    }
}
