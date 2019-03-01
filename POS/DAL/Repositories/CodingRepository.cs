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
    public class CodingRepository : MasterRepository, ICodingRepository
    {
        private string selectAll;
        private string insert;
        private string update;
        private string delete;
        public CodingRepository()
        {
            selectAll = "SELECT * FROM [Coding]";
            insert = "INSERT INTO [Coding] VALUES(@entity, @text, @number, @numberlength, @active, @iduser)";
            update = "UPDATE [Coding] SET Entity = @entity, Text = @text, Number = @number, NumberLength = @numberlength, Active = @active, IdUser = @iduser WHERE Id = @id";
            delete = "DELETE FROM [Coding] WHERE Id = @id";
        }
        public int Add(Coding entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@entity", entity.Entity));
            parameters.Add(new SqlParameter("@text", entity.Text));
            parameters.Add(new SqlParameter("@number", entity.Number));
            parameters.Add(new SqlParameter("@numberlength", entity.NumberLength));
            parameters.Add(new SqlParameter("@active", entity.Active));
            parameters.Add(new SqlParameter("@iduser", entity.IdUser));
            return ExecuteNonQuery(insert);
        }

        public int Edit(Coding entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id", entity.Id));
            parameters.Add(new SqlParameter("@entity", entity.Entity));
            parameters.Add(new SqlParameter("@text", entity.Text));
            parameters.Add(new SqlParameter("@number", entity.Number));
            parameters.Add(new SqlParameter("@numberlength", entity.NumberLength));
            parameters.Add(new SqlParameter("@active", entity.Active));
            parameters.Add(new SqlParameter("@iduser", entity.IdUser));
            return ExecuteNonQuery(update);
        }

        public IEnumerable<Coding> GetAll()
        {
            var tableResult = ExecuteReader(selectAll);
            var listConding = new List<Coding>();
            foreach (DataRow item in tableResult.Rows)
            {
                listConding.Add(new Coding
                {
                    Id = (int)item["Id"],
                    Entity = (string)item["Entity"],
                    Text = (string)item["Text"],
                    Number = (int)item["Number"],
                    NumberLength = (int)item["NumberLength"],
                    Active = (bool)item["Active"],
                    IdUser = (int)item["IdUser"]
                });
            }
            return listConding;
        }

        public int Remove(int id)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id", id));
            return ExecuteNonQuery(delete);
        }
    }
}
