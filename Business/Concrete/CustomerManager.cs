using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using DataAccess.Abstract;
using Core.DataAccess;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly IEntityRepository<Customer> _customerDal;

        public CustomerManager(IEntityRepository<Customer> customerDal)
        {
            _customerDal = customerDal;
        }

        public async Task<List<Customer>> GetAllAsync()
        {
            return await _customerDal.GetAllAsync();
        }

        public async Task<List<Customer>> GetActiveCustomersAsync()
        {
            return await _customerDal.GetAllAsync(c => c.IsActiveCustomer == true);

        }

        public async Task<List<Customer>> GetInActiveCustomersAsync()
        {
            return await _customerDal.GetAllAsync(c => c.IsActiveCustomer == false);
        }


        public async Task<List<Customer>> GetAllByNameAsync(string fullName)
        {
            return await _customerDal.GetAllAsync(c => (c.Name + " " + c.LastName).Contains(fullName));
        }

        public async Task<List<Customer>> GetAllByNameForActiveAsync(string fullName)
        {
            return await _customerDal.GetAllAsync(c => (c.Name + " " + c.LastName).Contains(fullName) && c.IsActiveCustomer == true);
        }

        public async Task<List<Customer>> GetAllByNameForInActiveAsync(string fullName)
        {
            return await _customerDal.GetAllAsync(c => (c.Name + " " + c.LastName).Contains(fullName) && c.IsActiveCustomer == false);
        }

        public async Task AddAsync(Customer customer)
        {
            await _customerDal.AddAsync(customer);
        }

        public async Task UpdateAsync(Customer customer)
        {
            await _customerDal.UpdateAsync(customer);
        }

        public async Task DeleteAsync(Customer customer)
        {
            await _customerDal.DeleteAsync(customer);
        }
    }
}
