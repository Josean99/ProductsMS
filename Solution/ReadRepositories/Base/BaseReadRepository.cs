using DBContext;
using IReadRepositories.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ReadRepositories.Base
{
    public class BaseReadRepository : IBaseReadRepository 
    {
        private readonly ProductsAPIContext _dbContext;
        public BaseReadRepository(ProductsAPIContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IQueryable<T>> GetByCondition<T>(Expression<Func<T, bool>> expression, params Expression<Func<T, object>>[] includes) where T : class
        {
            var query = _dbContext.Set<T>().AsNoTracking();

            if (includes != null)
            {
                query = includes.Aggregate(query,
                          (current, include) => current.Include(include));
            }

            return query.Where(expression);
        }

        public async Task<T> GetFirstByCondition<T>(Expression<Func<T, bool>> expression, params Expression<Func<T, object>>[] includes) where T : class
        {
            var query = _dbContext.Set<T>().AsNoTracking();

            if (includes != null)
            {
                query = includes.Aggregate(query,
                          (current, include) => current.Include(include));
            }

            return query.First(expression);
        }

        public async Task<IQueryable<T>> GetAll<T>(params Expression<Func<T, object>>[] includes) where T : class
        {
            var query = _dbContext.Set<T>().AsNoTracking();

            if (includes != null)
            {
                query = includes.Aggregate(query,
                          (current, include) => current.Include(include));
            }

            return query;
        }
    }
}
