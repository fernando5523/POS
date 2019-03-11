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
    public class CategoryModel
    {
        private int id;
        private string code;
        private string description;
        private bool active;
        private int iduser;
        private ICategoryRepository categoryRepository;

        public EntityState State { private get; set; }
        public int Id { get => id; set => id = value; }
        public string Code { get => code; set => code = value; }
        public string Description { get => description; set => description = value; }
        public bool Active { get => active; set => active = value; }
        public int IdUser { get => iduser; set => iduser = value; }

        public CategoryModel()
        {
            categoryRepository = new CategoryRepository();
        }

        public string SaveChanges()
        {
            string message = null;
            try
            {
                var categoryDataModel = new Category();
                categoryDataModel.Id = Id;
                categoryDataModel.Code = Code;
                categoryDataModel.Description = Description;
                categoryDataModel.Active = Active;
                categoryDataModel.IdUser = IdUser;

                switch (State)
                {
                    case EntityState.Added:
                        categoryRepository.Add(categoryDataModel);
                        message = "Registro guardado.";
                        break;
                    case EntityState.Deleted:
                        categoryRepository.Remove(categoryDataModel.Id);
                        message = "Registro eliminado.";
                        break;
                    case EntityState.Modified:
                        categoryRepository.Edit(categoryDataModel);
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

        public List<CategoryModel> GetAll()
        {
            var categoryDataModel = categoryRepository.GetAll();
            var listCategory = new List<CategoryModel>();
            foreach(Category item in categoryDataModel)
            {
                listCategory.Add(new CategoryModel
                {
                    Id = item.Id,
                    Code = item.Code,
                    Description = item.Description,
                    Active = item.Active,
                    IdUser = item.IdUser
                });
            }
            return listCategory;
        }

        public CategoryModel GetId(int id)
        {
            CategoryModel listCategory = null;
            var categoryDataModel = categoryRepository.GetId(id);
            if (categoryDataModel != null)
            {
                listCategory = new CategoryModel();
                listCategory.Id = categoryDataModel.Id;
                listCategory.Code = categoryDataModel.Code;
                listCategory.Description = categoryDataModel.Description;
                listCategory.Active = categoryDataModel.Active;
                listCategory.IdUser = categoryDataModel.IdUser;
            }
            return listCategory;
        }
    }
}
