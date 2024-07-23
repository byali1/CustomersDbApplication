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
    public class CustomerAddressManager : ICustomerAddressService
    {
        private ICustomerAddressDal _customerAddressDal;

        public CustomerAddressManager(ICustomerAddressDal customerAddressDal)
        {
            _customerAddressDal = customerAddressDal;
        }
        public List<CustomerAddress> GetAll()
        {
            return _customerAddressDal.GetAll();
        }

        public void Add(CustomerAddress customerAddress)
        {
            _customerAddressDal.Add(customerAddress);
        }

        public void Update(CustomerAddress customerAddress)
        {
            _customerAddressDal.Update(customerAddress);
        }

        public void Delete(CustomerAddress customerAddress)
        {
            _customerAddressDal.Delete(customerAddress);
        }
    }
}
