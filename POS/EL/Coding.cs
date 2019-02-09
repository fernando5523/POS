using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class Coding
    {
        private int id;
        private int entity;
        private string text;
        private int number;
        private int numberlength;
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

        public int Entity
        {
            get
            {
                return entity;
            }

            set
            {
                entity = value;
            }
        }

        public string Text
        {
            get
            {
                return text;
            }

            set
            {
                text = value;
            }
        }

        public int Number
        {
            get
            {
                return number;
            }

            set
            {
                number = value;
            }
        }

        public int NumberLength
        {
            get
            {
                return numberlength;
            }

            set
            {
                numberlength = value;
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
