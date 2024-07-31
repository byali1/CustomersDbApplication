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
    public class PhoneNumberDetailManager : IPhoneNumberDetailService
    {
        private readonly IPhoneNumberDetailDal _phoneNumberDetailDal;

        public PhoneNumberDetailManager(IPhoneNumberDetailDal phoneNumberDetailDal)
        {
            _phoneNumberDetailDal = phoneNumberDetailDal;
        }

        public async Task<List<PhoneNumberDetail>> GetAllAsync()
        {
            return await _phoneNumberDetailDal.GetAllAsync();
        }

        public async Task AddAsync(PhoneNumberDetail phoneNumberDetail)
        {
            await _phoneNumberDetailDal.AddAsync(phoneNumberDetail);
        }

        public async Task UpdateAsync(PhoneNumberDetail phoneNumberDetail)
        {
            await _phoneNumberDetailDal.UpdateAsync(phoneNumberDetail);
        }

        public async Task DeleteAsync(PhoneNumberDetail phoneNumberDetail)
        {
            await _phoneNumberDetailDal.DeleteAsync(phoneNumberDetail);
        }
    }
}
