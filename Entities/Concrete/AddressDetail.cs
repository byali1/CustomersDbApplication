using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class AddressDetail : IEntity
    {
        public int  AddressDetailId { get; set; }
        public int  CustomerAddressId { get; set; }
        public int  CountryId { get; set; }
        public int  CityId { get; set; }
        public int  DistrictId { get; set; }
        public string AddressDetailDescription { get; set; }
    }
}
