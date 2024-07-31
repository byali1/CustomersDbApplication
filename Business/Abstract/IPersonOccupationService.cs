using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPersonOccupationService
    {
        Task<List<PersonOccupation>> GetAllAsync();
        Task AddAsync(PersonOccupation personOccupation);
        Task UpdateAsync(PersonOccupation personOccupation);
        Task DeleteAsync(PersonOccupation personOccupation);
    }
}
