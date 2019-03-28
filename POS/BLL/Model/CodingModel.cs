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
        private string code;
        private int containerid;
        private string text;
        private int number;
        private int numberlength;
        private bool active;
        private int userid;
        private ICodingRepository codingRepository;

        public EntityState State { private get; set; }
        public int Id { get => id; set => id = value; }
        public string Code { get => code; private set => code = value;}
        public int ContainerID { get => containerid; set => containerid = value; }
        public string Text { get => text; set => text = value; }
        public int Number { get => number; set => number = value; }
        public int Numberlength { get => numberlength; set => numberlength = value; }
        public bool Active { get => active; set => active = value; }
        public int UserID { get => userid; set => userid = value; }

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
                codingDataModel.ID = Id;
                codingDataModel.ContainerID = ContainerID;
                codingDataModel.Text = Text;
                codingDataModel.Number = Number;
                codingDataModel.NumberLength = Numberlength;
                codingDataModel.Active = Active;
                codingDataModel.UserID = UserID;

                switch (State)
                {
                    case EntityState.Added:
                        codingRepository.Add(codingDataModel);
                        message = "Registro guardado.";
                        break;
                    case EntityState.Deleted:
                        codingRepository.Remove(codingDataModel);
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
                    Id = item.ID,
                    ContainerID = item.ContainerID,
                    Text = item.Text,
                    Number = item.Number,
                    Numberlength = item.NumberLength,
                    Active = item.Active,
                    UserID = item.UserID
                });
            }
            return listCoding;
        }

        public CodingModel GetId(int id)
        {
            CodingModel listCoding = null;
            var codingDataModel = codingRepository.Find(e => e.ID == id).FirstOrDefault();
            if (codingDataModel != null)
            {
                listCoding = new CodingModel();
                listCoding.Id = codingDataModel.ID;
                listCoding.ContainerID = codingDataModel.ContainerID;
                listCoding.Text = codingDataModel.Text;
                listCoding.Number = codingDataModel.Number;
                listCoding.Numberlength = codingDataModel.NumberLength;
                listCoding.Active = codingDataModel.Active;
                listCoding.UserID = codingDataModel.UserID;
                listCoding.Code = codingDataModel.Text + new string('0', codingDataModel.NumberLength - codingDataModel.Number.ToString().Length).ToString() + (codingDataModel.Number + 1).ToString();
            }
            return listCoding;
        }
    }
}
