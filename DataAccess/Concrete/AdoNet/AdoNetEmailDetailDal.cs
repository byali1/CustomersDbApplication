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
        public List<EmailDetail> GetAll(Expression<Func<EmailDetail, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public EmailDetail Get(Expression<Func<EmailDetail, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Add(EmailDetail entity)
        {
            throw new NotImplementedException();
        }

        public void Update(EmailDetail entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(EmailDetail entity)
        {
            throw new NotImplementedException();
        }
    }
}
