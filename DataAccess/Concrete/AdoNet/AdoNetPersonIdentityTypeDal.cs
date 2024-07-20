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
    public class AdoNetPersonIdentityTypeDal:IPersonIdentityTypeDal
    {
        public List<PersonIdentityType> GetAll(Expression<Func<PersonIdentityType, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public PersonIdentityType Get(Expression<Func<PersonIdentityType, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Add(PersonIdentityType entity)
        {
            throw new NotImplementedException();
        }

        public void Update(PersonIdentityType entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(PersonIdentityType entity)
        {
            throw new NotImplementedException();
        }
    }
}
