using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class Company : IEntity
    {
        public int CompanyId { get; set; }
        public int CustomerId { get; set; }
        public int CompanySectorTypeId { get; set; }
        public int AuthorizedPersonId { get; set; }
        public string TaxNumber { get; set; }
        public DateTime EstablishedDate { get; set; }
        public int EmployeeCount { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set; }
    }
}
