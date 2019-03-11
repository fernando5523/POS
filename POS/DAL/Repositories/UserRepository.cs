using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    using System.Data.SqlClient;
    using System.Data.Entity;
    using DAL.Contracts;
    using DAL.Entities;
    public class UserRepository : MasterRepository, IUserRepository
    {
        public bool Add(User entity)
        {
            bool result = false;
            using (DBContext db = new DBContext())
            {
                db.User.Add(entity);
                db.SaveChanges();
                result = true;
            }
            return result;
        }

        public bool Edit(User entity)
        {
            bool result = false;
            using (DBContext db = new DBContext())
            {
                db.User.Add(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
                result = true;
            }
            return result;
        }

        public IEnumerable<User> GetAll()
        {
            IEnumerable<User> obj;
            using (DBContext db = new DBContext())
            {
                obj = db.User;
            }
            return obj;
        }

        public User GetLogin(string name, string password)
        {
            User obj;
            using(DBContext db = new DBContext())
            {
                obj = (from o in db.User
                      where o.Name == name && o.Password == password
                      select o).FirstOrDefault();
            }
            return obj;
        }

        public bool Remove(int id)
        {
            bool result = false;
            using (DBContext db = new DBContext())
            {
                var obj = db.User.Find(id);
                db.Entry(obj).State = EntityState.Deleted;
                db.SaveChanges();
                result = true;
            }
            return result;
        }
    }
}
