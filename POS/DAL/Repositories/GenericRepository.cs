using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    using System.Linq.Expressions;
    using System.Data.Entity;
    using DAL.Contracts;
    public abstract class GenericRepository<T> : IRepositoryGeneric<T> where T : class
    {
        public void Add(T entity)
        {
            using (dbContext dbContext = new dbContext())
            {
                dbContext.Set<T>().Add(entity);
                dbContext.SaveChanges();
            }
        }

        public void Remove(T entity)
        {
            using (dbContext dbContext = new dbContext())
            {
                dbContext.Entry(entity).State = EntityState.Deleted;
                dbContext.SaveChanges();
            }
        }

        public void Edit(T entity)
        {
            using (dbContext dbContext = new dbContext())
            {
                dbContext.Entry(entity).State = EntityState.Modified;
                dbContext.SaveChanges();
            }
        }

        public IQueryable<T> Find(Expression<Func<T, bool>> predicate)
        {
            using (dbContext dbContext = new dbContext())
            {
                IQueryable<T> query = dbContext.Set<T>().Where(predicate);
                return query;
            }
        }

        public IQueryable<T> GetAll()
        {
            using (dbContext dbContext = new dbContext())
            {
                IQueryable<T> query = dbContext.Set<T>();
                return query;
            }
        }
    }
}
