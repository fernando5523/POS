using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL.Model;
using BLL.ValueObjects;
using DAL.Entities;
using DAL.Repositories;

namespace TestRepository
{
    [TestClass]
    public class TestUserRepository
    {
        #region Test business Logical Layer
        private UserModel RepositoryModel = new UserModel();

        [TestMethod]
        public void Add()
        {
            UserModel objectModel = new UserModel();
            objectModel.Name = "fernando.colque";
            objectModel.Password = "12345";
            objectModel.Active = true;
            objectModel.UserID = 1;
            objectModel.State = EntityState.Added;
            objectModel.SaveChanges();
        }

        [TestMethod]
        public void Edit()
        {
            UserModel objectModel = new UserModel().GetId(2);
            objectModel.Name = "teodoro.colque";
            objectModel.State = EntityState.Modified;
            objectModel.SaveChanges();
        }

        [TestMethod]
        public void Remove()
        {
            UserModel objectModel = new UserModel();
            objectModel.Id = 2;
            objectModel.State = EntityState.Deleted;
            objectModel.SaveChanges();
        }

        [TestMethod]
        public void GetLogin()
        {
            UserModel objectModel = new UserModel().GetLogin("administrador", "12");
        }
        #endregion

        #region Test data access Layer
        [TestMethod]
        public void Read()
        {
            UserRepository UserDAL = new UserRepository();
            var users = UserDAL.Find(e => e.Active == true);
        }
        
        [TestMethod]
        public void Create()
        {
            User Object = new User();
            Object.Name = "teodoro.colque";
            Object.Password = "12345";
            Object.Active = true;
            //Object.UserID = 1;
            //Object.UserModified.Add(Object);

            UserRepository UserDAL = new UserRepository();
            UserDAL.Add(Object);
        }
        #endregion
    }
}
