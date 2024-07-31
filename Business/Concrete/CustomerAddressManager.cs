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
        private readonly ICustomerAddressDal _customerAddressDal;

        public CustomerAddressManager(ICustomerAddressDal customerAddressDal)
        {
            _customerAddressDal = customerAddressDal;
        }

        public async Task<List<CustomerAddress>> GetAllAsync()
        {
            return await _customerAddressDal.GetAllAsync();
        }

        public async Task AddAsync(CustomerAddress customerAddress)
        {
            await _customerAddressDal.AddAsync(customerAddress);
        }

        public async Task UpdateAsync(CustomerAddress customerAddress)
        {
            await _customerAddressDal.UpdateAsync(customerAddress);
        }

        public async Task DeleteAsync(CustomerAddress customerAddress)
        {
            await _customerAddressDal.DeleteAsync(customerAddress);
        }
    }
}
