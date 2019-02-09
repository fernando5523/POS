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
    public class Container
    {
        public bool Insert(Entity.Container Container)
        {
            bool State = false;
            try
            {
                string Query = "INSERT INTO [Container] (Code, Name, Description, Active, IdUser) VALUES(@code, @name, @description, @active, @iduser)";
                using (SqlCommand Cmd = new SqlCommand(Query))
                {
                    Connect Connection = new Connect();
                    Cmd.CommandType = CommandType.Text;
                    Cmd.Connection = Connection.Open();
                    Cmd.Parameters.AddWithValue("@code", Container.Code);
                    Cmd.Parameters.AddWithValue("@name", Container.Name);
                    Cmd.Parameters.AddWithValue("@description", Container.Description);
                    Cmd.Parameters.AddWithValue("@active", Container.Active);
                    Cmd.Parameters.AddWithValue("@iduser", Container.IdUser);
                    Cmd.ExecuteNonQuery();

                    Connection.Close();
                    State = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return State;
        }

        public bool Update(Entity.Container Container)
        {
            bool State = false;
            try
            {
                string Query = "UPDATE [Container] SET Code = @code, Name = @name, Description = @description, Active = @active, IdUser = @iduser WHERE Id = @id";
                using(SqlCommand Cmd = new SqlCommand(Query))
                {
                    Connect Connection = new Connect();
                    Cmd.CommandType = CommandType.Text;
                    Cmd.Connection = Connection.Open();
                    Cmd.Parameters.AddWithValue("@id", Container.Id);
                    Cmd.Parameters.AddWithValue("@code", Container.Code);
                    Cmd.Parameters.AddWithValue("@name", Container.Name);
                    Cmd.Parameters.AddWithValue("@description", Container.Description);
                    Cmd.Parameters.AddWithValue("@active", Container.Active);
                    Cmd.Parameters.AddWithValue("@iduser", Container.IdUser);
                    Cmd.ExecuteNonQuery();

                    Connection.Close();
                    State = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return State;
        }

        public bool Delete(int Id)
        {
            bool State = false;
            try
            {
                string Query = "DELETE FROM [Container] WHERE Id = @id";
                using(SqlCommand Cmd = new SqlCommand(Query))
                {
                    Connect Connection = new Connect();
                    Cmd.CommandType = CommandType.Text;
                    Cmd.Connection = Connection.Open();
                    Cmd.Parameters.AddWithValue("@id", Id);
                    Cmd.ExecuteNonQuery();

                    Connection.Close();
                    State = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return State;
        }

        public Entity.Container GetBy(string Code)
        {
            Entity.Container obj = new Entity.Container();
            SqlDataReader DrResult;

            try
            {
                string Query = "SELECT * FROM [Container] WHERE Code = @code";
                using (SqlCommand Cmd = new SqlCommand(Query))
                {
                    Connect Connection = new Connect();
                    Cmd.CommandType = CommandType.Text;
                    Cmd.Connection = Connection.Open();
                    Cmd.Parameters.AddWithValue("@code", Code);
                    DrResult = Cmd.ExecuteReader();

                    while (DrResult.Read())
                    {
                        obj.Id = (int)(DrResult["Id"]);
                        obj.Code = (string)DrResult["Code"];
                        obj.Name = (string)DrResult["Name"];
                        obj.Description = (string)DrResult["Description"];
                        obj.Active = (bool)DrResult["Active"];
                        obj.IdUser = (int)DrResult["IdUser"];
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