using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class AddressType : IEntity
    {
        public int AddressTypeId { get; set; }
        public string AddressTypeDescription { get; set; }
    }
}
