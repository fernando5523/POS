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
    public class GenericRepository<T> : IRepositoryGeneric<T> where T : class
    {
        internal DBContext dbcontext;
        public GenericRepository(DBContext context)
        {
            dbcontext = context;
        }
        public void Add(T entity)
        {
            dbcontext.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            dbcontext.Set<T>().Remove(entity);
            Save();
        }

        public void Edit(T entity)
        {
            dbcontext.Entry(entity).State = EntityState.Modified;
        }

        public IQueryable<T> Find(Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = dbcontext.Set<T>().Where(predicate);
            return query;
        }

        public IQueryable<T> GetAll()
        {
            IQueryable<T> query = dbcontext.Set<T>();
            return query;
        }

        public void Save()
        {
            dbcontext.SaveChanges();
        }
    }
}
