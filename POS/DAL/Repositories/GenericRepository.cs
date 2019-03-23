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
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public void Add(T entity)
        {
            using (dbContext db = new dbContext())
            {
                db.Set<T>().Add(entity);
                db.SaveChanges();
            }
        }

        public void Remove(T entity)
        {
            using (dbContext db = new dbContext())
            {
                db.Entry(entity).State = EntityState.Deleted;
                //db.Set<T>().Remove(entity);
                db.SaveChanges();
            }
        }

        public void Edit(T entity)
        {
            using (dbContext db = new dbContext())
            {
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public List<T> Find(Expression<Func<T, bool>> predicate)
        {
            using (dbContext db = new dbContext())
            {
                List<T> query = db.Set<T>().Where(predicate).ToList();
                return query;
            }
        }

        public List<T> GetAll()
        {
            using (dbContext db = new dbContext())
            {
                List<T> query = db.Set<T>().ToList();
                return query;
            }
        }
    }
}
