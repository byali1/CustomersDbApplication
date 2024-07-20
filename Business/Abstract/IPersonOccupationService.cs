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
        List<PersonOccupation> GetAll();
        void Add(PersonOccupation personOccupation);
        void Update(PersonOccupation personOccupation);
        void Delete(PersonOccupation personOccupation);
    }
}
