using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestRepository
{
    using BLL.Model;
    using BLL.ValueObjects;
    [TestClass]
    public class TestUnitTemplateRepository
    {
        UnitTemplateModel objeto;
        [TestMethod]
        public void Create()
        {
            objeto = new UnitTemplateModel();
            objeto.Code = "P0001";
            objeto.Name = "Unidad";
            objeto.Abbreviation = "U.";
            objeto.Factor = 1;
            objeto.Description = "Empaque que representa a un producto.";
            objeto.IdUser = 1;
            objeto.State = EntityState.Added;
            string message = objeto.SaveChanges();
        }
    }
}
