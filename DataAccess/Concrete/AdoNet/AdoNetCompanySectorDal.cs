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
    public class AdoNetCompanySectorDal:ICompanySectorDal
    {
        public List<CompanySector> GetAll(Expression<Func<CompanySector, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public CompanySector Get(Expression<Func<CompanySector, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Add(CompanySector companySector)
        {
            throw new NotImplementedException();
        }

        public void Update(CompanySector companySector)
        {
            throw new NotImplementedException();
        }

        public void Delete(CompanySector companySector)
        {
            throw new NotImplementedException();
        }
    }
}
