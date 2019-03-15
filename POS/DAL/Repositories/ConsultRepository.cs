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
            using (dbContext db = new dbContext())
            {
                db.Consults.Add(entity);
                db.SaveChanges();
                result = true;
            }
            return result;
        }

        public bool Edit(Consult entity)
        {
            bool result = false;
            using (dbContext db = new dbContext())
            {
                db.Consults.Add(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
                result = true;
            }
            return result;
        }

        public IEnumerable<Consult> GetAll()
        {
            IEnumerable<Consult> obj;
            using (dbContext db = new dbContext())
            {
                obj = db.Consults;
            }
            return obj;
        }

        public Consult GetIdContainer(int idContainer)
        {
            Consult obj;
            using (dbContext db = new dbContext())
            {
                obj = (from o in db.Consults
                       where o.IdContainer == idContainer
                       select o).FirstOrDefault();
            }
            return obj;
        }

        public bool Remove(int id)
        {
            bool result = false;
            using (dbContext db = new dbContext())
            {
                var obj = db.Consults.Find(id);
                db.Entry(obj).State = EntityState.Deleted;
                db.SaveChanges();
                result = true;
            }
            return result;
        }
    }
}
