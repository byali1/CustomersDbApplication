using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.AdoNet
{
    public class AdoNetAddressDetailDal :IAddressDetailDal
    {
        public Task<List<AddressDetail>> GetAllAsync(Expression<Func<AddressDetail, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<AddressDetail> GetAsync(Expression<Func<AddressDetail, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(AddressDetail entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(AddressDetail entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(AddressDetail entity)
        {
            throw new NotImplementedException();
        }
    }
}
