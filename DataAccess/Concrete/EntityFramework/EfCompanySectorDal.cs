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
    public class EfCompanySectorDal:ICompanySectorDal
    {
        public List<CompanySector> GetAll(Expression<Func<CompanySector, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public CompanySector Get(Expression<Func<CompanySector, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Add(CompanySector entity)
        {
            throw new NotImplementedException();
        }

        public void Update(CompanySector entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(CompanySector entity)
        {
            throw new NotImplementedException();
        }
    }
}
