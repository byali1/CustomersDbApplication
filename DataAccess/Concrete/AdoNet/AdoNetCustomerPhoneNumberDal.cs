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
        public List<CustomerPhoneNumber> GetAll(Expression<Func<CustomerPhoneNumber, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public CustomerPhoneNumber Get(Expression<Func<CustomerPhoneNumber, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Add(CustomerPhoneNumber entity)
        {
            throw new NotImplementedException();
        }

        public void Update(CustomerPhoneNumber entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(CustomerPhoneNumber entity)
        {
            throw new NotImplementedException();
        }
    }
}
