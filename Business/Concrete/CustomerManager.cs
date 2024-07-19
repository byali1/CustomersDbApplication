using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using DataAccess.Abstract;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public List<Customer> GetAll()
        {
            return _customerDal.GetAll();
        }

        public void Add(Customer customer)
        {
            throw new NotImplementedException();
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
