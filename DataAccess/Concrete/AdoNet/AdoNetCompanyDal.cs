using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.AdoNet
{
    public class AdoNetCompanyDal: ICompanyDal
    {
        public List<Company> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Add(Company company)
        {
            throw new NotImplementedException();
        }

        public void Update(Company company)
        {
            throw new NotImplementedException();
        }

        public void Delete(Company company)
        {
            throw new NotImplementedException();
        }
    }
}
