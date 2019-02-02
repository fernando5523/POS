using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Security
    {
        DAL.Security obj = new DAL.Security();

        public string Encrypt(string text)
        {
            return obj.Encrypt(text);
        }

        public string Decrypt(string text)
        {
            return obj.Decrypt(text);
        }
    }
}
