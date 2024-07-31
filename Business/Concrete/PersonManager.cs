using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class PersonManager : IPersonService
    {
        private readonly IPersonDal _personDal;

        public PersonManager(IPersonDal personDal)
        {
            _personDal = personDal;
        }

        public async Task<List<Person>> GetAllAsync()
        {
            return await _personDal.GetAllAsync();
        }

        public async Task AddAsync(Person person)
        {
            await _personDal.AddAsync(person);
        }

        public async Task UpdateAsync(Person person)
        {
            await _personDal.UpdateAsync(person);
        }

        public async Task DeleteAsync(Person person)
        {
            await _personDal.DeleteAsync(person);
        }

        public async Task<PersonById> GetPersonIdValuesByIdAsync(int personId)
        {
            return await _personDal.GetPersonIdValuesByIdAsync(personId);
        }

        public async Task<List<PersonDetailDto>> GetPersonDetailsAsync()
        {
            return await _personDal.GetPersonDetailsAsync();
        }

        public async Task<List<PersonDetailDto>> GetPersonDetailsByFilterAsync(
            string name = null,
            string lastName = null,
            string email = null,
            string identityNumber = null,
            string city = null,
            string district = null,
            string phoneNumber = null,
            string birthPlace = null,
            string occupation = null)
        {
            return await _personDal.GetPersonDetailsByFilterAsync(name, lastName, email, identityNumber, city, district, phoneNumber, birthPlace, occupation);
        }

        public async Task<List<PersonDetailDto>> GetPersonDetailsByNameAsync(string fullName)
        {
            return await _personDal.GetPersonDetailsAsync(p => (p.Name + " " + p.LastName).Contains(fullName));
        }
    }
}
