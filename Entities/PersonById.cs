using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class PersonById
    {
        public int PersonId { get; set; }
        public int CustomerId { get; set; }
        public int PersonIdentityTypeId { get; set; }
        public int PersonOccupationId { get; set; }
        public int PersonGenderId { get; set; }
        public int CustomerAddressId { get; set; }
        public int AddressTypeId { get; set; }
        public int CityId { get; set; }
        public int DistrictId { get; set; }
        public int AddressDetailId { get; set; }
        public int CustomerEmailDetailId { get; set; }
        public int CustomerEmailId { get; set; }
        public int CustomerPhoneNumberId { get; set; }
        public int PhoneNumberDetailId { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set; }
    }
}
