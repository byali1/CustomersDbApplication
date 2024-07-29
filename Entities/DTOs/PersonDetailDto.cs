using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.DTOs
{
    public class PersonDetailDto : IDto
    {
        public int CustomerId { get; set; }
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string IdentityNumber { get; set; }
        public string IdentityTypeDescription{ get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public string OccupationName { get; set; }
        public string AddressDetailDescription{ get; set; }
        public bool IsBillingAddress { get; set; }
        public string CountryName { get; set; }
        public string CityName { get; set; }
        public string DistrictName { get; set; }
        public string AddressTypeDescription { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsPrimaryPhone { get; set; }
        public string Email { get; set; }
        public bool IsPrimaryEmail { get; set; }
        public int PersonGenderId { get; set; }



    }
}
