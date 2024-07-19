using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Person :IEntity
    {
        public int PersonId { get; set; }
        public int CustomerId { get; set; }
        public int PersonIdentityTypeId { get; set; }
        public int PersonOccupationId { get; set; }
        public int PersonGenderId { get; set; }
        public string IdentityNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set; }

    }
}
