using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using TimeTabling.Application;
using TimeTabling.Core;

namespace TimeTabling.Web.Entidades.Aulas
{
    public partial class AulasEdit : System.Web.UI.Page
    {
        private readonly string _conStr = ConfigurationManager.ConnectionStrings["TimeTablingConnection"].ToString();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            var aulaC = Request.QueryString["aulaC"];
            if (!string.IsNullOrEmpty(aulaC))
            {
                OmplirCamps(aulaC);
                AddAula.Visible = false;
            }
            else
                EditAula.Visible = false;
        }

        private void OmplirCamps(string aulaC)
        {
            var manager = new AulaManagement(_conStr);
            var aula = manager.Aula(aulaC);
            AulaC.Text = aula.AulaC;
            AulaD.Text = aula.AulaD;
            TipoAula.SelectedItem.Text = aula.TipoAula;
            SoftDisponible.Checked = aula.SoftDisponible;
        }

        protected void AddAula_Click(object sender, EventArgs e)
        {
            
            var aula = new Aula
            {
                AulaC = AulaC.Text,
                AulaD = AulaD.Text,
                TipoAula = TipoAula.SelectedItem.Text,
                SoftDisponible = SoftDisponible.Checked
            };

            var manager = new AulaManagement(_conStr);
            if (manager.AñadirAula(aula) == 0)
                MessageBox.Show("Error al dar de Alta la Aula");
            else
                Response.Redirect("AulasList.aspx");
        }

        protected void EditAula_Click(object sender, EventArgs e)
        {
            var aula = new Aula
            {
                AulaC = AulaC.Text,
                AulaD = AulaD.Text,
                TipoAula = TipoAula.SelectedItem.Text,
                SoftDisponible = SoftDisponible.Checked
            };

            var manager = new AulaManagement(_conStr);
            if (manager.ModificarAula(aula) == 0)
                MessageBox.Show("Error al modificar el Aula");
            else
                Response.Redirect("AulasList.aspx");

        }

        protected void Cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("AulasList.aspx");
        }

    }
}