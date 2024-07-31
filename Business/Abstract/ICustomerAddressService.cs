using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICustomerAddressService
    {
        Task<List<CustomerAddress>> GetAllAsync();
        Task AddAsync(CustomerAddress customerAddress);
        Task UpdateAsync(CustomerAddress customerAddress);
        Task DeleteAsync(CustomerAddress customerAddress);
    }
}
