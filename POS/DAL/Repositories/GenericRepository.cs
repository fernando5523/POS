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
    using DAL.Entities;
    public abstract class GenericRepository<T> : IRepositoryGeneric<T> where T : class
    {
        public void Add(T entity)
        {
            using (DBContext dbContext = new DBContext())
            {
                dbContext.Set<T>().Add(entity);
                dbContext.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (DBContext dbContext = new DBContext())
            {
                dbContext.Entry(entity).State = EntityState.Deleted;
                dbContext.SaveChanges();
            }
        }

        public void Edit(T entity)
        {
            using (DBContext dbContext = new DBContext())
            {
                dbContext.Entry(entity).State = EntityState.Modified;
                dbContext.SaveChanges();
            }
        }

        public IQueryable<T> Find(Expression<Func<T, bool>> predicate)
        {
            using (DBContext dbContext = new DBContext())
            {
                IQueryable<T> query = dbContext.Set<T>().Where(predicate);
                return query;
            }
        }

        public IQueryable<T> GetAll()
        {
            using (DBContext dbContext = new DBContext())
            {
                IQueryable<T> query = dbContext.Set<T>();
                return query;
            }
        }
    }
}
