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
    public class PersonOccupationManager : IPersonOccupationService
    {
        private readonly IPersonOccupationDal _personOccupationDal;

        public PersonOccupationManager(IPersonOccupationDal personOccupationDal)
        {
            _personOccupationDal = personOccupationDal;
        }

        public async Task<List<PersonOccupation>> GetAllAsync()
        {
            return await _personOccupationDal.GetAllAsync();
        }

        public async Task AddAsync(PersonOccupation personOccupation)
        {
            await _personOccupationDal.AddAsync(personOccupation);
        }

        public async Task UpdateAsync(PersonOccupation personOccupation)
        {
            await _personOccupationDal.UpdateAsync(personOccupation);
        }

        public async Task DeleteAsync(PersonOccupation personOccupation)
        {
            await _personOccupationDal.DeleteAsync(personOccupation);
        }
    }
}
