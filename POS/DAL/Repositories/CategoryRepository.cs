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
            using (dbContext db = new dbContext())
            {
                db.Categories.Add(entity);
                db.SaveChanges();
                result = true;
            }
            return result;
        }

        public bool Edit(Category entity)
        {
            bool result = false;
            using (dbContext db = new dbContext())
            {
                db.Categories.Add(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
                result = true;
            }
            return result;
        }

        public bool Remove(int id)
        {
            bool result = false;
            using (dbContext db = new dbContext())
            {
                var obj = db.Categories.Find(id);
                db.Entry(obj).State = EntityState.Deleted;
                db.SaveChanges();
                result = true;
            }
            return result;
        }

        public IEnumerable<Category> GetAll()
        {
            IEnumerable<Category> obj;
            using (dbContext db = new dbContext())
            {
                obj = db.Categories;
            }
            return obj;
        }
        public Category GetId(int id)
        {
            Category obj;
            using (dbContext db = new dbContext())
                obj = db.Categories.Find(id);
            return obj;
        }
    }
}
