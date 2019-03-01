using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL.Contracts
{
    public interface IUserRepository:IGenericRepository<User>
    {
        User GetLogin(string name, string password);
    }
}
