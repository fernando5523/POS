using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using DAL.Contracts;
using DAL.Entities;

namespace DAL.Repositories
{
    public class FilterRepository : MasterRepository, IFilterRepository
    {
        private string selectAll;
        private string insert;
        private string update;
        private string delete;
        public FilterRepository()
        {
            selectAll = "SELECT * FROM [Filter]";
            insert = "INSERT INTO [Filter] VALUES(@iduser, @idconsult, @condition, @conditiondev)";
            update = "UPDATE [Filter] SET IdUser = @iduser, IdConsult = @idconsult, Condition = @condition, ConditionDev = @conditiondev WHERE Id = @id";
            delete = "DELETE FROM [Filter] WHERE Id = @id";
        }
        public int Add(Filter entity)
        {
            var parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@iduser", entity.IdUser));
            parameters.Add(new SqlParameter("@idconsult", entity.IdConsult));
            parameters.Add(new SqlParameter("@condition", entity.Condition));
            parameters.Add(new SqlParameter("@conditiondev", entity.ConditionDev));
            return ExecuteNonQuery(insert);
        }

        public int Edit(Filter entity)
        {
            var parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id", entity.Id));
            parameters.Add(new SqlParameter("@iduser", entity.IdUser));
            parameters.Add(new SqlParameter("@idconsult", entity.IdConsult));
            parameters.Add(new SqlParameter("@condition", entity.Condition));
            parameters.Add(new SqlParameter("@conditiondev", entity.ConditionDev));
            return ExecuteNonQuery(update);
        }

        public IEnumerable<Filter> GetAll()
        {
            var tableResult = ExecuteReader(selectAll);
            var listFilter = new List<Filter>();
            foreach(DataRow item in tableResult.Rows)
            {
                listFilter.Add(new Filter
                {
                    Id = (int)item["Id"],
                    IdUser = (int)item["IdUser"],
                    IdConsult = (int)item["IdConsult"],
                    Condition = (string)item["Condition"],
                    ConditionDev = (string)item["ConditionDev"]
                });
            }
            return listFilter;
        }

        public int Remove(int id)
        {
            var parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id", id));
            return ExecuteNonQuery(delete);
        }
    }
}
