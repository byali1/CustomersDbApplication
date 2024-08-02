using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class CompanyById
    {
        public int CompanyId { get; set; }
        public int CustomerId { get; set; }
        public int CompanySectorTypeId { get; set; }
        public int AuthorizedPersonId { get; set; }
        public int CustomerAddressId { get; set; }
        public int AddressTypeId { get; set; }
        public int AddressDetailId { get; set; }
        public int CityId { get; set; }
        public int DistrictId { get; set; }
        public int CountryId { get; set; }
        public int CustomerEmailDetailId { get; set; }
        public int CustomerEmailId { get; set; }
        public int CustomerPhoneNumberId { get; set; }
        public int PhoneNumberDetailId { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set; }
    }
}
