using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class PersonManager : IPersonService
    {
        private IPersonDal _personDal;

        public PersonManager(IPersonDal personDal)
        {
            _personDal = personDal;
        }

        public List<Person> GetAll()
        {
          return  _personDal.GetAll();
        }

        public void Add(Person person)
        {
            _personDal.Add(person);
        }

        public void Update(Person person)
        {
            _personDal.Update(person);
        }

        public void Delete(Person person)
        {
            _personDal.Delete(person);
        }

        public List<PersonDetailDto> GetPersonDetails()
        {
            return _personDal.GetPersonDetails();
        }

        public List<PersonDetailDto> GetPersonDetailsByName(string fullName)
        {
            return _personDal.GetPersonDetails(p => (p.Name + " " + p.LastName).Contains(fullName));
        }
    }
}
