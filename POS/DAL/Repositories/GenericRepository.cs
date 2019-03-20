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
    public abstract class GenericRepository<T> : IDisposable, IGenericRepository<T> where T : class
    {
        dbContext db = new dbContext();
        public void Add(T entity)
        {
            db.Set<T>().Add(entity);
            db.SaveChanges();
        }

        public void Remove(T entity)
        {
            db.Entry(entity).State = EntityState.Deleted;
            //db.Set<T>().Remove(entity);
            db.SaveChanges();
        }

        public void Edit(T entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            db.SaveChanges();
        }

        public IQueryable<T> Find(Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = db.Set<T>().Where(predicate);
            return query;
        }

        public IQueryable<T> GetAll()
        {
            IQueryable<T> query = db.Set<T>();
            return query;
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
