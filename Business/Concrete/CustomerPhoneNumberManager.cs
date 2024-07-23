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
    public class CustomerPhoneNumberManager : ICustomerPhoneNumberService
    {
        private ICustomerPhoneNumberDal _customerPhoneNumberDal;

        public CustomerPhoneNumberManager(ICustomerPhoneNumberDal customerPhoneNumberDal)
        {
            _customerPhoneNumberDal = customerPhoneNumberDal;
        }
        public List<CustomerPhoneNumber> GetAll()
        {
            return _customerPhoneNumberDal.GetAll();
        }

        public void Add(CustomerPhoneNumber customerPhoneNumber)
        {
            _customerPhoneNumberDal.Add(customerPhoneNumber);
        }

        public void Update(CustomerPhoneNumber customerPhoneNumber)
        {
            _customerPhoneNumberDal.Update(customerPhoneNumber);
        }

        public void Delete(CustomerPhoneNumber customerPhoneNumber)
        {
            _customerPhoneNumberDal.Delete(customerPhoneNumber);
        }
    }
}
