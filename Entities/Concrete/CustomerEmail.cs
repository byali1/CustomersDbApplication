using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;


namespace Entities.Concrete
{
    public class CustomerEmail:IEntity
    {
        public int CustomerEmailId { get; set; }
        public int CustomerEmailDetailId { get; set; }
        public int CustomerId { get; set; }
        public bool IsPrimary { get; set; }
    }
}
