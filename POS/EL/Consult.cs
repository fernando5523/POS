using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class Consult
    {
        private int id;
        private int idcontainer;
        private bool principal;
        private string select;
        private string from;
        private string where;
        private string groupby;
        private string having;
        private string orderby;
        private int iduser;

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

        public int IdContainer
        {
            get
            {
                return idcontainer;
            }

            set
            {
                idcontainer = value;
            }
        }

        public bool Principal
        {
            get
            {
                return principal;
            }

            set
            {
                principal = value;
            }
        }

        public string Select
        {
            get
            {
                return select;
            }

            set
            {
                select = value;
            }
        }

        public string From
        {
            get
            {
                return from;
            }

            set
            {
                from = value;
            }
        }

        public string Where
        {
            get
            {
                return where;
            }

            set
            {
                where = value;
            }
        }

        public string GroupBy
        {
            get
            {
                return groupby;
            }

            set
            {
                groupby = value;
            }
        }

        public string Having
        {
            get
            {
                return having;
            }

            set
            {
                having = value;
            }
        }

        public string OrderBy
        {
            get
            {
                return orderby;
            }

            set
            {
                orderby = value;
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
    }
}
