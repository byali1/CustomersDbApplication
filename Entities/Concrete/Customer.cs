﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class Customer : IEntity
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string? LastName { get; set; }
        public bool IsActiveCustomer { get; set; }
    }

}
