using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
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
                                IsPrimaryEmail = ei.IsPrimary
                            };

                if (filter != null)
                {
                    query = query.Where(filter);
                }

                return query.ToList();
            }
        }
    }
}
