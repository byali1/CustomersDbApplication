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
        List<PersonIdentityType> GetAll();
        void Add(PersonIdentityType personIdentityType);
        void Update(PersonIdentityType personIdentityType);
        void Delete(PersonIdentityType personIdentityType);
    }
}
