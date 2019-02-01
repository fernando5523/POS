using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    class Connect
    {
        public SqlConnection Cn { get; set; }

        public Connect()
        {
            this.Cn = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLServer"].ToString());
        }

        public void Open()
        {
            if (Cn.State == ConnectionState.Closed)
                Cn.Open();
        }

        public void Close()
        {
            if (Cn.State == ConnectionState.Open)
                Cn.Close();
        }        
    }
}
