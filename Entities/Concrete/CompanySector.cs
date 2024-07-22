using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;


namespace Entities.Concrete
{
    public class CompanySector:IEntity
    {
        [Key]
        public int CompanySectorTypeId { get; set; }
        public string CompanySectorType { get; set; }
    }
}
