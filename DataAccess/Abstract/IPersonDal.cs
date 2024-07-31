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
using Entities;

namespace DataAccess.Abstract
{
    public interface IPersonDal : IEntityRepository<Person>
    {
        Task<List<PersonDetailDto>> GetPersonDetailsAsync(Expression<Func<PersonDetailDto, bool>> filter = null);
        Task<PersonById> GetPersonIdValuesByIdAsync(int personId);
        Task<List<PersonDetailDto>> GetPersonDetailsByFilterAsync(
            string name = null,
            string lastName = null,
            string email = null,
            string identityNumber = null,
            string city = null,
            string district = null,
            string phoneNumber = null,
            string birthPlace = null,
            string occupation = null);
    }
}