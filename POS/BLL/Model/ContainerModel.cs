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
        private int? idcontainer;
        private int? idimage;
        private string code;
        private string name;
        private string description;
        private int level;
        private string form;
        private int sort;
        private bool isview;
        private bool active;
        private int iduser;
        private IContainerRepository containerRepository;

        public EntityState State { private get; set; }
        public int Id { get => id; set => id = value; }
        public int? IdContainer { get => idcontainer; set => idcontainer = value; }
        public int? IdImage { get => idimage; set => idimage = value; }
        public string Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public int Level { get => level; set => level = value; }
        public string Form { get => form; set => form = value; }
        public int Sort { get => sort; set => sort = value; }
        public bool IsView { get => isview; set => isview = value; }
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
                containerModel.ID = Id;
                containerModel.IdContainer = IdContainer;
                containerModel.IdImage = IdImage;
                containerModel.Code = Code;
                containerModel.Name = Name;
                containerModel.Description = Description;
                containerModel.Level = Level;
                containerModel.Form = Form;
                containerModel.Sort = Sort;
                containerModel.IsView = IsView;
                containerModel.Active = Active;
                containerModel.IdUser = IdUser;

                switch (State)
                {
                    case EntityState.Added:
                        containerRepository.Add(containerModel);
                        message = "Registro guardado.";
                        break;
                    case EntityState.Deleted:
                        containerRepository.Remove(containerModel);
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
                    Id = item.ID,
                    IdContainer = item.IdContainer,
                    IdImage = item.IdImage,
                    Code = item.Code,
                    Name = item.Name,
                    Description = item.Description,
                    Level = item.Level,
                    Form = item.Form,
                    Sort = item.Sort,
                    IsView = item.IsView,
                    Active = item.Active,
                    IdUser = item.IdUser
                });
            }
            return listContainer;
        }

        public ContainerModel GetContainerName(string name)
        {
            ContainerModel listContainer = null; 
            var containerDataModel = containerRepository.Find(e => e.Name == name).FirstOrDefault();
            if (containerDataModel != null)
            {
                listContainer = new ContainerModel();
                listContainer.Id = containerDataModel.ID;
                listContainer.IdContainer = containerDataModel.IdContainer;
                listContainer.IdImage = containerDataModel.IdImage;
                listContainer.Code = containerDataModel.Code;
                listContainer.Name = containerDataModel.Name;
                listContainer.Description = containerDataModel.Description;
                listContainer.Level = containerDataModel.Level;
                listContainer.Form = containerDataModel.Form;
                listContainer.sort = containerDataModel.Sort;
                listContainer.IsView = containerDataModel.IsView;
                listContainer.Active = containerDataModel.Active;
                listContainer.IdUser = containerDataModel.IdUser;
            }
            return listContainer;
        }

        public List<ContainerModel> GetContainerModule()
        {
            List<ContainerModel> listContainer = null;
            var containerDataModel = containerRepository.Find(e => e.Active == true && e.IsView == false && e.Level == 0).OrderByDescending(e => e.Sort);
            if (containerDataModel != null)
            {
                listContainer = new List<ContainerModel>();
                foreach(Container item in containerDataModel)
                {
                    listContainer.Add(new ContainerModel
                    {
                        Id = item.ID,
                        IdContainer = item.IdContainer,
                        IdImage = item.IdImage,
                        Code = item.Code,
                        Name = item.Name,
                        Description = item.Description,
                        Level = item.Level,
                        Form = item.Form,
                        Sort = item.Sort,
                        IsView = item.IsView,
                        Active = item.Active,
                        IdUser = item.IdUser
                    });
                }
            }
            return listContainer;
        }
    }
}
