using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entity = EL;

namespace BLL
{
    public class Filter
    {
        DAL.Filter obj = new DAL.Filter();
        public bool Insert(Entity.Filter Filter)
        {
            return obj.Insert(Filter);
        }

        public bool Update(Entity.Filter Filter)
        {
            return obj.Update(Filter);
        }

        public bool Delete(Entity.Filter Filter)
        {
            return obj.Delete(Filter);
        }

        public Entity.Filter GetBy(int IdConsult)
        {
            return obj.GetBy(IdConsult);
        }
    }
}
