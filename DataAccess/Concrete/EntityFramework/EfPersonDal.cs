using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPersonDal : EfEntityRepositoryBase<Person, EfCustomersDbContext>, IPersonDal
    {


        public List<PersonDetailDto> GetPersonDetails(Expression<Func<PersonDetailDto, bool>> filter = null)
        {
            using (EfCustomersDbContext context = new EfCustomersDbContext())
            {
                var addressInfo = from ca in context.CustomerAddresses
                                  join ad in context.AddressDetails on ca.CustomerAddressId equals ad.CustomerAddressId
                                  join co in context.Countries on ad.CountryId equals co.CountryId
                                  join ci in context.Cities on ad.CityId equals ci.CityId
                                  join d in context.Districts on ad.DistrictId equals d.DistrictId
                                  join adt in context.AddressTypes on ca.AddressTypeId equals adt.AddressTypeId
                                  select new
                                  {
                                      ca.CustomerId,
                                      ad.AddressDetailDescription,
                                      ca.IsBillingAddress,
                                      co.CountryName,
                                      ci.CityName,
                                      d.DistrictName,
                                      adt.AddressTypeDescription
                                  };

                var phoneInfo = from cpn in context.CustomerPhoneNumbers
                                join pnd in context.PhoneNumberDetails on cpn.PhoneNumberDetailId equals pnd.PhoneNumberDetailId
                                select new
                                {
                                    cpn.CustomerId,
                                    pnd.PhoneNumber,
                                    cpn.IsPrimary
                                };

                var emailInfo = from ce in context.CustomerEmails
                                join ed in context.EmailDetails on ce.CustomerEmailDetailId equals ed.CustomerEmailDetailId
                                select new
                                {
                                    ce.CustomerId,
                                    ed.Email,
                                    ce.IsPrimary
                                };

                var query = from p in context.Persons
                            join c in context.Customers on p.CustomerId equals c.CustomerId
                            join pit in context.PersonIdentityTypes on p.PersonIdentityTypeId equals pit.PersonIdentityTypeId
                            join po in context.PersonOccupations on p.PersonOccupationId equals po.PersonOccupationId
                            join ai in addressInfo on c.CustomerId equals ai.CustomerId
                            join pi in phoneInfo on c.CustomerId equals pi.CustomerId
                            join ei in emailInfo on c.CustomerId equals ei.CustomerId
                            select new PersonDetailDto
                            {
                                CustomerId = c.CustomerId,
                                PersonId = p.PersonId,
                                Name = c.Name,
                                LastName = c.LastName,
                                IdentityNumber = p.IdentityNumber,
                                IdentityTypeDescription = pit.IdentityTypeDescription,
                                BirthDate = p.BirthDate,
                                BirthPlace = p.BirthPlace,
                                OccupationName = po.OccupationName,
                                AddressDetailDescription = ai.AddressDetailDescription,
                                IsBillingAddress = ai.IsBillingAddress,
                                CountryName = ai.CountryName,
                                CityName = ai.CityName,
                                DistrictName = ai.DistrictName,
                                AddressTypeDescription = ai.AddressTypeDescription,
                                PhoneNumber = pi.PhoneNumber,
                                IsPrimaryPhone = pi.IsPrimary,
                                Email = ei.Email,
                                IsPrimaryEmail = ei.IsPrimary,
                                PersonGenderId = p.PersonGenderId


                            };

                if (filter != null)
                {
                    query = query.Where(filter);
                }

                return query.ToList();
            }
        }

        public PersonById GetPersonIdValuesById(int personId)
        {
            using (EfCustomersDbContext context = new EfCustomersDbContext())
            {
                var query = from p in context.Persons
                            join ca in context.CustomerAddresses
                                on p.CustomerId equals ca.CustomerId
                            join ad in context.AddressDetails
                                on ca.CustomerAddressId equals ad.CustomerAddressId
                            join ce in context.CustomerEmails
                                on p.CustomerId equals ce.CustomerId
                            join ed in context.EmailDetails on ce.CustomerEmailDetailId equals ed.CustomerEmailDetailId
                            join cpn in context.CustomerPhoneNumbers on p.CustomerId equals cpn.CustomerId
                            join pnd in context.PhoneNumberDetails on cpn.PhoneNumberDetailId equals pnd.PhoneNumberDetailId
                            where p.PersonId == personId
                            select new PersonById
                            {
                                PersonId = p.PersonId,
                                CustomerId = p.CustomerId,
                                PersonIdentityTypeId = p.PersonIdentityTypeId,
                                PersonOccupationId = p.PersonOccupationId,
                                PersonGenderId = p.PersonGenderId,
                                CustomerAddressId = ca.CustomerAddressId,
                                AddressTypeId = ca.AddressTypeId,
                                CityId = ad.CityId,
                                DistrictId = ad.DistrictId,
                                AddressDetailId = ad.AddressDetailId,
                                CustomerEmailDetailId = ed.CustomerEmailDetailId,
                                CustomerEmailId = ce.CustomerEmailId,
                                CustomerPhoneNumberId = cpn.CustomerPhoneNumberId,
                                PhoneNumberDetailId = pnd.PhoneNumberDetailId,
                                CreatedTime = p.CreatedTime,
                                UpdatedTime = p.UpdatedTime,

                            };
                return query.SingleOrDefault();


            }
        }


        public List<PersonDetailDto> GetPersonDetailsByFilter(string name = null, string lastName = null, string email = null, string identityNumber = null, string city = null, string district = null, string phoneNumber = null, string birthPlace = null, string occupation = null)
        {
            using (var context = new EfCustomersDbContext())
            {
                var addressInfo = from ca in context.CustomerAddresses
                                  join ad in context.AddressDetails on ca.CustomerAddressId equals ad.CustomerAddressId
                                  join co in context.Countries on ad.CountryId equals co.CountryId
                                  join ci in context.Cities on ad.CityId equals ci.CityId
                                  join d in context.Districts on ad.DistrictId equals d.DistrictId
                                  join adt in context.AddressTypes on ca.AddressTypeId equals adt.AddressTypeId
                                  select new
                                  {
                                      ca.CustomerId,
                                      ad.AddressDetailDescription,
                                      ca.IsBillingAddress,
                                      co.CountryName,
                                      ci.CityName,
                                      d.DistrictName,
                                      adt.AddressTypeDescription
                                  };

                var phoneInfo = from cpn in context.CustomerPhoneNumbers
                                join pnd in context.PhoneNumberDetails on cpn.PhoneNumberDetailId equals pnd.PhoneNumberDetailId
                                select new
                                {
                                    cpn.CustomerId,
                                    pnd.PhoneNumber,
                                    cpn.IsPrimary
                                };

                var emailInfo = from ce in context.CustomerEmails
                                join ed in context.EmailDetails on ce.CustomerEmailDetailId equals ed.CustomerEmailDetailId
                                select new
                                {
                                    ce.CustomerId,
                                    ed.Email,
                                    ce.IsPrimary
                                };

                var query = from p in context.Persons
                            join c in context.Customers on p.CustomerId equals c.CustomerId
                            join pit in context.PersonIdentityTypes on p.PersonIdentityTypeId equals pit.PersonIdentityTypeId
                            join po in context.PersonOccupations on p.PersonOccupationId equals po.PersonOccupationId
                            join ai in addressInfo on c.CustomerId equals ai.CustomerId
                            join pi in phoneInfo on c.CustomerId equals pi.CustomerId
                            join ei in emailInfo on c.CustomerId equals ei.CustomerId
                            select new PersonDetailDto
                            {
                                CustomerId = c.CustomerId,
                                PersonId = p.PersonId,
                                Name = c.Name,
                                LastName = c.LastName,
                                IdentityNumber = p.IdentityNumber,
                                IdentityTypeDescription = pit.IdentityTypeDescription,
                                BirthDate = p.BirthDate,
                                BirthPlace = p.BirthPlace,
                                OccupationName = po.OccupationName,
                                AddressDetailDescription = ai.AddressDetailDescription,
                                IsBillingAddress = ai.IsBillingAddress,
                                CountryName = ai.CountryName,
                                CityName = ai.CityName,
                                DistrictName = ai.DistrictName,
                                AddressTypeDescription = ai.AddressTypeDescription,
                                PhoneNumber = pi.PhoneNumber,
                                IsPrimaryPhone = pi.IsPrimary,
                                Email = ei.Email,
                                IsPrimaryEmail = ei.IsPrimary,
                                PersonGenderId = p.PersonGenderId
                            };


                var predicate = PredicateBuilder.True<PersonDetailDto>();


                if (!string.IsNullOrEmpty(name))
                    predicate = predicate.And(p => p.Name.Contains(name));

                if (!string.IsNullOrEmpty(lastName))
                    predicate = predicate.And(p => p.LastName.Contains(lastName));

                if (!string.IsNullOrEmpty(email))
                    predicate = predicate.And(p => p.Email.Contains(email));

                if (!string.IsNullOrEmpty(identityNumber))
                    predicate = predicate.And(p => p.IdentityNumber.Contains(identityNumber));

                if (!string.IsNullOrEmpty(city))
                    predicate = predicate.And(p => p.CityName.Contains(city));

                if (!string.IsNullOrEmpty(district))
                    predicate = predicate.And(p => p.DistrictName.Contains(district));

                if (!string.IsNullOrEmpty(phoneNumber))
                    predicate = predicate.And(p => p.PhoneNumber.Contains(phoneNumber));

                if (!string.IsNullOrEmpty(birthPlace))
                    predicate = predicate.And(p => p.BirthPlace.Contains(birthPlace));

                if (!string.IsNullOrEmpty(occupation))
                    predicate = predicate.And(p => p.OccupationName.Contains(occupation));


                query = query.Where(predicate);

                return query.ToList();
            }
        }

    }
}
