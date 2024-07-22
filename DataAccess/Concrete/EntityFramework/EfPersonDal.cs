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
    public class EfPersonDal : IPersonDal
    {
        public List<Person> GetAll(Expression<Func<Person, bool>> filter = null)
        {
            using (EfCustomersDbContext customersDbContext = new EfCustomersDbContext())
            {
                return filter == null ? customersDbContext.Set<Person>().ToList() : customersDbContext.Set<Person>().Where(filter).ToList();
            }
        }

        public Person Get(Expression<Func<Person, bool>> filter)
        {
            using (EfCustomersDbContext customersDbContext = new EfCustomersDbContext())
            {
                return customersDbContext.Set<Person>().SingleOrDefault(filter);
            }
        }

        public void Add(Person entity)
        {
            using (EfCustomersDbContext customersDbContext = new EfCustomersDbContext())
            {
                var addedEntity = customersDbContext.Entry(entity);
                addedEntity.State = EntityState.Added;
                customersDbContext.SaveChanges();
            }
        }

        public void Update(Person entity)
        {
            using (EfCustomersDbContext customersDbContext = new EfCustomersDbContext())
            {
                var updatedEntity = customersDbContext.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                customersDbContext.SaveChanges();
            }
        }

        public void Delete(Person entity)
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
