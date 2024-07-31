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
    public class AdoNetCustomerPhoneNumberDal:ICustomerPhoneNumberDal
    {
        public Task<List<CustomerPhoneNumber>> GetAllAsync(Expression<Func<CustomerPhoneNumber, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<CustomerPhoneNumber> GetAsync(Expression<Func<CustomerPhoneNumber, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(CustomerPhoneNumber entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(CustomerPhoneNumber entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(CustomerPhoneNumber entity)
        {
            throw new NotImplementedException();
        }
    }
}
