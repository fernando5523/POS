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
    public class Filter
    {
        public bool Insert(Entity.Filter Filter)
        {
            bool State = false;

            try
            {
                string Query = "INSERT INTO [Filter] (Id, IdUser, IdConsult, Condition) VALUES(@id, @iduser, @idconsult, @condition)";
                using(SqlCommand Cmd = new SqlCommand(Query))
                {
                    Connect Connection = new Connect();
                    Cmd.CommandType = CommandType.Text;
                    Cmd.Connection = Connection.Open();
                    Cmd.Parameters.AddWithValue("@id", Filter.Id);
                    Cmd.Parameters.AddWithValue("@iduser", Filter.IdUser);
                    Cmd.Parameters.AddWithValue("@idconsult", Filter.IdConsult);
                    Cmd.Parameters.AddWithValue("@condition", Filter.Condition);
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

        public bool Update(Entity.Filter Filter)
        {
            bool State = false;

            try
            {
                string Query = "UPDATE [Filter] SET IdUser = @iduser, IdConsult = @idconsult, Condition = @condition WHERE Id = @id";
                using (SqlCommand Cmd = new SqlCommand(Query))
                {
                    Connect Connection = new Connect();
                    Cmd.CommandType = CommandType.Text;
                    Cmd.Connection = Connection.Open();
                    Cmd.Parameters.AddWithValue("@id", Filter.Id);
                    Cmd.Parameters.AddWithValue("@iduser", Filter.IdUser);
                    Cmd.Parameters.AddWithValue("@idconsult", Filter.IdConsult);
                    Cmd.Parameters.AddWithValue("@condition", Filter.Condition);
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

        public bool Delete(Entity.Filter Filter)
        {
            bool State = false;

            try
            {
                string Query = "DELETE FROM [Filter] WHERE Id = @id";
                using (SqlCommand Cmd = new SqlCommand(Query))
                {
                    Connect Connection = new Connect();
                    Cmd.CommandType = CommandType.Text;
                    Cmd.Connection = Connection.Open();
                    Cmd.Parameters.AddWithValue("@id", Filter.Id);
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

        public Entity.Filter GetBy(int IdConsult)
        {
            Entity.Filter obj = new Entity.Filter();
            SqlDataReader DrResult;

            try
            {
                string Query = "SELECT * FROM [Filter] WHERE Id = @id";
                using(SqlCommand Cmd = new SqlCommand(Query))
                {
                    Connect Connection = new Connect();
                    Cmd.CommandType = CommandType.Text;
                    Cmd.Connection = Connection.Open();
                    Cmd.Parameters.AddWithValue("@id", IdConsult);
                    DrResult = Cmd.ExecuteReader();

                    while (DrResult.Read())
                    {
                        obj.Id = (int)DrResult["Id"];
                        obj.IdUser = (int)DrResult["IdUser"];
                        obj.IdConsult = (int)DrResult["IdConsult"];
                        obj.Condition = (string)DrResult["Condition"];
                    }
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
