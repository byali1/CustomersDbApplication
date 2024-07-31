using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPhoneNumberDetailService
    {
        Task<List<PhoneNumberDetail>> GetAllAsync();
        Task AddAsync(PhoneNumberDetail phoneNumberDetail);
        Task UpdateAsync(PhoneNumberDetail phoneNumberDetail);
        Task DeleteAsync(PhoneNumberDetail phoneNumberDetail);
    }
}
