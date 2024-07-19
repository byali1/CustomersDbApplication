using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.AdoNet
{
    public class AdoNetCountryDal : ICountryDal
    {
        public List<Country> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Add(Country country)
        {
            throw new NotImplementedException();
        }

        public void Update(Country country)
        {
            throw new NotImplementedException();
        }

        public void Delete(Country country)
        {
            throw new NotImplementedException();
        }
    }
}
