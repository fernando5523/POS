using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Model
{
    using DAL.Entities;
    using DAL.Contracts;
    using DAL.Repositories;
    using BLL.ValueObjects;
    using System.Data.SqlClient;

    public class ImageModel
    {
        private int id;
        private string name;
        private string chain;
        private IImageRepository imageRepository;

        public EntityState State { private get; set; }
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Chain { get => chain; set => chain = value; }

        public ImageModel()
        {
            imageRepository = new ImageRepository();
        }

        public string SaveChanges()
        {
            string message = null;
            try
            {
                var imageDataModel = new Image();
                imageDataModel.ID = Id;
                imageDataModel.Name = Name;
                imageDataModel.Chain = Chain;

                switch (State)
                {
                    case EntityState.Added:
                        //Ejecutar reglas comerciales / calculos
                        imageRepository.Add(imageDataModel);
                        message = "Registro guardado.";
                        break;
                    case EntityState.Deleted:
                        imageRepository.Remove(imageDataModel);
                        message = "Registro eliminado.";
                        break;
                    case EntityState.Modified:
                        imageRepository.Edit(imageDataModel);
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

        public List<ImageModel> GetAll()
        {
            var imageDataModel = imageRepository.GetAll();
            var listImages = new List<ImageModel>();
            foreach (Image item in imageDataModel)
            {
                listImages.Add(new ImageModel
                {
                    Id = item.ID,
                    Name = item.Name,
                    Chain = item.Chain
                });
            }
            return listImages;
        }

        public ImageModel GetId(int id)
        {
            ImageModel objects = null;
            var userDataModel = imageRepository.Find(e => e.ID == id).FirstOrDefault();
            if (userDataModel != null)
            {
                objects = new ImageModel();
                objects.Id = userDataModel.ID;
                objects.name = userDataModel.Name;
                objects.Chain = userDataModel.Chain;
            }
            return objects;
        }
    }
}
