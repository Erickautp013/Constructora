using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using logicanegociosconstructora;

namespace Constructora
{
    public partial class Obra : System.Web.UI.Page
    {
        logicanegocioconstr objBL = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                objBL = new logicanegocioconstr(ConfigurationManager.ConnectionStrings["conex"].ConnectionString);
                Session["BL"] = objBL;
                Dueno();
                
            }
            else
            {
                objBL = (logicanegocioconstr)Session["BL"];
                GridView1.DataSource = Session["dueno"];
                GridView1.DataBind();

            }
        }

        public void Dueno()
        {
            string m = "";
            Session["dueño"] = objBL.obtenMaterial(ref m);
            GridView1.DataSource = Session["dueño"];
            GridView1.DataBind();


        }
        protected void Button1_Click(object sender, EventArgs e)
        {

            string m = "";
            string md = "";
            if (GridView1.SelectedIndex >= 0)
            {
                objBL.InsertarObra(TextBox1.Text, TextBox2.Text,Convert.ToDateTime( TextBox3.Text), Convert.ToDateTime( TextBox6.Text), Convert.ToInt16(GridView1.Rows[GridView1.SelectedIndex].Cells[1].Text), Convert.ToInt16(GridView3.Rows[GridView3.SelectedIndex].Cells[1].Text), ref m);
                md = objBL.MiMessageBox("CONSULTA CORRECTA", m, 2);
                TextBox4.Text = m;
                Page.ClientScript.RegisterStartupScript(this.GetType(), "etiqueta" + 1, "" + md + "", true);
            }
            else
            {
                TextBox4.Text = "Consulta Incorrecta";
                md = objBL.MiMessageBox("No se pudo Insertar correctamente", m, 3);
                TextBox4.Text = m;
                Page.ClientScript.RegisterStartupScript(this.GetType(), "etiqueta" + 1, "" + md + "", true);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string m = "";
            string md = "";
            GridView2.DataSource = objBL.obtenObra(ref m);
            GridView2.DataBind();
            TextBox5.Text = m;
            md = objBL.MiMessageBox("CONSULTA CORRECTA", m, 2);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "etiqueta" + 1, "" + md + "", true);
        }
    }
}