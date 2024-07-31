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
    public class AdoNetAddressTypeDal:IAddressTypeDal
    {
        public Task<List<AddressType>> GetAllAsync(Expression<Func<AddressType, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<AddressType> GetAsync(Expression<Func<AddressType, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(AddressType entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(AddressType entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(AddressType entity)
        {
            throw new NotImplementedException();
        }
    }
}
