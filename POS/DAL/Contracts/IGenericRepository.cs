using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Contracts
{
    using System.Linq;
    using System.Linq.Expressions;
    public interface IGenericRepository<T> where T:class
    {
        IQueryable<T> GetAll();
        IQueryable<T> Find(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Remove(T entity);
        void Edit(T entity);
    }
}