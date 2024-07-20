using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class PersonGender : IEntity
    {
        public int PersonGenderId { get; set; }
        public string GenderName { get; set; }
    }
}
