using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class PhoneNumberDetail:IEntity
    {
        public int PhoneNumberDetailId { get; set; }
        public string PhoneNumber { get; set; }
    }
}
