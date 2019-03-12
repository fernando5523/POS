﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Model
{
    using System.Data.SqlClient;
    using DAL.Contracts;
    using DAL.Entities;
    using DAL.Repositories;
    using BLL.ValueObjects;
    public class UnitTemplateModel
    {
        private int id;
        private string code;
        private string name;
        private string abbreviation;
        private int factor;
        private string description;
        private int iduser;
        private DBContext db;
        private IUnitTemplateRepository gRepository;

        public EntityState State { private get; set; }
        public int Id { get => id; set => id = value; }
        public string Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        public string Abbreviation { get => abbreviation; set => abbreviation = value; }
        public int Factor { get => factor; set => factor = value; }
        public string Description { get => description; set => description = value; }
        public int IdUser { get => iduser; set => iduser = value; }

        public UnitTemplateModel()
        {
            db = new DBContext();
            gRepository = new UnitTemplateRepository(db);
        }

        public string SaveChanges()
        {
            string message = null;
            try
            {
                var unittemplateDataModel = new UnitTemplate();
                unittemplateDataModel.Id = Id;
                unittemplateDataModel.Code = Code;
                unittemplateDataModel.Name = Name;
                unittemplateDataModel.Abbreviation = Abbreviation;
                unittemplateDataModel.Factor = Factor;
                unittemplateDataModel.Description = Description;
                unittemplateDataModel.IdUser = IdUser;
                switch (State)
                {
                    case EntityState.Added:
                        gRepository.Add(unittemplateDataModel);
                        message = "Registro guardado.";
                        break;
                    case EntityState.Deleted:
                        gRepository.Delete(unittemplateDataModel);
                        message = "Registro eliminado.";
                        break;
                    case EntityState.Modified:
                        gRepository.Edit(unittemplateDataModel);
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

        public List<UnitTemplateModel> GetAll()
        {
            var unittemplateDataModel = gRepository.GetAll();
            var listUnitTemplate = new List<UnitTemplateModel>();
            foreach(UnitTemplate item in unittemplateDataModel)
            {
                listUnitTemplate.Add(new UnitTemplateModel
                {
                    Id = item.Id,
                    Code = item.Code,
                    Name = item.Name,
                    Abbreviation = item.Abbreviation,
                    Factor = item.Factor,
                    Description = item.Description,
                    IdUser = item.IdUser
                });
            }
            return listUnitTemplate;
        }
    }
}
