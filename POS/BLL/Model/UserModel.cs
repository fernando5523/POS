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

namespace BLL.Model
{
    public class UserModel
    {
        private int id;
        private string name;
        private string password;
        private bool active;
        private int iduser;

        private IUserRepository userRepository;
        public EntityState State { private get; set; }

        [RegularExpression("([0-9]+)", ErrorMessage = "Solo esta permitido valores númericos.")]
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
        [Required(ErrorMessage = "El nombre es un campo requerido.")]
        [StringLength(maximumLength: 50, ErrorMessage = "Solo esta permitido un máximo de 50 digitos.")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Los campos deben ser letras.")]
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        [Required(ErrorMessage = "La contraseña es un campo requerido.")]
        [StringLength(maximumLength: 30, ErrorMessage = "Solo esta permitido un máximo de 30 digitos.")]
        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public bool Active
        {
            get
            {
                return active;
            }

            set
            {
                active = value;
            }
        }
        [Required(ErrorMessage = "El iduser es un campo requerido.")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Solo esta permitido valores númericos.")]
        public int IdUser
        {
            get
            {
                return iduser;
            }

            set
            {
                iduser = value;
            }
        }

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
                userDataModel.Id = id;
                userDataModel.Name = name;
                userDataModel.Password = password;
                userDataModel.Active = active;
                userDataModel.IdUser = iduser;

                switch (State)
                {
                    case EntityState.Added:
                        //Ejecutar reglas comerciales / calculos
                        userRepository.Add(userDataModel);
                        message = "Registro guardado.";
                        break;
                    case EntityState.Deleted:
                        userRepository.Remove(userDataModel.Id);
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
            foreach(User item in userDataModel)
            {
                listUsers.Add(new UserModel {
                    Id = item.Id,
                    Name = item.Name,
                    Password = item.Password,
                    Active = item.Active,
                    IdUser = item.IdUser
                });
            }
            return listUsers;
        }

        public UserModel GetLogin(string name, string password)
        {
            var userDataModel = userRepository.GetLogin(name, password);
            UserModel Login = new UserModel();
            Login.id = userDataModel.Id;
            Login.name = userDataModel.Name;
            Login.password = userDataModel.Password;
            Login.active = userDataModel.Active;
            Login.IdUser = userDataModel.IdUser;
            return Login;
        }
    }
}