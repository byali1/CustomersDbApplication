using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICustomerPhoneNumberService
    {
        Task<List<CustomerPhoneNumber>> GetAllAsync();
        Task AddAsync(CustomerPhoneNumber customerPhoneNumber);
        Task UpdateAsync(CustomerPhoneNumber customerPhoneNumber);
        Task DeleteAsync(CustomerPhoneNumber customerPhoneNumber);
    }
}
