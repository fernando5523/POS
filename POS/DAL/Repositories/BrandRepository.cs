using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    using System.Data;
    using System.Data.SqlClient;
    using DAL.Contracts;
    using DAL.Entities;
    public class BrandRepository : MasterRepository, IBrandRepository
    {
        private string selectAll;
        private string selectId;
        private string insert;
        private string update;
        private string delete;

        public BrandRepository()
        {
            this.selectAll = "SELECT * FROM [Brand]";
            this.selectId = "SELECT * FROM [Brand] WHERE Id = @id";
            this.insert = "INSERT INTO [Brand] VALUES(@code, @description, @active, @iduser)";
            this.update = "UPDATE [Brand] SET Code = @code, Description = @description, Active = @active, IdUser = @iduser WHERE Id = @id";
            this.delete = "DELETE FROM [Brand] WHERE Id = @id";
        }
        public int Add(Brand entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@code", entity.Code));
            parameters.Add(new SqlParameter("@description", entity.Description));
            parameters.Add(new SqlParameter("@active", entity.Active));
            parameters.Add(new SqlParameter("@iduser", entity.IdUser));
            return ExecuteNonQuery(insert);
        }

        public int Edit(Brand entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id", entity.Id));
            parameters.Add(new SqlParameter("@code", entity.Code));
            parameters.Add(new SqlParameter("@description", entity.Description));
            parameters.Add(new SqlParameter("@active", entity.Active));
            parameters.Add(new SqlParameter("@iduser", entity.IdUser));
            return ExecuteNonQuery(update);
        }

        public IEnumerable<Brand> GetAll()
        {
            var tableResult = ExecuteReader(selectAll);
            var listBrand = new List<Brand>();
            foreach(DataRow item in tableResult.Rows)
            {
                listBrand.Add(new Brand
                {
                    Id = (int)item["Id"],
                    Code = item["Code"].ToString(),
                    Description = item["Description"].ToString(),
                    Active = (bool)item["Active"],
                    IdUser = (int)item["IdUser"]
                });
            }
            return listBrand;
        }

        public Brand GetId(int id)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id", id));
            var tableResult = ExecuteReader(selectId);
            var listBrand = new Brand();
            foreach(DataRow item in tableResult.Rows)
            {
                listBrand.Id = (int)item["Id"];
                listBrand.Code = item["Code"].ToString();
                listBrand.Description = item["Description"].ToString();
                listBrand.Active = (bool)item["Active"];
                listBrand.IdUser = (int)item["IdUser"];
            }
            return listBrand;
        }

        public int Remove(int id)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id", id));
            return ExecuteNonQuery(delete);
        }
    }
}
