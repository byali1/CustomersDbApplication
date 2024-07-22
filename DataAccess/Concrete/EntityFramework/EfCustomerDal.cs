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
    public class EfCustomerDal : ICustomerDal
    {
        public List<Customer> GetAll(Expression<Func<Customer, bool>> filter = null)
        {

            using (EfCustomersDbContext customersDbContext = new EfCustomersDbContext())
            {
                return filter == null ? customersDbContext.Set<Customer>().ToList() : customersDbContext.Set<Customer>().Where(filter).ToList();
            }


        }

        public Customer Get(Expression<Func<Customer, bool>> filter)
        {
            using (EfCustomersDbContext customersDbContext = new EfCustomersDbContext())
            {
                return  customersDbContext.Set<Customer>().SingleOrDefault(filter);
            }
        }

        public void Add(Customer entity)
        {
            using (EfCustomersDbContext customersDbContext = new EfCustomersDbContext())
            {
                var addedEntity = customersDbContext.Entry(entity);
                addedEntity.State = EntityState.Added;
                customersDbContext.SaveChanges();
            }
        }

        public void Update(Customer entity)
        {
            using (EfCustomersDbContext customersDbContext = new EfCustomersDbContext())
            {
                var updatedEntity = customersDbContext.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                customersDbContext.SaveChanges();
            }
        }

        public void Delete(Customer entity)
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
