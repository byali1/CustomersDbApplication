using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerEmailDal:ICustomerEmailDal
    {
        public List<CustomerEmail> GetAll(Expression<Func<CustomerEmail, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public CustomerEmail Get(Expression<Func<CustomerEmail, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Add(CustomerEmail entity)
        {
            throw new NotImplementedException();
        }

        public void Update(CustomerEmail entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(CustomerEmail entity)
        {
            throw new NotImplementedException();
        }
    }
}
