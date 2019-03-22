using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BLL;
using DevExpress.Data.Filtering;
using DevExpress.XtraGrid;
using BLL.Model;
using BLL.ValueObjects;
using UI.Helpers;

namespace UI
{
    public partial class FrmFiltro : DevExpress.XtraEditors.XtraForm
    {
        //Obtenemos el contenedor, consulta y el filtro
        private ContainerModel Containers = new ContainerModel();
        private ConsultModel Consult = new ConsultModel();
        private FilterModel Filter = new FilterModel();

        private string name;
        private int idconsult;
        private int iduser;
        private string text;
        public IPages Pages { get; set; }

        public FrmFiltro(string name, string text, int iduser)
        {
            this.name = name;
            this.text = text;
            this.iduser = iduser;
            InitializeComponent();
        }

        private void FrmFiltro_Load(object sender, EventArgs e)
        {
            ContainerModel containerDataModel = Containers.GetContainerName(name);
            ConsultModel consultDataModel = Consult.GetIdContainer(containerDataModel.Id);
            FilterModel filterDataModel = Filter.GetUser(iduser, consultDataModel.Id);

            this.idconsult = consultDataModel.Id;
            string transactSql = consultDataModel.Select + " " + consultDataModel.From + " WHERE 0=1";
            fcFilter.SourceControl = Filter.Execute(transactSql);
            if(filterDataModel != null)
                fcFilter.FilterCriteria = CriteriaOperator.Parse(filterDataModel.ConditionDev);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string condition = null;
            string conditiondev = null;
            FilterModel filterDataModel = Filter.GetUser(iduser, idconsult);
            condition = CriteriaToWhereClauseHelper.GetMsSqlWhere(fcFilter.FilterCriteria);
            conditiondev = fcFilter.FilterCriteria != null ? fcFilter.FilterCriteria.LegacyToString() : "";

            //if (condition == null && conditiondev == null)
            //    filterDataModel.State = EntityState.Deleted;

            if (filterDataModel != null)
            {
                filterDataModel.Condition = condition;
                filterDataModel.ConditionDev = conditiondev;
                filterDataModel.State = EntityState.Modified;
            }
            else
            {
                filterDataModel = new FilterModel();
                filterDataModel.IdUser = iduser;
                filterDataModel.IdConsult = idconsult;
                filterDataModel.Condition = condition;
                filterDataModel.ConditionDev = conditiondev;
                filterDataModel.State = EntityState.Added;
            }
            filterDataModel.SaveChanges();

            Pages.LoadPage(name, text);
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}