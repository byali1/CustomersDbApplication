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
        private readonly ICustomerEmailDal _customerEmailDal;

        public CustomerEmailManager(ICustomerEmailDal customerEmailDal)
        {
            _customerEmailDal = customerEmailDal;
        }

        public async Task<List<CustomerEmail>> GetAllAsync()
        {
            return await _customerEmailDal.GetAllAsync();
        }

        public async Task AddAsync(CustomerEmail customerEmail)
        {
            await _customerEmailDal.AddAsync(customerEmail);
        }

        public async Task UpdateAsync(CustomerEmail customerEmail)
        {
            await _customerEmailDal.UpdateAsync(customerEmail);
        }

        public async Task DeleteAsync(CustomerEmail customerEmail)
        {
            await _customerEmailDal.DeleteAsync(customerEmail);
        }
    }
}
