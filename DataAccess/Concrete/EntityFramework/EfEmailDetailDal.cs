using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfEmailDetailDal:IEmailDetailDal
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
