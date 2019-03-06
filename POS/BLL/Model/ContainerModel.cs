using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Contracts;
using DAL.Entities;
using DAL.Repositories;
using BLL.ValueObjects;
using System.Data.SqlClient;

namespace BLL.Model
{
    public class ContainerModel
    {
        private int id;
        private string code;
        private string name;
        private string description;
        private bool active;
        private int iduser;
        private IContainerRepository containerRepository;

        public EntityState State { private get; set; }
        public int Id { get => id; set => id = value; }
        public string Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public bool Active { get => active; set => active = value; }
        public int IdUser { get => iduser; set => iduser = value; }

        public ContainerModel()
        {
            containerRepository = new ContainerRepository();
        }

        public string SaveChanges()
        {
            string message = null;
            try
            {
                var containerModel = new Container();
                containerModel.Id = Id;
                containerModel.Code = Code;
                containerModel.Name = Name;
                containerModel.Description = Description;
                containerModel.Active = Active;
                containerModel.IdUser = IdUser;
                switch (State)
                {
                    case EntityState.Added:
                        containerRepository.Add(containerModel);
                        message = "Registro guardado.";
                        break;
                    case EntityState.Deleted:
                        containerRepository.Remove(containerModel.Id);
                        message = "Registro eliminado.";
                        break;
                    case EntityState.Modified:
                        containerRepository.Edit(containerModel);
                        message = "Registro modificado.";
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                SqlException sqlEx = ex as SqlException;
                if (sqlEx != null && sqlEx.Number == 2627)
                    message = "Registro duplicado.";
                else
                    message = ex.ToString();
            }
            return message;
        }

        public List<ContainerModel> GetAll()
        {
            var containerDataModel = containerRepository.GetAll();
            var listContainer = new List<ContainerModel>();
            foreach (Container item in containerDataModel)
            {
                listContainer.Add(new ContainerModel
                {
                    Id = item.Id,
                    Code = item.Code,
                    Name = item.Name,
                    Description = item.Description,
                    Active = item.Active,
                    IdUser = item.IdUser
                });
            }
            return listContainer;
        }

        public ContainerModel GetContainerName(string name)
        {
            var containerDataModel = containerRepository.GetContainerName(name);
            ContainerModel listContainer = new ContainerModel();
            listContainer.Id = containerDataModel.Id;
            listContainer.Name = containerDataModel.Name;
            listContainer.Description = containerDataModel.Description;

            return listContainer;
        }
    }
}
