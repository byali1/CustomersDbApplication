using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;


namespace Entities.Concrete
{
    public class UserRole : IEntity
    {
        public int UserRoleId { get; set; } 
        public string RoleName { get; set; } 
    }
}
