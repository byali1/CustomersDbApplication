using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPersonIdentityTypeService
    {
        Task<List<PersonIdentityType>> GetAllAsync();
        Task AddAsync(PersonIdentityType personIdentityType);
        Task UpdateAsync(PersonIdentityType personIdentityType);
        Task DeleteAsync(PersonIdentityType personIdentityType);
    }
}
