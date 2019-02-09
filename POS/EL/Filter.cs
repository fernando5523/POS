using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class Filter
    {
        private int id;
        private int iduser;
        private int idconsult;
        private string condition;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public int IdUser
        {
            get
            {
                return iduser;
            }

            set
            {
                iduser = value;
            }
        }

        public int IdConsult
        {
            get
            {
                return idconsult;
            }

            set
            {
                idconsult = value;
            }
        }

        public string Condition
        {
            get
            {
                return condition;
            }

            set
            {
                condition = value;
            }
        }
    }
}
