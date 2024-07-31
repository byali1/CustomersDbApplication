using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace DataAccess.Concrete.AdoNet
{
    public class AdoNetEmailDetailDal: IEmailDetailDal
    {
        public Task<List<EmailDetail>> GetAllAsync(Expression<Func<EmailDetail, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<EmailDetail> GetAsync(Expression<Func<EmailDetail, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(EmailDetail entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(EmailDetail entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(EmailDetail entity)
        {
            throw new NotImplementedException();
        }
    }
}
