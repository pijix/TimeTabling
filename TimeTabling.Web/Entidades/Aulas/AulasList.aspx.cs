using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using TimeTabling.Application;
using TimeTabling.Core;

namespace TimeTabling.Web.Entidades.Aulas
{
    public partial class AulasList : System.Web.UI.Page
    {

        private readonly string _conStr = ConfigurationManager.ConnectionStrings["TimeTablingConnection"].ToString();
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if(Page.IsPostBack) return;
            var aulaManagement = new AulaManagement(_conStr);
            var aulas = aulaManagement.Aulas();
            GridAulas.DataSource = aulas;
            GridAulas.DataBind();
        }

        public void BtnEliminar_Click(object sender, CommandEventArgs e)
        {
            
            var aulaC = e.CommandArgument.ToString();

            if (string.IsNullOrEmpty(aulaC)) return;

            var res = MessageBox.Show("Desea Eliminar " + aulaC, "Atención...", MessageBoxButtons.YesNo);
            if (res != DialogResult.Yes) return;

            var manager = new AulaManagement(_conStr);
            if (manager.EliminarAula(e.CommandArgument.ToString()) == 0)
                MessageBox.Show("No se ha eliminado el registro...");
            
        }

        public void BtnEditar_Click(object sender, CommandEventArgs e)
        {
            var aulaC = e.CommandArgument.ToString();
            if (string.IsNullOrEmpty(aulaC)) return;
            Response.Redirect("AulasEdit.aspx?aulaC=" + aulaC);
        }

        protected void addAula_Click(object sender, EventArgs e)
        {
            Response.Redirect("AulasEdit.aspx");
        }

    }
}