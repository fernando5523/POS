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

namespace UI
{
    public partial class FrmFiltro : DevExpress.XtraEditors.XtraForm
    {
        //Entity.Container objContainer = new Entity.Container();
        //private string page;

        //public string Name { get; set; }
        //public string Text { get; set; }
        public IPages Pages { get; set; }

        public FrmFiltro()
        {
            InitializeComponent();
        }

        private void FrmFiltro_Load(object sender, EventArgs e)
        {
            //BLL.Container Contain = new BLL.Container();
            //objContainer = Contain.GetBy(Name);

            //Consult Column = new Consult();
            //DataTable Columns = Column.GetView(objContainer.Id, "Id = 0");
            //Entity.Consult objFiltro = Column.GetBy(objContainer.Id);
            //fcFilter.SourceControl = Columns;


            //Filter ModelFilter = new Filter();
            //Entity.Filter Filtro = ModelFilter.GetBy(objFiltro.Id);

            //fcFilter.FilterCriteria = CriteriaOperator.Parse(Filtro.ConditionDev);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Consult Consult = new Consult();
            //Filter Filter = new Filter();

            //Entity.Consult objConsult = Consult.GetBy(objContainer.Id);
            //Entity.Filter objFilter = Filter.GetBy(objConsult.Id) ;

            //string condition = CriteriaToWhereClauseHelper.GetMsSqlWhere(fcFilter.FilterCriteria);
            //string conditiondev = "";

            //if (fcFilter.FilterCriteria != null)
            //    conditiondev = fcFilter.FilterCriteria.LegacyToString();

            //if (objFilter.Id != 0)
            //{
            //    objFilter.Condition = condition;
            //    objFilter.ConditionDev = conditiondev;
            //    Filter.Update(objFilter);
            //}
            //else
            //{
            //    objFilter.IdUser = 1;
            //    objFilter.IdConsult = objConsult.Id;
            //    objFilter.Condition = condition;
            //    objFilter.ConditionDev = conditiondev;
            //    Filter.Insert(objFilter);
            //}

            //Pages.LoadPage(Name, Text, true);

            //this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
