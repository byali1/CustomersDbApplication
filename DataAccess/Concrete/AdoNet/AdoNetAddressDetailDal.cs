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
        public List<AddressDetail> GetAll(Expression<Func<AddressDetail, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public AddressDetail Get(Expression<Func<AddressDetail, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Add(AddressDetail addressDetail)
        {
            throw new NotImplementedException();
        }

        public void Update(AddressDetail addressDetail)
        {
            throw new NotImplementedException();
        }

        public void Delete(AddressDetail addressDetail)
        {
            throw new NotImplementedException();
        }
    }
}
