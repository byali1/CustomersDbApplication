﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Neighborhood:IEntity
    {
        public int NeighborhoodId { get; set; }
        public string NeighborhoodName { get; set; }
    }
}
