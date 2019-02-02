using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;
using Entity = EL;

namespace BLL
{
    public class User
    {
        DAL.User obj = new DAL.User();

        public bool Insert(Entity.User user)
        {
            return obj.Insert(user);
        }

        public bool Update(Entity.User user)
        {
            return obj.Update(user);
        }

        public bool Delete(Entity.User user)
        {
            return obj.Delete(user);
        }

        public Entity.User ListBy(Entity.User user)
        {
            return obj.ListBy(user);
        }
    }
}
