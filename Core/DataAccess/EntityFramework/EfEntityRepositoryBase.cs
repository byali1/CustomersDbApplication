﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext dbContext = new TContext())
            {
                return filter == null ? dbContext.Set<TEntity>().ToList() : dbContext.Set<TEntity>().Where(filter).ToList();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext dbContext = new TContext())
            {
                return dbContext.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public void Add(TEntity entity)
        {
            using (TContext dbContext = new TContext())
            {
                var addedEntity = dbContext.Entry(entity);
                addedEntity.State = EntityState.Added;
                dbContext.SaveChanges();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext dbContext = new TContext())
            {
                var updatedEntity = dbContext.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                dbContext.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext dbContext = new TContext())
            {
                var deletedEntity = dbContext.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                dbContext.SaveChanges();
            }
        }
    }
}
