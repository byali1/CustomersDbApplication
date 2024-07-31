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
    public class AddressDetailManager : IAddressDetailService
    {
        private readonly IAddressDetailDal _addressDetailDal;

        public AddressDetailManager(IAddressDetailDal addressDetailDal)
        {
            _addressDetailDal = addressDetailDal;
        }

        public async Task<List<AddressDetail>> GetAllAsync()
        {
            return await _addressDetailDal.GetAllAsync();
        }

        public async Task AddAsync(AddressDetail addressDetail)
        {
            await _addressDetailDal.AddAsync(addressDetail);
        }

        public async Task UpdateAsync(AddressDetail addressDetail)
        {
            await _addressDetailDal.UpdateAsync(addressDetail);
        }

        public async Task DeleteAsync(AddressDetail addressDetail)
        {
            await _addressDetailDal.DeleteAsync(addressDetail);
        }
    }
}
