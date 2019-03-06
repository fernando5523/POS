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
    public class ConsultRepository : MasterRepository, IConsultRepository
    {
        private string selectAll;
        private string selectIdContainer;
        private string insert;
        private string update;
        private string delete;
        public ConsultRepository()
        {
            selectAll = "SELECT * FROM [Consult]";
            selectIdContainer = "SELECT * FROM [Consult] WHERE IdContainer = @idcontainer AND Principal = 1";
            insert = "INSERT INTO [Consult] VALUES(@idcontainer, @principal, @select, @from, @where, @groupby, @having, @orderby, @iduser)";
            update = "UPDATE [Consult] SET IdContainer = @idcontainer, Principal = @principal, Select = @select, From = @from, Where = @where, GroupBy = @groupby, Having = @having, OrderBy = @orderby, IdUser = @iduser WHERE Id = @id";
            delete = "DELETE FROM [Consult] WHERE Id = @id";
        }
        public int Add(Consult entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@idcontainer", entity.IdContainer));
            parameters.Add(new SqlParameter("@principal", entity.Principal));
            parameters.Add(new SqlParameter("@select", entity.Select));
            parameters.Add(new SqlParameter("@from", entity.From));
            parameters.Add(new SqlParameter("@where", entity.Where));
            parameters.Add(new SqlParameter("@groupby", entity.GroupBy));
            parameters.Add(new SqlParameter("@having", entity.Having));
            parameters.Add(new SqlParameter("@orderby", entity.OrderBy));
            parameters.Add(new SqlParameter("@iduser", entity.IdUser));
            return ExecuteNonQuery(insert);
        }

        public int Edit(Consult entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id", entity.Id));
            parameters.Add(new SqlParameter("@idcontainer", entity.IdContainer));
            parameters.Add(new SqlParameter("@principal", entity.Principal));
            parameters.Add(new SqlParameter("@select", entity.Select));
            parameters.Add(new SqlParameter("@from", entity.From));
            parameters.Add(new SqlParameter("@where", entity.Where));
            parameters.Add(new SqlParameter("@groupby", entity.GroupBy));
            parameters.Add(new SqlParameter("@having", entity.Having));
            parameters.Add(new SqlParameter("@orderby", entity.OrderBy));
            parameters.Add(new SqlParameter("@iduser", entity.IdUser));
            return ExecuteNonQuery(update);
        }

        public IEnumerable<Consult> GetAll()
        {
            var tableConsult = ExecuteReader(selectAll);
            var listConsult = new List<Consult>();
            foreach(DataRow item in tableConsult.Rows)
            {
                listConsult.Add(new Consult
                {
                    Id = (int)item["Id"],
                    IdContainer = (int)item["IdContainer"],
                    Principal = (bool)item["Principal"],
                    Select = (string)item["Select"],
                    From = (string)item["From"],
                    Where = (string)item["Where"],
                    GroupBy = (string)item["GroupBy"],
                    Having = (string)item["Having"],
                    OrderBy = (string)item["OrderBy"],
                    IdUser = (int)item["IdUser"]
                });
            }
            return listConsult;
        }

        public Consult GetIdContainer(int idContainer)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@idcontainer", idContainer));
            var tableConsult = ExecuteReader(selectIdContainer);
            var listConsult = new Consult();
            foreach (DataRow item in tableConsult.Rows)
            {
                listConsult.Id = (int)item["Id"];
                listConsult.IdContainer = (int)item["IdContainer"];
                listConsult.Principal = (bool)item["Principal"];
                listConsult.Select = (string)item["Select"];
                listConsult.From = (string)item["From"];
                listConsult.Where = item["Where"].ToString();
                listConsult.GroupBy = item["GroupBy"].ToString();
                listConsult.Having = item["Having"].ToString();
                listConsult.OrderBy = item["OrderBy"].ToString();
                listConsult.IdUser = (int)item["IdUser"];
            }
            return listConsult;
        }

        public int Remove(int id)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id", id));
            return ExecuteNonQuery(delete);
        }
    }
}
