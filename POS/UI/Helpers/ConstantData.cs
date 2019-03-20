using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Helpers
{
    using BLL.Model;
    using BLL.ValueObjects;
    using System.Windows.Forms;
    using System.Configuration;
    public static class ConstantData
    {
        public static UserModel Login = new UserModel();
        public static string Enterprise = " - " + ConfigurationManager.AppSettings["Empresa"].ToString();
        public static void MessageError(string message)
        {
            MessageBox.Show(message, "Error" + Enterprise, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void MessageInformation(string message)
        {
            MessageBox.Show(message, "Información" + Enterprise, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static bool DeleteItem(string Entity, int Id)
        {
            bool result = false;
            try
            {
                switch (Entity)
                {
                    case "Brand":
                        BrandModel Brand = new BrandModel();
                        Brand.Id = Id;
                        Brand.State = EntityState.Deleted;
                        Brand.SaveChanges();
                        break;
                    case "Category":
                        CategoryModel Category = new CategoryModel();
                        Category.Id = Id;
                        Category.State = EntityState.Deleted;
                        Category.SaveChanges();
                        break;
                    case "UnitTemplate":
                        UnitTemplateModel UnitTemplate = new UnitTemplateModel();
                        UnitTemplate.Id = Id;
                        UnitTemplate.State = EntityState.Deleted;
                        UnitTemplate.SaveChanges();
                        break;
                    default:
                        break;
                }
                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                result = false;
            }
            return result;
        }

    }
}
