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
    public class EfCountryDal:ICountryDal
    {
        public List<Country> GetAll(Expression<Func<Country, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Country Get(Expression<Func<Country, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Add(Country entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Country entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Country entity)
        {
            throw new NotImplementedException();
        }
    }
}
