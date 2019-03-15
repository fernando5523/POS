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
    public class CodingRepository : MasterRepository, ICodingRepository
    {
        public bool Add(Coding entity)
        {
            bool result = false;
            using (dbContext db = new dbContext())
            {
                db.Codings.Add(entity);
                db.SaveChanges();
                result = true;
            }
            return result;
        }

        public bool Edit(Coding entity)
        {
            bool result = false;
            using (dbContext db = new dbContext())
            {
                db.Codings.Add(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
                result = true;
            }
            return result;
        }

        public IEnumerable<Coding> GetAll()
        {
            IEnumerable<Coding> obj;
            using (dbContext db = new dbContext())
            {
                obj = db.Codings;
            }
            return obj;
        }

        public Coding GetEntity(string entity)
        {
            Coding obj;
            using(dbContext db = new dbContext())
            {
                obj = (from o in db.Codings
                       where o.Entity == entity
                       select o).FirstOrDefault();
            }
            return obj;
        }

        public bool Remove(int id)
        {
            bool result = false;
            using (dbContext db = new dbContext())
            {
                var obj = db.Codings.Find(id);
                db.Entry(obj).State = EntityState.Deleted;
                db.SaveChanges();
                result = true;
            }
            return result;
        }
    }
}
