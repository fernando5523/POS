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
        public User GetLogin(string name, string password)
        {
            User Result = Find(e => e.Name == name && e.Password == password).FirstOrDefault();
            return Result;
        }
    }
}
