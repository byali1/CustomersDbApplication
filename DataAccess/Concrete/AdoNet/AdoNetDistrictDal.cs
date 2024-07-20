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
    public class AdoNetDistrictDal:IDistrictDal
    {
        public List<District> GetAll(Expression<Func<District, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public District Get(Expression<Func<District, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Add(District entity)
        {
            throw new NotImplementedException();
        }

        public void Update(District entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(District entity)
        {
            throw new NotImplementedException();
        }
    }
}
