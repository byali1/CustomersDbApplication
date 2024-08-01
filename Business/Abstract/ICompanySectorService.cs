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
        Task<List<CompanySector>> GetAllAsync();
        Task AddAsync(CompanySector companySector);
        Task UpdateAsync(CompanySector companySector);
        Task DeleteAsync(CompanySector companySector);
    }
}
