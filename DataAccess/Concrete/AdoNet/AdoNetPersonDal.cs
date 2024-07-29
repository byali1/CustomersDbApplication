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
    public class AdoNetPersonDal:IPersonDal
    {
        private IDbContext _dbContext;

        public AdoNetPersonDal(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        

        public List<Person> GetAll(Expression<Func<Person, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Person Get(Expression<Func<Person, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Add(Person person)
        {
            _dbContext.OpenConnectionIfClosed();

            SqlCommand sqlCommand = new SqlCommand("Insert into Persons values(@CustomerId, @PersonIdentityTypeId, @PersonOccupationId, @PersonGenderId, @IdentityNumber, @BirthDate, @BirthPlace, @CreatedTime, @UpdatedTime)", _dbContext.GetConnection());

            sqlCommand.Parameters.AddWithValue("@CustomerId", person.CustomerId);
            sqlCommand.Parameters.AddWithValue("@PersonIdentityTypeId", person.PersonIdentityTypeId);
            sqlCommand.Parameters.AddWithValue("@PersonOccupationId", person.PersonOccupationId);
            sqlCommand.Parameters.AddWithValue("@PersonGenderId", person.PersonGenderId);
            sqlCommand.Parameters.AddWithValue("@IdentityNumber", person.IdentityNumber);
            sqlCommand.Parameters.AddWithValue("@BirthDate", person.BirthDate);
            sqlCommand.Parameters.AddWithValue("@BirthPlace", person.BirthPlace);
            sqlCommand.Parameters.AddWithValue("@CreatedTime", person.CreatedTime);
            sqlCommand.Parameters.AddWithValue("@UpdatedTime", person.UpdatedTime);

            sqlCommand.ExecuteNonQuery();


            _dbContext.OpenConnectionIfClosed();

        }

        public void Update(Person person)
        {
            throw new NotImplementedException();
        }

        public void Delete(Person person)
        {
            throw new NotImplementedException();
        }

        public List<PersonDetailDto> GetPersonDetails(Expression<Func<PersonDetailDto, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public PersonById GetPersonIdValuesById(int personId)
        {
            throw new NotImplementedException();
        }

        public List<PersonDetailDto> GetPersonDetailsByFilter(string name = null, string lastName = null, string email = null,
            string identityNumber = null, string city = null, string district = null, string phoneNumber = null,
            string birthPlace = null, string occupation = null)
        {
            throw new NotImplementedException();
        }

        public List<PersonDetailDto> GetPersonDetails()
        {
            throw new NotImplementedException();
        }
    }
}
