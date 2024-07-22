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
    public class EfPhoneNumberDetailDal:IPhoneNumberDetailDal
    {
        public List<PhoneNumberDetail> GetAll(Expression<Func<PhoneNumberDetail, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public PhoneNumberDetail Get(Expression<Func<PhoneNumberDetail, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Add(PhoneNumberDetail entity)
        {
            throw new NotImplementedException();
        }

        public void Update(PhoneNumberDetail entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(PhoneNumberDetail entity)
        {
            throw new NotImplementedException();
        }
    }
}
