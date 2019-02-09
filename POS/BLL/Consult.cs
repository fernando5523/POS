using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entity = EL;
using System.Data;

namespace BLL
{
    public class Consult
    {
        DAL.Consult obj = new DAL.Consult();

        public bool Insert(Entity.Consult Consult)
        {
            return obj.Insert(Consult);
        }

        public bool Update(Entity.Consult Consult)
        {
            return obj.Update(Consult);
        }

        public bool Delete(int Id)
        {
            return obj.Delete(Id);
        }

        public Entity.Consult GetBy(int IdContainer)
        {
            return obj.GetBy(IdContainer);
        }

        public DataTable GetView(Entity.Container Container)
        {
            return obj.GetView(Container);
        }
    }
}
