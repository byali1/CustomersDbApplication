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
        private readonly IPersonIdentityTypeDal _personIdentityTypeDal;

        public PersonIdentityTypeManager(IPersonIdentityTypeDal personIdentityTypeDal)
        {
            _personIdentityTypeDal = personIdentityTypeDal;
        }

        public async Task<List<PersonIdentityType>> GetAllAsync()
        {
            return await _personIdentityTypeDal.GetAllAsync();
        }

        public async Task AddAsync(PersonIdentityType personIdentityType)
        {
            await _personIdentityTypeDal.AddAsync(personIdentityType);
        }

        public async Task UpdateAsync(PersonIdentityType personIdentityType)
        {
            await _personIdentityTypeDal.UpdateAsync(personIdentityType);
        }

        public async Task DeleteAsync(PersonIdentityType personIdentityType)
        {
            await _personIdentityTypeDal.DeleteAsync(personIdentityType);
        }
    }
}
