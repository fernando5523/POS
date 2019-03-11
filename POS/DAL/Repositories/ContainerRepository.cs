using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    using System.Data.Entity;
    using DAL.Contracts;
    using DAL.Entities;
    public class ContainerRepository : MasterRepository, IContainerRepository
    {
        public bool Add(Container entity)
        {
            bool result = false;
            using (DBContext db = new DBContext())
            {
                db.Container.Add(entity);
                db.SaveChanges();
                result = true;
            }
            return result;
        }

        public bool Edit(Container entity)
        {
            bool result = false;
            using (DBContext db = new DBContext())
            {
                db.Container.Add(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
                result = true;
            }
            return result;
        }

        public IEnumerable<Container> GetAll()
        {
            IEnumerable<Container> obj;
            using (DBContext db = new DBContext())
            {
                obj = db.Container;
            }
            return obj;
        }

        public Container GetContainerName(string name)
        {
            Container obj;
            using(DBContext db = new DBContext())
            {
                obj = (from o in db.Container
                       where o.Name == name
                       select o).FirstOrDefault();
            }
            return obj;
        }

        public bool Remove(int id)
        {
            bool result = false;
            using (DBContext db = new DBContext())
            {
                var obj = db.Container.Find(id);
                db.Entry(obj).State = EntityState.Deleted;
                db.SaveChanges();
                result = true;
            }
            return result;
        }
    }
}
