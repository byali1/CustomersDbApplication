using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface INeighborhoodService
    {
        List<Neighborhood> GetAll();
        void Add(Neighborhood neighborhood);
        void Update(Neighborhood neighborhood);
        void Delete(Neighborhood neighborhood);
    }
}
