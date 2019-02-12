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
    public class Consult
    {
        public bool Insert(Entity.Consult Consult)
        {
            bool State = false;

            try
            {
                string Query = "INSERT INTO [Consult] (IdContainer, Principal, [Select], [From], [Where], [GroupBy], [Having], [OrderBy], IdUser) VALUES(@idcontainer, @principal, @select, @from, @where, @groupby, @having, @orderby, @iduser)";
                using(SqlCommand Cmd = new SqlCommand(Query))
                {
                    Connect Connection = new Connect();
                    Cmd.CommandType = CommandType.Text;
                    Cmd.Connection = Connection.Open();
                    Cmd.Parameters.AddWithValue("@idcontainer", Consult.IdContainer);
                    Cmd.Parameters.AddWithValue("@principal", Consult.Principal);
                    Cmd.Parameters.AddWithValue("@select", Consult.Select);
                    Cmd.Parameters.AddWithValue("@from", Consult.From);
                    Cmd.Parameters.AddWithValue("@where", Consult.Where);
                    Cmd.Parameters.AddWithValue("@groupby", Consult.GroupBy);
                    Cmd.Parameters.AddWithValue("@having", Consult.Having);
                    Cmd.Parameters.AddWithValue("@orderby", Consult.OrderBy);
                    Cmd.Parameters.AddWithValue("@iduser", Consult.IdUser);
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
        public bool Update(Entity.Consult Consult)
        {
            bool State = false;

            try
            {
                string Query = "UPDATE [Consult] SET IdContainer = @idcontainer, Principal = @principal, [Select] = @select, [From] = @from, [Where] = @where, [GroupBy] = @groupby, [Having] = @having, [OrderBy] = @orderby, IdUser = @iduser WHERE Id = @id";
                using (SqlCommand Cmd = new SqlCommand(Query))
                {
                    Connect Connection = new Connect();
                    Cmd.CommandType = CommandType.Text;
                    Cmd.Connection = Connection.Open();
                    Cmd.Parameters.AddWithValue("@id", Consult.Id);
                    Cmd.Parameters.AddWithValue("@idcontainer", Consult.IdContainer);
                    Cmd.Parameters.AddWithValue("@principal", Consult.Principal);
                    Cmd.Parameters.AddWithValue("@select", Consult.Select);
                    Cmd.Parameters.AddWithValue("@from", Consult.From);
                    Cmd.Parameters.AddWithValue("@where", Consult.Where);
                    Cmd.Parameters.AddWithValue("@groupby", Consult.GroupBy);
                    Cmd.Parameters.AddWithValue("@having", Consult.Having);
                    Cmd.Parameters.AddWithValue("@orderby", Consult.OrderBy);
                    Cmd.Parameters.AddWithValue("@iduser", Consult.IdUser);
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
                string Query = "DELETE FROM [Consult] WHERE Id = @id";
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
        public Entity.Consult GetBy(int IdContainer)
        {
            Entity.Consult Consult = new Entity.Consult();
            SqlDataReader DrResult;

            try
            {
                string Query = "SELECT * FROM Consult WHERE IdContainer = @idcontainer AND Principal = 1";
                using(SqlCommand Cmd = new SqlCommand(Query))
                {
                    Connect Connection = new Connect();
                    Cmd.CommandType = CommandType.Text;
                    Cmd.Connection = Connection.Open();
                    Cmd.Parameters.AddWithValue("@idcontainer", IdContainer);
                    DrResult = Cmd.ExecuteReader();

                    if (DrResult.Read())
                    {
                        Consult.Id = Convert.ToInt32(DrResult["Id"]);
                        Consult.IdContainer = Convert.ToInt32(DrResult["IdContainer"]);
                        Consult.Principal = Convert.ToBoolean(DrResult["Principal"]);
                        Consult.Select = DrResult["Select"].ToString();
                        Consult.From = DrResult["From"].ToString();
                        Consult.Where = DrResult["Where"].ToString();
                        Consult.GroupBy = DrResult["GroupBy"].ToString();
                        Consult.Having = DrResult["Having"].ToString();
                        Consult.OrderBy = DrResult["OrderBy"].ToString();
                        Consult.IdUser = Convert.ToInt32(DrResult["IdUser"]);
                    }

                    Connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Consult;
        }
        public DataTable GetView(int IdContainer, string Condition = "")
        {
            DataTable DtResult = new DataTable();
            Entity.Consult Consult = GetBy(IdContainer);
            SqlDataReader DrResult;

            try
            {
                string Where = "";
                if(Consult.Where == "" && Condition != "")
                    Where = " WHERE " + Condition;
                if(Consult.Where != "" && Condition != "")
                    Where = Consult.Where + " AND " + Condition;

                string Query = Consult.Select + " " + Consult.From + Where + (Consult.GroupBy == null ? "" : " " + Consult.GroupBy) + (Consult.Having == null ? "" : " " + Consult.Having) + (Consult.OrderBy == null ? "" : " " + Consult.OrderBy);
                
                using(SqlCommand Cmd = new SqlCommand(Query))
                {
                    Connect Connection = new Connect();
                    Cmd.CommandType = CommandType.Text;
                    Cmd.Connection = Connection.Open();
                    DrResult = Cmd.ExecuteReader();

                    DtResult.Load(DrResult);
                    Connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return DtResult;
        }
    }
}
