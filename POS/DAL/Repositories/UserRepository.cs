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
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public void Add(User entity)
        {
            using (dbContext db = new dbContext())
            {
                db.Users.Add(entity);
                db.SaveChanges();
            }
        }

        public void Edit(User entity)
        {
            using (dbContext db = new dbContext())
            {
                db.Users.Add(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public IEnumerable<User> GetAll()
        {
            IEnumerable<User> obj;
            using (dbContext db = new dbContext())
            {
                obj = db.Users;
            }
            return obj;
        }

        public User GetLogin(string name, string password)
        {
            User obj;
            using(dbContext db = new dbContext())
            {
                obj = (from o in db.Users
                      where o.Name == name && o.Password == password
                      select o).FirstOrDefault();
            }
            return obj;
        }

        public void Remove(User entity)
        {
            using (dbContext db = new dbContext())
            {
                var obj = db.Users.Find(entity);
                db.Entry(obj).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }
    }
}
