using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class User
    {
        #region Properties
        public int ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public bool Active { get; set; }
        public Nullable<int> UserID { get; set; }
        #endregion

        #region Navigation properties
        public virtual User UserModified { get; set; }
        #endregion
    }
}