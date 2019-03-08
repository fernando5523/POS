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
    public class ContainerRepository : MasterRepository, IContainerRepository
    {
        private string selectAll;
        private string selectContainer;
        private string insert;
        private string update;
        private string delete;
        public ContainerRepository()
        {
            selectAll = "SELECT * FROM [Container]";
            selectContainer = "SELECT Id, Name, Description, Form FROM [Container] WHERE Name = @name";
            insert = "INSERT INTO [Container] VALUES(@code, @name, @description, @form, @active, @iduser)";
            update = "UPDATE [Container] SET Code = @code, Name = @name, Description = @description, Form = @form, Active = @active, IdUser = @iduser WHERE Id = @id";
            delete = "DELETE FROM [Container] WHERE Id = @id";
        }
        public int Add(Container entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@code", entity.Code));
            parameters.Add(new SqlParameter("@name", entity.Name));
            parameters.Add(new SqlParameter("@description", entity.Description));
            parameters.Add(new SqlParameter("@form", entity.Description));
            parameters.Add(new SqlParameter("@active", entity.Active));
            parameters.Add(new SqlParameter("@iduser", entity.IdUser));
            return ExecuteNonQuery(insert);
        }

        public int Edit(Container entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id", entity.Id));
            parameters.Add(new SqlParameter("@code", entity.Code));
            parameters.Add(new SqlParameter("@name", entity.Name));
            parameters.Add(new SqlParameter("@description", entity.Description));
            parameters.Add(new SqlParameter("@form", entity.Description));
            parameters.Add(new SqlParameter("@active", entity.Active));
            parameters.Add(new SqlParameter("@iduser", entity.IdUser));
            return ExecuteNonQuery(update);
        }

        public IEnumerable<Container> GetAll()
        {
            var tableResult = ExecuteReader(selectAll);
            var listContainer= new List<Container>();
            foreach (DataRow item in tableResult.Rows)
            {
                listContainer.Add(new Container
                {
                    Id = (int)item["Id"],
                    Code = (string)item["Code"],
                    Name = (string)item["Name"],
                    Description = (string)item["Description"],
                    Form = (string)item["Form"],
                    Active = (bool)item["Active"],
                    IdUser = (int)item["IdUser"]
                });
            }
            return listContainer;
        }

        public Container GetContainerName(string name)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@name", name));
            var tableResult = ExecuteReader(selectContainer);
            var listContainer = new Container();
            foreach(DataRow item in tableResult.Rows)
            {
                listContainer.Id = (int)item["Id"];
                listContainer.Name = (string)item["Name"];
                listContainer.Description = (string)item["Description"];
                listContainer.Form = (string)item["Form"];
            }
            return listContainer;
        }

        public int Remove(int id)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id", id));
            return ExecuteNonQuery(delete);
        }
    }
}
