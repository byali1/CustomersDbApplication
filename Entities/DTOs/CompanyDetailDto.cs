using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.DTOs
{
    public class CompanyDetailDto : IDto
    {
        public int CustomerId { get; set; }
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string TaxNumber { get; set; }
        public DateTime EstablishedDate { get; set; }
        public int EmployeeCount { get; set; }
        public string CompanySectorType { get; set; }
        public string AddressName { get; set; }
        public string AddressTypeDescription { get; set; }
        public string AddressDetailDescription { get; set; }
        public bool IsBillingAddress { get; set; }
        public string CityName { get; set; }
        public string DistrictName { get; set; }
        public string CountryName { get; set; }
        public string Email { get; set; }
        public bool IsPrimaryEmail { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsPrimaryPhone { get; set; }
        public bool IsActiveCustomer { get; set; }
        public DateTime CreatedTime { get; set; }



    }
}
