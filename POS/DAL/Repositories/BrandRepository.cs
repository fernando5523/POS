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
    public class BrandRepository : MasterRepository, IBrandRepository
    {
        public bool Add(Brand entity)
        {
            bool result = false;
            using(DBContext db = new DBContext())
            {
                db.Brand.Add(entity);
                db.SaveChanges();
                result = true;
            }
            return result;
        }

        public bool Edit(Brand entity)
        {
            bool result = false;
            using (DBContext db = new DBContext())
            {
                db.Brand.Add(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
                result = true;
            }
            return result;
        }

        public IEnumerable<Brand> GetAll()
        {
            IEnumerable<Brand> obj;
            using (DBContext db = new DBContext())
            {
                obj = db.Brand;
            }
            return obj;
        }

        public Brand GetId(int id)
        {
            Brand obj;
            using (DBContext db = new DBContext())
                obj = db.Brand.Find(id);
            return obj;
        }

        public bool Remove(int id)
        {
            bool result = false;
            using (DBContext db = new DBContext())
            {
                var obj = db.Brand.Find(id);
                db.Entry(obj).State = EntityState.Deleted;
                db.SaveChanges();
                result = true;
            }
            return result;
        }
    }
}
