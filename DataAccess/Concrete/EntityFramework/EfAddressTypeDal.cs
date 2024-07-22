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
    public class EfAddressTypeDal:IAddressTypeDal
    {
        public List<AddressType> GetAll(Expression<Func<AddressType, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public AddressType Get(Expression<Func<AddressType, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Add(AddressType entity)
        {
            throw new NotImplementedException();
        }

        public void Update(AddressType entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(AddressType entity)
        {
            throw new NotImplementedException();
        }
    }
}
