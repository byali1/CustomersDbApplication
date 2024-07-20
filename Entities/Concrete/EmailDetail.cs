using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class EmailDetail:IEntity
    {
        public int CustomerEmailDetailId { get; set; }
        public string Email { get; set; }
    }
}
