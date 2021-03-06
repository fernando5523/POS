﻿using System;
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
        private int containerid;
        private bool principal;
        private string select;
        private string from;
        private string where;
        private string groupby;
        private string having;
        private string orderby;
        private int userid;
        private IConsultRepository consultRepository;

        public EntityState State { private get; set; }
        public int Id { get => id; set => id = value; }
        public int ContainerID { get => containerid; set => containerid = value; }
        public bool Principal { get => principal; set => principal = value; }
        public string Select { get => select; set => select = value; }
        public string From { get => from; set => from = value; }
        public string Where { get => where; set => where = value; }
        public string GroupBy { get => groupby; set => groupby = value; }
        public string Having { get => having; set => having = value; }
        public string OrderBy { get => orderby; set => orderby = value; }
        public int UserID { get => userid; set => userid = value; }

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
                consultDataModel.ID = Id;
                consultDataModel.ContainerID = ContainerID;
                consultDataModel.Principal = Principal;
                consultDataModel.Select = Select;
                consultDataModel.From = From;
                consultDataModel.Where = Where;
                consultDataModel.GroupBy = GroupBy;
                consultDataModel.Having = Having;
                consultDataModel.OrderBy = OrderBy;
                consultDataModel.UserID = UserID;

                switch (State)
                {
                    case EntityState.Added:
                        consultRepository.Add(consultDataModel);
                        message = "Registro guardado.";
                        break;
                    case EntityState.Deleted:
                        consultRepository.Remove(consultDataModel);
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
                    Id = item.ID,
                    ContainerID = item.ContainerID,
                    Principal = item.Principal,
                    Select = item.Select,
                    From = item.From,
                    Where = item.Where,
                    GroupBy = item.GroupBy,
                    Having = item.Having,
                    OrderBy = item.OrderBy,
                    UserID = item.UserID
                });
            }
            return listConsult;
        }

        public ConsultModel GetIdContainer(int idContainer)
        {
            ConsultModel listConsult = null;
            var consultDataModel = consultRepository.Find(e => e.ContainerID == idContainer).FirstOrDefault();
            if (consultDataModel != null)
            {
                listConsult = new ConsultModel();
                listConsult.Id = consultDataModel.ID;
                listConsult.ContainerID = consultDataModel.ContainerID;
                listConsult.Principal = consultDataModel.Principal;
                listConsult.Select = consultDataModel.Select;
                listConsult.From = consultDataModel.From;
                listConsult.Where = consultDataModel.Where;
                listConsult.GroupBy = consultDataModel.GroupBy;
                listConsult.Having = consultDataModel.Having;
                listConsult.OrderBy = consultDataModel.OrderBy;
                listConsult.UserID = consultDataModel.UserID;
            }
            return listConsult;
        }
    }
}
