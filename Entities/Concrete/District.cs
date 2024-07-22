using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;


namespace Entities.Concrete
{
    public class District : IEntity
    {
        public int DistrictId { get; set; }
        public int CityId { get; set; }
        public string DistrictName { get; set; }
    }
}
