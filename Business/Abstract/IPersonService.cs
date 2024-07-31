using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.DTOs;
using System.Linq.Expressions;
using Entities;

namespace Business.Abstract
{
    public interface IPersonService
    {
        Task<List<Person>> GetAllAsync();
        Task AddAsync(Person person);
        Task UpdateAsync(Person person);
        Task DeleteAsync(Person person);

        Task<List<PersonDetailDto>> GetPersonDetailsAsync();
        Task<List<PersonDetailDto>> GetPersonDetailsByFilterAsync(
            string name = null,
            string lastName = null,
            string email = null,
            string identityNumber = null,
            string city = null,
            string district = null,
            string phoneNumber = null,
            string birthPlace = null,
            string occupation = null);
        Task<List<PersonDetailDto>> GetPersonDetailsByNameAsync(string fullName);

        Task<PersonById> GetPersonIdValuesByIdAsync(int personId);
    }
}
