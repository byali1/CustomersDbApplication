using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;


namespace Entities.Concrete
{
    public class CustomerPhoneNumber :IEntity
    {
        public int CustomerPhoneNumberId { get; set; }
        public int PhoneNumberDetailId { get; set; }
        public int CustomerId { get; set; }
        public bool IsPrimary { get; set; }
    }
}
