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
    public class EfPersonGenderDal:IPersonGenderDal
    {
        public List<PersonGender> GetAll(Expression<Func<PersonGender, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public PersonGender Get(Expression<Func<PersonGender, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Add(PersonGender entity)
        {
            throw new NotImplementedException();
        }

        public void Update(PersonGender entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(PersonGender entity)
        {
            throw new NotImplementedException();
        }
    }
}
