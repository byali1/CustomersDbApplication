using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class CustomerAddress : IEntity
    {
        public int CustomerAddressId { get; set; }
        public int CustomerId { get; set; }
        public int AddressTypeId { get; set; }
        public string AddressName { get; set; }
        public bool IsBillingAddress { get; set; }
    }
}
