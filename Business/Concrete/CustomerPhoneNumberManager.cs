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
        private readonly ICustomerPhoneNumberDal _customerPhoneNumberDal;

        public CustomerPhoneNumberManager(ICustomerPhoneNumberDal customerPhoneNumberDal)
        {
            _customerPhoneNumberDal = customerPhoneNumberDal;
        }

        public async Task<List<CustomerPhoneNumber>> GetAllAsync()
        {
            return await _customerPhoneNumberDal.GetAllAsync();
        }

        public async Task AddAsync(CustomerPhoneNumber customerPhoneNumber)
        {
            await _customerPhoneNumberDal.AddAsync(customerPhoneNumber);
        }

        public async Task UpdateAsync(CustomerPhoneNumber customerPhoneNumber)
        {
            await _customerPhoneNumberDal.UpdateAsync(customerPhoneNumber);
        }

        public async Task DeleteAsync(CustomerPhoneNumber customerPhoneNumber)
        {
            await _customerPhoneNumberDal.DeleteAsync(customerPhoneNumber);
        }
    }
}