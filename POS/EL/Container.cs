using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class Container
    {
        private int id;
        private string code;
        private string name;
        private string description;
        private bool active;
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

        public string Code
        {
            get
            {
                return code;
            }

            set
            {
                code = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public bool Active
        {
            get
            {
                return active;
            }

            set
            {
                active = value;
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
