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
        void Add(Person person);
        void Update(Person person);
        void Delete(Person person);

        List<PersonDetailDto> GetPersonDetails();
        List<PersonDetailDto> GetPersonDetailsByName(string fullName);

    }
}
