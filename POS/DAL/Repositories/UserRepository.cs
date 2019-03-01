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
    public class UserRepository : MasterRepository, IUserRepository
    {
        private string selectAll;
        private string selectLogin;
        private string insert;
        private string update;
        private string delete;
        public UserRepository()
        {
            selectAll = "SELECT * FROM [User]";
            selectLogin = "SELECT TOP 1 * FROM [User] WHERE Name = @name AND Password = @password";
            insert = "INSERT INTO [User] VALUES(@name, @password, @active, @iduser)";
            update = "UPDATE [User] SET Name = @name, Password = @password, Active = @active, IdUser = @iduser WHERE Id = @id";
            delete = "DELETE FROM [User] WHERE Id = @id";
        }
        public int Add(User entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@name", entity.Name));
            parameters.Add(new SqlParameter("@password", entity.Password));
            parameters.Add(new SqlParameter("@active", entity.Active));
            parameters.Add(new SqlParameter("@iduser", entity.IdUser));
            return ExecuteNonQuery(insert);
        }

        public int Edit(User entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id", entity.Id));
            parameters.Add(new SqlParameter("@name", entity.Name));
            parameters.Add(new SqlParameter("@password", entity.Password));
            parameters.Add(new SqlParameter("@active", entity.Active));
            parameters.Add(new SqlParameter("@iduser", entity.IdUser));
            return ExecuteNonQuery(update);
        }

        public IEnumerable<User> GetAll()
        {
            var tableResult = ExecuteReader(selectAll);
            var listUser = new List<User>();
            foreach(DataRow item in tableResult.Rows)
            {
                listUser.Add(new User {
                    Id = (int)item["Id"],
                    Name = (string)item["Name"],
                    Password = (string)item["Password"],
                    Active = (bool)item["Active"],
                    IdUser = (int)item["IdUser"]
                });
            }
            return listUser;
        }

        public User GetLogin(string name, string password)
        {
            User login = new User();
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@name",name));
            parameters.Add(new SqlParameter("@password", password));
            var listLogins = ExecuteReader(selectLogin);
            foreach(DataRow item in listLogins.Rows)
            {
                login.Id = (int)item["Id"];
                login.Name = (string)item["Name"];
                login.Password = (string)item["Password"];
                login.Active = (bool)item["Active"];
                login.IdUser = (int)item["IdUser"];
            }
            return login;
        }

        public int Remove(int id)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id", id));
            return ExecuteNonQuery(delete);
        }
    }
}
