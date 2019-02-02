using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entity = EL;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class User
    {
        public bool Insert(Entity.User user)
        {
            bool State = false;

            try
            {
                string Query = "INSERT INTO [User] (Name, Password, Active, IdUser) VALUES(@name, @password, @active, @iduser)";
                using (SqlCommand Cmd = new SqlCommand(Query))
                {
                    Connect Connection = new Connect();
                    Connection.Open();

                    Cmd.CommandType = CommandType.Text;
                    Cmd.Parameters.AddWithValue("@name", user.Name);
                    Cmd.Parameters.AddWithValue("@password", user.Password);
                    Cmd.Parameters.AddWithValue("@active", user.Active);
                    Cmd.Parameters.AddWithValue("@iduser", user.IdUser);
                    Cmd.Connection = Connection.Cn;

                    Cmd.ExecuteNonQuery();
                    Connection.Close();

                    State = true;
                }
            }
            catch (Exception ex)
            {
                State = false;
                throw ex;
            }
            return State;
        }

        public bool Update(Entity.User user)
        {
            bool State = false;

            try
            {
                string Query = "UPDATE [User] SET Name = @name, Password = @password, Active = @active, IdUser = @iduser WHERE Id = @id";
                using (SqlCommand Cmd = new SqlCommand(Query))
                {
                    Connect Connection = new Connect();
                    Connection.Open();

                    Cmd.CommandType = CommandType.Text;
                    Cmd.Parameters.AddWithValue("@id", user.Id);
                    Cmd.Parameters.AddWithValue("@name", user.Name);
                    Cmd.Parameters.AddWithValue("@password", user.Password);
                    Cmd.Parameters.AddWithValue("@active", user.Active);
                    Cmd.Parameters.AddWithValue("@iduser", user.IdUser);
                    Cmd.Connection = Connection.Cn;

                    Cmd.ExecuteNonQuery();
                    Connection.Close();

                    State = true;
                }
            }
            catch (Exception ex)
            {
                State = false;
                throw ex;
            }
            return State;
        }

        public bool Delete(Entity.User user)
        {
            bool State = false;

            try
            {
                string Query = "DELETE FROM [User] WHERE Id = @id";
                using(SqlCommand Cmd = new SqlCommand(Query))
                {
                    Connect Connection = new Connect();
                    Connection.Open();

                    Cmd.CommandType = CommandType.Text;
                    Cmd.Parameters.AddWithValue("@id", user.Id);
                    Cmd.Connection = Connection.Cn;

                    Cmd.ExecuteNonQuery();
                    Connection.Close();

                    State = true;
                }
            }
            catch (Exception ex)
            {
                State = false;
                throw ex;
            }
            return State;
        }

        public Entity.User ListBy(Entity.User user)
        {
            Entity.User obj = new Entity.User();
            SqlDataReader Dr;

            try
            {
                string Query = "SELECT TOP 1 * FROM [User] WHERE Name = @name AND Password = @password";
                using(SqlCommand Cmd = new SqlCommand(Query))
                {
                    Connect Connection = new Connect();
                    Connection.Open();

                    Cmd.CommandType = CommandType.Text;
                    Cmd.Parameters.AddWithValue("@name", user.Name);
                    Cmd.Parameters.AddWithValue("@password", user.Password);
                    Cmd.Connection = Connection.Cn;

                    Dr = Cmd.ExecuteReader();
                    while (Dr.Read())
                    {
                        Entity.User _user = new Entity.User();
                        _user.Id = Convert.ToInt32(Dr["Id"]);
                        _user.Name = Dr["Name"].ToString();
                        _user.Password = Dr["Password"].ToString();
                        _user.Active = Convert.ToBoolean(Dr["Active"]);

                        obj = _user;
                    }
                    Connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return obj;
        }
    }
}
