using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPersonIdentityTypeDal:IPersonIdentityTypeDal
    {
        public List<PersonIdentityType> GetAll(Expression<Func<PersonIdentityType, bool>> filter = null)
        {
            using (EfCustomersDbContext customersDbContext = new EfCustomersDbContext())
            {
                return filter == null ? customersDbContext.Set<PersonIdentityType>().ToList() : customersDbContext.Set<PersonIdentityType>().Where(filter).ToList();
            }
        }

        public PersonIdentityType Get(Expression<Func<PersonIdentityType, bool>> filter)
        {
            using (EfCustomersDbContext customersDbContext = new EfCustomersDbContext())
            {
                return customersDbContext.Set<PersonIdentityType>().SingleOrDefault(filter);
            }
        }

        public void Add(PersonIdentityType entity)
        {
            using (EfCustomersDbContext customersDbContext = new EfCustomersDbContext())
            {
                var addedEntity = customersDbContext.Entry(entity);
                addedEntity.State = EntityState.Added;
                customersDbContext.SaveChanges();
            }
        }

        public void Update(PersonIdentityType entity)
        {
            using (EfCustomersDbContext customersDbContext = new EfCustomersDbContext())
            {
                var updatedEntity = customersDbContext.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                customersDbContext.SaveChanges();
            }
        }

        public void Delete(PersonIdentityType entity)
        {
            using (EfCustomersDbContext customersDbContext = new EfCustomersDbContext())
            {
                var deletedEntity = customersDbContext.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                customersDbContext.SaveChanges();
            }
        }
    }
}
