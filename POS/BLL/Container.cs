using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entity = EL;

namespace BLL
{
    public class Container
    {
        DAL.Container obj = new DAL.Container();
        public bool Insert(Entity.Container Container)
        {
            return obj.Insert(Container);
        }

        public bool Update(Entity.Container Container)
        {
            return obj.Update(Container);
        }

        public bool Delete(int Id)
        {
            return obj.Delete(Id);
        }

        public Entity.Container GetBy(string Code)
        {
            return obj.GetBy(Code);
        }
    }
}
