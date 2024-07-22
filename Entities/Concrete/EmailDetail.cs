using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class EmailDetail:IEntity
    {
        [Key]
        public int CustomerEmailDetailId { get; set; }
        public string Email { get; set; }
    }
}
