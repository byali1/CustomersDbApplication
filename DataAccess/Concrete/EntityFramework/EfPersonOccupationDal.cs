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
    public class EfPersonOccupationDal:IPersonOccupationDal
    {
        public List<PersonOccupation> GetAll(Expression<Func<PersonOccupation, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public PersonOccupation Get(Expression<Func<PersonOccupation, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Add(PersonOccupation entity)
        {
            throw new NotImplementedException();
        }

        public void Update(PersonOccupation entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(PersonOccupation entity)
        {
            throw new NotImplementedException();
        }
    }
}
