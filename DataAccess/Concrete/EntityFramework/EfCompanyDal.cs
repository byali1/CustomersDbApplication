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
    public class EfCompanyDal : EfEntityRepositoryBase<Company, EfCustomersDbContext>, ICompanyDal
    {
        public async Task<CompanyById> GetCompanyIdValuesByIdAsync(int companyId)
        {
            using (var context = new EfCustomersDbContext())
            {
                var query = from c in context.Companies
                            join cs in context.CompanySectors
                                on c.CompanySectorTypeId equals cs.CompanySectorTypeId
                            join ca in context.CustomerAddresses
                                on c.CustomerId equals ca.CustomerId
                            join adt in context.AddressTypes
                                on ca.AddressTypeId equals adt.AddressTypeId
                            join ad in context.AddressDetails
                                on ca.CustomerAddressId equals ad.CustomerAddressId
                            join ce in context.CustomerEmails
                                on c.CustomerId equals ce.CustomerId
                            join ed in context.EmailDetails
                                on ce.CustomerEmailDetailId equals ed.CustomerEmailDetailId
                            join cpn in context.CustomerPhoneNumbers
                                on c.CustomerId equals cpn.CustomerId
                            join pnd in context.PhoneNumberDetails
                                on cpn.PhoneNumberDetailId equals pnd.PhoneNumberDetailId
                            where c.CompanyId == companyId
                            select new CompanyById
                            {
                                CompanyId = c.CompanyId,
                                CustomerId = c.CustomerId,
                                CompanySectorTypeId = c.CompanySectorTypeId,
                                AuthorizedPersonId = c.AuthorizedPersonId,
                                CustomerAddressId = ca.CustomerAddressId,
                                AddressTypeId = adt.AddressTypeId,
                                AddressDetailId = ad.AddressDetailId,
                                CityId = ad.CityId,
                                DistrictId = ad.DistrictId,
                                CountryId = ad.CountryId,
                                CustomerEmailDetailId = ed.CustomerEmailDetailId,
                                CustomerEmailId = ce.CustomerEmailId,
                                CustomerPhoneNumberId = cpn.CustomerPhoneNumberId,
                                PhoneNumberDetailId = pnd.PhoneNumberDetailId,
                                CreatedTime = c.CreatedTime,
                                UpdatedTime = c.UpdatedTime
                            };

                return await query.SingleOrDefaultAsync();
            }
        }

        public async Task<List<CompanyDetailDto>> GetCompanyDetailsAsync(Expression<Func<CompanyDetailDto, bool>> filter = null)
        {
            using (var context = new EfCustomersDbContext())
            {
                // Adres bilgilerini al
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
                                      adt.AddressTypeDescription,
                                      ci.CityName,
                                      d.DistrictName,
                                      co.CountryName
                                  };

                // Telefon bilgilerini al
                var phoneInfo = from cpn in context.CustomerPhoneNumbers
                                join pnd in context.PhoneNumberDetails on cpn.PhoneNumberDetailId equals pnd.PhoneNumberDetailId
                                select new
                                {
                                    cpn.CustomerId,
                                    pnd.PhoneNumber,
                                    cpn.IsPrimary
                                };

                // Email bilgilerini al
                var emailInfo = from ce in context.CustomerEmails
                                join ed in context.EmailDetails on ce.CustomerEmailDetailId equals ed.CustomerEmailDetailId
                                select new
                                {
                                    ce.CustomerId,
                                    ed.Email,
                                    ce.IsPrimary
                                };

                // Ana sorgu
                var query = from c in context.Customers
                            join com in context.Companies on c.CustomerId equals com.CustomerId
                            join cs in context.CompanySectors on com.CompanySectorTypeId equals cs.CompanySectorTypeId
                            join ai in addressInfo on c.CustomerId equals ai.CustomerId into addressJoin
                            from ai in addressJoin.DefaultIfEmpty()
                            join pi in phoneInfo on c.CustomerId equals pi.CustomerId into phoneJoin
                            from pi in phoneJoin.DefaultIfEmpty()
                            join ei in emailInfo on c.CustomerId equals ei.CustomerId into emailJoin
                            from ei in emailJoin.DefaultIfEmpty()
                            select new CompanyDetailDto
                            {
                                CustomerId = c.CustomerId,
                                CompanyId = com.CompanyId,
                                Name = c.Name,
                                TaxNumber = com.TaxNumber,
                                EstablishedDate = com.EstablishedDate,
                                EmployeeCount = com.EmployeeCount,
                                CompanySectorType = cs.CompanySectorType,
                                AddressName = ai.AddressDetailDescription,
                                IsBillingAddress = ai.IsBillingAddress,
                                AddressTypeDescription = ai.AddressTypeDescription,
                                AddressDetailDescription = ai.AddressDetailDescription,
                                CityName = ai.CityName,
                                DistrictName = ai.DistrictName,
                                CountryName = ai.CountryName,
                                Email = ei.Email,
                                IsPrimaryEmail = ei.IsPrimary,
                                PhoneNumber = pi.PhoneNumber,
                                IsPrimaryPhone = pi.IsPrimary,
                                IsActiveCustomer = c.IsActiveCustomer,
                                CreatedTime = com.CreatedTime
                            };

                // Filtre uygulama
                if (filter != null)
                {
                    query = query.Where(filter);
                }

                return await query.ToListAsync();
            }
        }
    }

}
