using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess;
using Entities.DTOs;
using Core.Entities;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
    public interface IPersonDal: IEntityRepository<Person>
    {
        List<PersonDetailDto> GetPersonDetails(Expression<Func<PersonDetailDto, bool>> filter = null);
    }
}
