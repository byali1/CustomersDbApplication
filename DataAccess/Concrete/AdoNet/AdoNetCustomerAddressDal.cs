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
        public List<CustomerAddress> GetAll(Expression<Func<CustomerAddress, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public CustomerAddress Get(Expression<Func<CustomerAddress, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Add(CustomerAddress entity)
        {
            throw new NotImplementedException();
        }

        public void Update(CustomerAddress entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(CustomerAddress entity)
        {
            throw new NotImplementedException();
        }
    }
}
