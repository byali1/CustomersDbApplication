using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICountryDal
    {
        List<Country> GetAll();
        void Add(Country country);
        void Update(Country country);
        void Delete(Country country);
    }
}
