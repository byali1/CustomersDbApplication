﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;


namespace Entities.Concrete
{
    public class PersonIdentityType:IEntity
    {
        public int PersonIdentityTypeId { get; set; }
        public string IdentityTypeDescription { get; set; }
    }
}
