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
    public class ConsultModel
    {
        private int id;
        private int idcontainer;
        private bool principal;
        private string select;
        private string from;
        private string where;
        private string groupby;
        private string having;
        private string orderby;
        private Nullable<int> iduser;
        private IConsultRepository consultRepository;

        public EntityState State { private get; set; }
        public int Id { get => id; set => id = value; }
        public int IdContainer { get => idcontainer; set => idcontainer = value; }
        public bool Principal { get => principal; set => principal = value; }
        public string Select { get => select; set => select = value; }
        public string From { get => from; set => from = value; }
        public string Where { get => where; set => where = value; }
        public string GroupBy { get => groupby; set => groupby = value; }
        public string Having { get => having; set => having = value; }
        public string OrderBy { get => orderby; set => orderby = value; }
        public int? IdUser { get => iduser; set => iduser = value; }

        public ConsultModel()
        {
            consultRepository = new ConsultRepository();
        }

        public string SaveChanges()
        {
            string message = null;
            try
            {
                var consultDataModel = new Consult();
                consultDataModel.Id = Id;
                consultDataModel.IdContainer = IdContainer;
                consultDataModel.Principal = Principal;
                consultDataModel.Select = Select;
                consultDataModel.From = From;
                consultDataModel.Where = Where;
                consultDataModel.GroupBy = GroupBy;
                consultDataModel.Having = Having;
                consultDataModel.OrderBy = OrderBy;
                consultDataModel.IdUser = IdUser;

                switch (State)
                {
                    case EntityState.Added:
                        consultRepository.Add(consultDataModel);
                        message = "Registro guardado.";
                        break;
                    case EntityState.Deleted:
                        consultRepository.Remove(consultDataModel.Id);
                        message = "Registro eliminado.";
                        break;
                    case EntityState.Modified:
                        consultRepository.Edit(consultDataModel);
                        message = "Registro modificado.";
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                SqlException sqlEx = ex as SqlException;
                if(sqlEx != null && sqlEx.Number == 2627)
                    message = "Registro duplicado.";
                else
                    message = ex.ToString();
            }
            return message;
        }

        public List<ConsultModel> GetAll()
        {
            var consultDataModel = consultRepository.GetAll();
            var listConsult = new List<ConsultModel>();
            foreach(Consult item in consultDataModel)
            {
                listConsult.Add(new ConsultModel
                {
                    Id = item.Id,
                    IdContainer = item.IdContainer,
                    Principal = item.Principal,
                    Select = item.Select,
                    From = item.From,
                    Where = item.Where,
                    GroupBy = item.GroupBy,
                    Having = item.Having,
                    OrderBy = item.OrderBy,
                    IdUser = item.IdUser
                });
            }
            return listConsult;
        }

        public ConsultModel GetIdContainer(int idContainer)
        {
            var consultDataModel = consultRepository.GetIdContainer(idContainer);
            var listConsult = new ConsultModel();
            listConsult.Id = consultDataModel.Id;
            listConsult.IdContainer = consultDataModel.IdContainer;
            listConsult.Principal = consultDataModel.Principal;
            listConsult.Select = consultDataModel.Select;
            listConsult.From = consultDataModel.From;
            listConsult.Where = consultDataModel.Where;
            listConsult.GroupBy = consultDataModel.GroupBy;
            listConsult.Having = consultDataModel.Having;
            listConsult.OrderBy = consultDataModel.OrderBy;
            listConsult.IdUser = consultDataModel.IdUser;

            return listConsult;
        }
    }
}
