using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAddressDetailService
    {
        Task<List<AddressDetail>> GetAllAsync();
        Task AddAsync(AddressDetail addressDetail);
        Task UpdateAsync(AddressDetail addressDetail);
        Task DeleteAsync(AddressDetail addressDetail);
    }
}
