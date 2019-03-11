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
    public class ConsultRepository : MasterRepository, IConsultRepository
    {
        public bool Add(Consult entity)
        {
            bool result = false;
            using (DBContext db = new DBContext())
            {
                db.Consult.Add(entity);
                db.SaveChanges();
                result = true;
            }
            return result;
        }

        public bool Edit(Consult entity)
        {
            bool result = false;
            using (DBContext db = new DBContext())
            {
                db.Consult.Add(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
                result = true;
            }
            return result;
        }

        public IEnumerable<Consult> GetAll()
        {
            IEnumerable<Consult> obj;
            using (DBContext db = new DBContext())
            {
                obj = db.Consult;
            }
            return obj;
        }

        public Consult GetIdContainer(int idContainer)
        {
            Consult obj;
            using (DBContext db = new DBContext())
            {
                obj = (from o in db.Consult
                       where o.IdContainer == idContainer
                       select o).FirstOrDefault();
            }
            return obj;
        }

        public bool Remove(int id)
        {
            bool result = false;
            using (DBContext db = new DBContext())
            {
                var obj = db.Consult.Find(id);
                db.Entry(obj).State = EntityState.Deleted;
                db.SaveChanges();
                result = true;
            }
            return result;
        }
    }
}
