using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class CompanySectorManager:ICompanySectorService
    {
        private readonly ICompanySectorDal _companySectorDal;

        public CompanySectorManager(ICompanySectorDal companySectorDal)
        {
            _companySectorDal = companySectorDal;
        }

        public async Task<List<CompanySector>> GetAllAsync()
        {
            return await _companySectorDal.GetAllAsync();
        }

        public async Task AddAsync(CompanySector companySector)
        {
            await _companySectorDal.AddAsync(companySector);
        }

        public async Task UpdateAsync(CompanySector companySector)
        {
            await _companySectorDal.UpdateAsync(companySector);
        }

        public async Task DeleteAsync(CompanySector companySector)
        {
            await _companySectorDal.DeleteAsync(companySector);
        }
    }
}
