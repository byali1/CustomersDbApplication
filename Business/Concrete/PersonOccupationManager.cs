using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;

namespace Business.Concrete
{
    public class PersonOccupationManager: IPersonOccupationService
    {
        private IPersonOccupationDal _personOccupationDal;

        public PersonOccupationManager(IPersonOccupationDal personOccupationDal)
        {
            _personOccupationDal = personOccupationDal;
        }
        public List<PersonOccupation> GetAll()
        {
           return _personOccupationDal.GetAll();
        }

        public void Add(PersonOccupation personOccupation)
        {
            _personOccupationDal.Add(personOccupation);
        }

        public void Update(PersonOccupation personOccupation)
        {
            _personOccupationDal.Update(personOccupation);
        }

        public void Delete(PersonOccupation personOccupation)
        {
            _personOccupationDal.Delete(personOccupation);
        }
    }
}
