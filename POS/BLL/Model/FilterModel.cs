﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Contracts;
using DAL.Entities;
using DAL.Repositories;
using BLL.ValueObjects;
using System.Data;
using System.Data.SqlClient;

namespace BLL.Model
{
    public class FilterModel
    {
        private int id;
        private int iduser;
        private int idconsult;
        private string condition;
        private string conditiondev;
        private IFilterRepository filterRepository;

        public EntityState State { private get; set; }
        public int Id { get => id; set => id = value; }
        public int IdUser { get => iduser; set => iduser = value; }
        public int IdConsult { get => idconsult; set => idconsult = value; }
        public string Condition { get => condition; set => condition = value; }
        public string ConditionDev { get => conditiondev; set => conditiondev = value; }

        public FilterModel()
        {
            filterRepository = new FilterRepository();
        }

        public string SaveChanges()
        {
            string message = null;
            try
            {
                var filterDataModel = new Filter();
                filterDataModel.Id = Id;
                filterDataModel.IdUser = IdUser;
                filterDataModel.IdConsult = IdConsult;
                filterDataModel.Condition = Condition;
                filterDataModel.ConditionDev = ConditionDev;

                switch (State)
                {
                    case EntityState.Added:
                        filterRepository.Add(filterDataModel);
                        message = "Registro guardado.";
                        break;
                    case EntityState.Deleted:
                        filterRepository.Remove(filterDataModel.Id);
                        message = "Registro eliminado.";
                        break;
                    case EntityState.Modified:
                        filterRepository.Edit(filterDataModel);
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

        public List<FilterModel> GetAll()
        {
            var filterDataModel = filterRepository.GetAll();
            var listFilter = new List<FilterModel>();
            foreach(Filter item in filterDataModel)
            {
                listFilter.Add(new FilterModel
                {
                    Id = item.Id,
                    IdUser = item.IdUser,
                    IdConsult = item.IdConsult,
                    Condition = item.Condition,
                    ConditionDev = item.ConditionDev
                });
            }
            return listFilter;
        }

        public FilterModel GetUser(int iduser, int idconsult)
        {
            var filterDataModel = filterRepository.GetUser(iduser, idconsult);
            var listFilter = new FilterModel();
            listFilter.Id = filterDataModel.Id;
            listFilter.iduser = filterDataModel.IdUser;
            listFilter.IdConsult = filterDataModel.IdConsult;
            listFilter.Condition = filterDataModel.Condition;
            listFilter.ConditionDev = filterDataModel.ConditionDev;
            return listFilter;
        }

        public DataTable Execute(string transactSql)
        {
            return filterRepository.Execute(transactSql);
        }
    }
}