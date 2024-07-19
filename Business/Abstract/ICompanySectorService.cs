using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICompanySectorService
    {
        List<CompanySector> GetAll();
        void Add(CompanySector companySector);
        void Update(CompanySector companySector);
        void Delete(CompanySector companySector);
    }
}
