using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Contracts
{
    public interface IGenericRepository<T> where T:class
    {
        bool Add(T entity);
        bool Edit(T entity);
        bool Remove(int id);
        IEnumerable<T> GetAll();
    }
}