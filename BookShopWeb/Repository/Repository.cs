using BookShopWeb.Data;
using BookShopWeb.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BookShopWeb.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDBContext _dbContext;
        internal DbSet<T> dbSet { get; set; }
        public Repository(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
            this.dbSet = _dbContext.Set<T>();
        }
        public void Add(T entity)
        {
             dbSet.Add(entity);
        }

        public T Get(Expression<Func<T, bool>> filter, string? includeProperty = null)
        {
            IQueryable<T> query = dbSet;
            query = query.Where(filter);
            if (!String.IsNullOrEmpty(includeProperty))
            {
                query.Include(includeProperty).ToList();
            }
            return query.FirstOrDefault();

        }

        public IEnumerable<T> GetAll(string? includeProperty = null)
        {
            IQueryable<T> query = dbSet;
            if (!String.IsNullOrEmpty(includeProperty))
            {
                query.Include(includeProperty).ToList();
            }
            return query.ToList();
        }

        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }


    }
}
