using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;


namespace Entities.Concrete
{
    public class User : IEntity
    {
        public int UserId { get; set; }
        public int UserRoleId { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public DateTime AccountCreatedTime { get; set; }
        public DateTime LastAciveTime { get; set; }
        public bool IsActive { get; set; }
    }
}
