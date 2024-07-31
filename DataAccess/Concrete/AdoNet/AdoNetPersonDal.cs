using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.AdoNet
{
    public class AdoNetPersonDal : IPersonDal
    {
        private readonly IDbContext _dbContext;

        public AdoNetPersonDal(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Person>> GetAllAsync(Expression<Func<Person, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public async Task<Person> GetAsync(Expression<Func<Person, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public async Task AddAsync(Person person)
        {
            _dbContext.OpenConnectionIfClosed();

            using (var sqlCommand = new SqlCommand("INSERT INTO Persons (CustomerId, PersonIdentityTypeId, PersonOccupationId, PersonGenderId, IdentityNumber, BirthDate, BirthPlace, CreatedTime, UpdatedTime) VALUES (@CustomerId, @PersonIdentityTypeId, @PersonOccupationId, @PersonGenderId, @IdentityNumber, @BirthDate, @BirthPlace, @CreatedTime, @UpdatedTime)", _dbContext.GetConnection()))
            {
                sqlCommand.Parameters.AddWithValue("@CustomerId", person.CustomerId);
                sqlCommand.Parameters.AddWithValue("@PersonIdentityTypeId", person.PersonIdentityTypeId);
                sqlCommand.Parameters.AddWithValue("@PersonOccupationId", person.PersonOccupationId);
                sqlCommand.Parameters.AddWithValue("@PersonGenderId", person.PersonGenderId);
                sqlCommand.Parameters.AddWithValue("@IdentityNumber", person.IdentityNumber);
                sqlCommand.Parameters.AddWithValue("@BirthDate", person.BirthDate);
                sqlCommand.Parameters.AddWithValue("@BirthPlace", person.BirthPlace);
                sqlCommand.Parameters.AddWithValue("@CreatedTime", person.CreatedTime);
                sqlCommand.Parameters.AddWithValue("@UpdatedTime", person.UpdatedTime);

                await sqlCommand.ExecuteNonQueryAsync();
            }

            _dbContext.CloseConnectionIfOpen();
        }

        public async Task UpdateAsync(Person person)
        {
            // Implementation required
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(Person person)
        {
            // Implementation required
            throw new NotImplementedException();
        }

        public async Task<List<PersonDetailDto>> GetPersonDetailsAsync(Expression<Func<PersonDetailDto, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public async Task<PersonById> GetPersonIdValuesByIdAsync(int personId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<PersonDetailDto>> GetPersonDetailsByFilterAsync(string name = null, string lastName = null, string email = null,
            string identityNumber = null, string city = null, string district = null, string phoneNumber = null,
            string birthPlace = null, string occupation = null)
        {
            throw new NotImplementedException();
        }

        public async Task<List<PersonDetailDto>> GetPersonDetailsAsync()
        {
            throw new NotImplementedException();
        }
    }
}