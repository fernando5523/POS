using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Contracts
{
    public interface IGenericRepository<Entity> where Entity:class
    {
        bool Add(Entity entity);
        bool Edit(Entity entity);
        bool Remove(int id);
        IEnumerable<Entity> GetAll();
    }
}
