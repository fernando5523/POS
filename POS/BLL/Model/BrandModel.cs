using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Model
{
    using DAL.Contracts;
    using DAL.Repositories;
    using DAL.Entities;
    using BLL.ValueObjects;
    using System.Data.SqlClient;
    public class BrandModel
    {
        private int id;
        private string code;
        private string description;
        private bool active;
        private int iduser;

        private IBrandRepository brandRepository;
        public EntityState State { private get; set; }
        public int Id { get => id; set => id = value; }
        public string Code { get => code; set => code = value; }
        public string Description { get => description; set => description = value; }
        public bool Active { get => active; set => active = value; }
        public int IdUser { get => iduser; set => iduser = value; }

        public BrandModel()
        {
            brandRepository = new BrandRepository();
        }

        public string SaveChanges()
        {
            string message = null;
            try
            {
                var brandDataModel = new Brand();
                brandDataModel.ID = Id;
                brandDataModel.Code = Code;
                brandDataModel.Description = Description;
                brandDataModel.Active = Active;
                brandDataModel.IdUser = IdUser;

                switch (State)
                {
                    case EntityState.Added:
                        brandRepository.Add(brandDataModel);
                        message = "Registro guardado.";
                        break;
                    case EntityState.Deleted:
                        brandRepository.Remove(brandDataModel);
                        message = "Registro eliminado.";
                        break;
                    case EntityState.Modified:
                        brandRepository.Edit(brandDataModel);
                        message = "Registro modificado.";
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                //Excepciones SQL Server
                SqlException sqlEx = ex as SqlException;
                if (sqlEx != null && sqlEx.Number == 2627)
                    message = "Registro duplicado.";
                else
                    message = ex.ToString();
            }
            return message;
        }

        public List<BrandModel> GetAll()
        {
            var brandDataModel = brandRepository.GetAll();
            var listBrand = new List<BrandModel>();
            foreach(Brand item in brandDataModel)
            {
                listBrand.Add(new BrandModel
                {
                    Id = item.ID,
                    Code = item.Code,
                    Description = item.Description,
                    Active = item.Active,
                    IdUser = item.IdUser
                });
            }
            return listBrand;
        }

        public BrandModel GetId(int id)
        {
            BrandModel listBrand = null;
            var brandDataModel = brandRepository.Find(e => e.ID == id).FirstOrDefault();
            if (brandDataModel != null)
            {
                listBrand = new BrandModel();
                listBrand.Id = brandDataModel.ID;
                listBrand.Code = brandDataModel.Code;
                listBrand.Description = brandDataModel.Description;
                listBrand.Active = brandDataModel.Active;
                listBrand.IdUser = brandDataModel.IdUser;
            }
            return listBrand;
        }
    }
}
