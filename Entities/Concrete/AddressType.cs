using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class AddressType : IEntity
    {
        public int AddressTypeId { get; set; }
        public string AddressTypeDescription { get; set; }
    }
}
