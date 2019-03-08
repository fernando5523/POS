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
    public class CodingModel
    {
        private int id;
        private string entity;
        private string text;
        private int number;
        private int numberlength;
        private bool active;
        private int iduser;
        private ICodingRepository codingRepository;

        public EntityState State { private get; set; }
        public int Id { get => id; set => id = value; }
        public string Entity { get => entity; set => entity = value; }
        public string Text { get => text; set => text = value; }
        public int Number { get => number; set => number = value; }
        public int Numberlength { get => numberlength; set => numberlength = value; }
        public bool Active { get => active; set => active = value; }
        public int IdUser { get => iduser; set => iduser = value; }

        public CodingModel()
        {
            codingRepository = new CodingRepository();
        }

        public string SaveChanges()
        {
            string message = null;
            try
            {
                var codingDataModel = new Coding();
                codingDataModel.Id = Id;
                codingDataModel.Entity = Entity;
                codingDataModel.Text = Text;
                codingDataModel.Number = Number;
                codingDataModel.NumberLength = Numberlength;
                codingDataModel.Active = Active;
                codingDataModel.IdUser = IdUser;

                switch (State)
                {
                    case EntityState.Added:
                        codingRepository.Add(codingDataModel);
                        message = "Registro guardado.";
                        break;
                    case EntityState.Deleted:
                        codingRepository.Remove(codingDataModel.Id);
                        message = "Registro eliminado.";
                        break;
                    case EntityState.Modified:
                        codingRepository.Edit(codingDataModel);
                        message = "Registro eliminado.";
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

        public List<CodingModel> GetAll()
        {
            var codingDataModel = codingRepository.GetAll();
            var listCoding = new List<CodingModel>();
            foreach (Coding item in codingDataModel)
            {
                listCoding.Add(new CodingModel
                {
                    Id = item.Id,
                    Entity = item.Entity,
                    Text = item.Text,
                    Number = item.Number,
                    Numberlength = item.NumberLength,
                    Active = item.Active,
                    IdUser = item.IdUser
                });
            }
            return listCoding;
        }

        public CodingModel GetEntity(string entity)
        {
            var codingDataModel = codingRepository.GetEntity(entity);
            var listCoding = new CodingModel();
            listCoding.Id = codingDataModel.Id;
            listCoding.Entity = codingDataModel.Entity;
            listCoding.Text = codingDataModel.Text;
            listCoding.Number = codingDataModel.Number;
            listCoding.Numberlength = codingDataModel.NumberLength;
            listCoding.Active = codingDataModel.Active;
            listCoding.IdUser = codingDataModel.IdUser;
            return listCoding;
        }

        public string GetCode(string entity)
        {
            var coding = codingRepository.GetEntity(entity);
            string code = coding.Text + new string('0', coding.NumberLength - coding.Number.ToString().Length).ToString() + (coding.Number + 1).ToString();
            return code;
        }
    }
}
