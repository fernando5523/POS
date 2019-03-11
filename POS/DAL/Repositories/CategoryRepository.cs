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
    public class CategoryRepository: MasterRepository, ICategoryRepository
    {
        public bool Add(Category entity)
        {
            bool result = false;
            using (DBContext db = new DBContext())
            {
                db.Category.Add(entity);
                db.SaveChanges();
                result = true;
            }
            return result;
        }

        public bool Edit(Category entity)
        {
            bool result = false;
            using (DBContext db = new DBContext())
            {
                db.Category.Add(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
                result = true;
            }
            return result;
        }

        public bool Remove(int id)
        {
            bool result = false;
            using (DBContext db = new DBContext())
            {
                var obj = db.Category.Find(id);
                db.Entry(obj).State = EntityState.Deleted;
                db.SaveChanges();
                result = true;
            }
            return result;
        }

        public IEnumerable<Category> GetAll()
        {
            IEnumerable<Category> obj;
            using (DBContext db = new DBContext())
            {
                obj = db.Category;
            }
            return obj;
        }
        public Category GetId(int id)
        {
            Category obj;
            using (DBContext db = new DBContext())
                obj = db.Category.Find(id);
            return obj;
        }
    }
}
