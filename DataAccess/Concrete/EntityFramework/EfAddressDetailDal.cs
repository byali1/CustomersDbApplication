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
    public class EfAddressDetailDal:IAddressDetailDal
    {
        public List<AddressDetail> GetAll(Expression<Func<AddressDetail, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public AddressDetail Get(Expression<Func<AddressDetail, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Add(AddressDetail entity)
        {
            throw new NotImplementedException();
        }

        public void Update(AddressDetail entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(AddressDetail entity)
        {
            throw new NotImplementedException();
        }
    }
}
