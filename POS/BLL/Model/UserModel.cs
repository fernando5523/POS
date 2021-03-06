﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Contracts;
using DAL.Entities;
using DAL.Repositories;
using BLL.ValueObjects;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace BLL.Model
{
    public class UserModel
    {
        private int id;
        private string name;
        private string password;
        private bool active;
        private int? userid;

        private IUserRepository userRepository;
        public EntityState State { private get; set; }

        [RegularExpression("([0-9]+)", ErrorMessage = "Solo esta permitido valores númericos.")]
        public int Id { get => id; set => id = value; }

        [Required(ErrorMessage = "El nombre es un campo requerido.")]
        [StringLength(maximumLength: 50, ErrorMessage = "Solo esta permitido un máximo de 50 digitos.")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Los campos deben ser letras.")]
        public string Name { get => name; set => name = value; }

        [Required(ErrorMessage = "La contraseña es un campo requerido.")]
        [StringLength(maximumLength: 30, MinimumLength = 14, ErrorMessage = "La contraseña debe tener minimo 14 y máximo 30 digitos.")]
        public string Password { get => password; set => password = value; }
        public bool Active { get => active; set => active = value; }

        [Required(ErrorMessage = "El iduser es un campo requerido.")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Solo esta permitido valores númericos.")]
        public int? UserID { get => userid; set => userid = value; }

        public UserModel()
        {
            userRepository = new UserRepository();
        }

        public string SaveChanges()
        {
            string message = null;
            try
            {
                var userDataModel = new User();
                userDataModel.ID = Id;
                userDataModel.Name = Name;
                userDataModel.Password = Password;
                userDataModel.Active = Active;
                userDataModel.UserID = UserID;

                switch (State)
                {
                    case EntityState.Added:
                        //Ejecutar reglas comerciales / calculos
                        userRepository.Add(userDataModel);
                        message = "Registro guardado.";
                        break;
                    case EntityState.Deleted:
                        userRepository.Remove(userDataModel);
                        message = "Registro eliminado.";
                        break;
                    case EntityState.Modified:
                        userRepository.Edit(userDataModel);
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

        public List<UserModel> GetAll()
        {
            var userDataModel = userRepository.GetAll();
            var listUsers = new List<UserModel>();
            foreach (User item in userDataModel)
            {
                listUsers.Add(new UserModel {
                    Id = item.ID,
                    Name = item.Name,
                    Password = item.Password,
                    Active = item.Active,
                    UserID = item.UserID
                });
            }
            return listUsers;
        }

        public UserModel GetLogin(string name, string password)
        {
            UserModel Login = null;
            var userDataModel = userRepository.Find(e => e.Name == name && e.Password == password).FirstOrDefault();
            if (userDataModel != null)
            {
                Login = new UserModel();
                Login.Id = userDataModel.ID;
                Login.name = userDataModel.Name;
                Login.password = userDataModel.Password;
                Login.active = userDataModel.Active;
                Login.UserID = userDataModel.UserID;
            }
            return Login;
        }

        public UserModel GetId(int id)
        {
            UserModel objects = null;
            var userDataModel = userRepository.Find(e => e.ID == id).FirstOrDefault();
            if(userDataModel != null)
            {
                objects = new UserModel();
                objects.Id = userDataModel.ID;
                objects.name = userDataModel.Name;
                objects.password = userDataModel.Password;
                objects.active = userDataModel.Active;
                objects.UserID = userDataModel.UserID;
            }
            return objects;
        }
    }
}