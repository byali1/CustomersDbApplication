using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess;
using Entities.DTOs;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
    public interface ICompanyDal:IEntityRepository<Company>
    {


        Task<List<CompanyDetailDto>> GetCompanyDetailsAsync(Expression<Func<CompanyDetailDto, bool>> filter = null);
    }
}
