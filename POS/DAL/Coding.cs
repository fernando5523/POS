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
    public class Coding
    {
        public bool Insert(Entity.Coding Coding)
        {
            bool State = false;
            try
            {
                string Query = "INSERT INTO [Coding] (Entity, Text, Number, NumberLength, Active, IdUser) VALUES(@entity, @text, @number, @numberlength, @active, @iduser)";
                using(SqlCommand Cmd = new SqlCommand(Query))
                {
                    Connect Connection = new Connect();
                    Cmd.CommandType = CommandType.Text;
                    Cmd.Connection = Connection.Open();
                    Cmd.Parameters.AddWithValue("@entity", Coding.Entity);
                    Cmd.Parameters.AddWithValue("@text", Coding.Text);
                    Cmd.Parameters.AddWithValue("@number", Coding.Number);
                    Cmd.Parameters.AddWithValue("@numberlength", Coding.NumberLength);
                    Cmd.Parameters.AddWithValue("@active", Coding.Active);
                    Cmd.Parameters.AddWithValue("@iduser", Coding.IdUser);
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

        public bool Update(Entity.Coding Coding)
        {
            bool State = false;
            try
            {
                string Query = "UPDATE [Coding] SET Entity = @entity, Text = @text, Number = @number, NumberLength = @numberlength, Active = @active, IdUser = @iduser WHERE Id = @id";
                using (SqlCommand Cmd = new SqlCommand(Query))
                {
                    Connect Connection = new Connect();
                    Cmd.CommandType = CommandType.Text;
                    Cmd.Connection = Connection.Open();
                    Cmd.Parameters.AddWithValue("@id", Coding.Id);
                    Cmd.Parameters.AddWithValue("@entity", Coding.Entity);
                    Cmd.Parameters.AddWithValue("@text", Coding.Text);
                    Cmd.Parameters.AddWithValue("@number", Coding.Number);
                    Cmd.Parameters.AddWithValue("@numberlength", Coding.NumberLength);
                    Cmd.Parameters.AddWithValue("@active", Coding.Active);
                    Cmd.Parameters.AddWithValue("@iduser", Coding.IdUser);
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
                string Query = "DELETE FROM [Coding] WHERE Id = @id";
                using (SqlCommand Cmd = new SqlCommand(Query))
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

        public Entity.Coding GetBy(string Entity)
        {
            Entity.Coding obj = new Entity.Coding();
            SqlDataReader DrResult;

            try
            {
                string Query = "SELECT * FROM [Coding] WHERE Entity = @entity";
                using (SqlCommand Cmd = new SqlCommand(Query))
                {
                    Connect Connection = new Connect();
                    Cmd.CommandType = CommandType.Text;
                    Cmd.Connection = Connection.Open();
                    Cmd.Parameters.AddWithValue("@entity", Entity);
                    DrResult = Cmd.ExecuteReader();

                    while (DrResult.Read())
                    {
                        obj.Id = (int)DrResult["Id"];
                        obj.Entity = (int)DrResult["Entity"];
                        obj.Text = (string)DrResult["Text"];
                        obj.Number = (int)DrResult["Number"];
                        obj.NumberLength = (int)DrResult["NumberLength"];
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

        public string GetNewCode(string Entity)
        {
            string Code = string.Empty;
            try
            {
                Entity.Coding Coding = GetBy(Entity);
                Code = Coding.Text == null ? "" : Coding.Text + Enumerable.Repeat("0", (Coding.NumberLength - Coding.Number.ToString().Length)) + Coding.Number;

                Coding.Number += 1;
                Update(Coding);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Code;
        }
    }
}