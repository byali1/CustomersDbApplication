using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class PersonIdentityTypeManager : IPersonIdentityTypeService
    {
        private IPersonIdentityTypeDal _personIdentityTypeDal;

        public PersonIdentityTypeManager(IPersonIdentityTypeDal personIdentityTypeDal)
        {
            _personIdentityTypeDal = personIdentityTypeDal;
        }
        public List<PersonIdentityType> GetAll()
        {
            return _personIdentityTypeDal.GetAll();
        }

        public void Add(PersonIdentityType personIdentityType)
        {
            _personIdentityTypeDal.Add(personIdentityType);
        }

        public void Update(PersonIdentityType personIdentityType)
        {
            _personIdentityTypeDal.Update(personIdentityType);
        }

        public void Delete(PersonIdentityType personIdentityType)
        {
            _personIdentityTypeDal.Delete(personIdentityType);
        }
    }
}
