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
    public class AdoNetPhoneNumberDetailDal:IPhoneNumberDetailDal
    {
        public Task<List<PhoneNumberDetail>> GetAllAsync(Expression<Func<PhoneNumberDetail, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<PhoneNumberDetail> GetAsync(Expression<Func<PhoneNumberDetail, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(PhoneNumberDetail entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(PhoneNumberDetail entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(PhoneNumberDetail entity)
        {
            throw new NotImplementedException();
        }
    }
}
