using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        Task<List<Customer>> GetAllAsync();
        Task<List<Customer>> GetActiveCustomersAsync();
        Task<List<Customer>> GetInActiveCustomersAsync();
        Task<List<Customer>> GetAllByNameAsync(string fullName);
        Task<List<Customer>> GetAllByNameForActiveAsync(string fullName);
        Task<List<Customer>> GetAllByNameForInActiveAsync(string fullName);
        Task AddAsync(Customer customer);
        Task UpdateAsync(Customer customer);
        Task DeleteAsync(Customer customer);
    }
}
