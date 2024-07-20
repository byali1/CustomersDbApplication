using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPersonGenderService
    {
        List<PersonGender> GetAll();
        void Add(PersonGender personGender);
        void Update(PersonGender personGender);
        void Delete(PersonGender personGender);
    }
}
