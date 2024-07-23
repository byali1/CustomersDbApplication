using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CustomerEmailManager : ICustomerEmailService
    {
        private ICustomerEmailDal _customerEmailDal;

        public CustomerEmailManager(ICustomerEmailDal customerEmailDal)
        {
            _customerEmailDal = customerEmailDal;
        }
        public List<CustomerEmail> GetAll()
        {
            return _customerEmailDal.GetAll();
        }

        public void Add(CustomerEmail customerEmail)
        {
            _customerEmailDal.Add(customerEmail);
        }

        public void Update(CustomerEmail customerEmail)
        {
            _customerEmailDal.Update(customerEmail);
        }

        public void Delete(CustomerEmail customerEmail)
        {
            _customerEmailDal.Delete(customerEmail);
        }
    }
}
