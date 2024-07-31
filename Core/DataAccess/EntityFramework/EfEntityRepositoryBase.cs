using System;
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
        public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext dbContext = new TContext())
            {
                IQueryable<TEntity> query = dbContext.Set<TEntity>();
                if (filter != null)
                {
                    query = query.Where(filter);
                }

                return await query.ToListAsync();
            }
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext dbContext = new TContext())
            {
                return await dbContext.Set<TEntity>().SingleOrDefaultAsync(filter);
            }
        }

        public async Task AddAsync(TEntity entity)
        {
            using (TContext dbContext = new TContext())
            {
                await dbContext.Set<TEntity>().AddAsync(entity);
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task UpdateAsync(TEntity entity)
        {
            using (TContext dbContext = new TContext())
            {
                dbContext.Set<TEntity>().Update(entity);
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task DeleteAsync(TEntity entity)
        {
            using (TContext dbContext = new TContext())
            {
                dbContext.Set<TEntity>().Remove(entity);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
