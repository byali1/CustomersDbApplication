﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;


namespace Entities.Concrete
{
    public class PersonOccupation:IEntity
    {
        public int PersonOccupationId { get; set; }
        public string OccupationName { get; set; }
    }
}
