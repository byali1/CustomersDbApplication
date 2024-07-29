using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.DTOs;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IPersonService
    {
        List<Person> GetAll();
        Person Get(Person person);
        void Add(Person person);
        void Update(Person person);
        void Delete(Person person);

        List<PersonDetailDto> GetPersonDetails();
        List<PersonDetailDto> GetPersonDetailsByFilter(string name = null, string lastName = null, string email = null,
            string identityNumber = null, string city = null, string district = null,
            string phoneNumber = null, string birthPlace = null, string occupation = null);
        List<PersonDetailDto> GetPersonDetailsByName(string fullName);

    }
}
