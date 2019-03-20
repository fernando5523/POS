using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    using System.Data.Entity;
    using System.Data;
    using System.Data.SqlClient;
    using DAL.Contracts;
    using DAL.Entities;
    public class FilterRepository : GenericRepository<Filter>, IFilterRepository
    {
        public DataTable Execute(string sql)
        {
            var result = new DataTable();
            using (dbContext db = new dbContext())
            {
                var cmd = db.Database.Connection.CreateCommand();
                cmd.CommandText = sql;
                cmd.Connection.Open();
                result.Load(cmd.ExecuteReader());
            }
            return result;
        }
    }
}
