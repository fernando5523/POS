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
            using (dbContext db = new dbContext())
            {
                db.Containers.Add(entity);
                db.SaveChanges();
                result = true;
            }
            return result;
        }

        public bool Edit(Container entity)
        {
            bool result = false;
            using (dbContext db = new dbContext())
            {
                db.Containers.Add(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
                result = true;
            }
            return result;
        }

        public IEnumerable<Container> GetAll()
        {
            IEnumerable<Container> obj;
            using (dbContext db = new dbContext())
            {
                obj = db.Containers;
            }
            return obj;
        }

        public Container GetContainerName(string name)
        {
            Container obj;
            using(dbContext db = new dbContext())
            {
                obj = (from o in db.Containers
                       where o.Name == name
                       select o).FirstOrDefault();
            }
            return obj;
        }

        public bool Remove(int id)
        {
            bool result = false;
            using (dbContext db = new dbContext())
            {
                var obj = db.Containers.Find(id);
                db.Entry(obj).State = EntityState.Deleted;
                db.SaveChanges();
                result = true;
            }
            return result;
        }
    }
}
