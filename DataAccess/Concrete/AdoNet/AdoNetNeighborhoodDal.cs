using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;

namespace DataAccess.Concrete.AdoNet
{
    public class AdoNetNeighborhoodDal: INeighborhoodDal
    {
        public List<Neighborhood> GetAll(Expression<Func<Neighborhood, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Neighborhood Get(Expression<Func<Neighborhood, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Add(Neighborhood entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Neighborhood entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Neighborhood entity)
        {
            throw new NotImplementedException();
        }
    }
}
