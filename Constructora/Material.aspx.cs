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
    public partial class Material : System.Web.UI.Page
    {
        logicanegocioconstr objBL = null;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                objBL = new logicanegocioconstr(ConfigurationManager.ConnectionStrings["conex"].ConnectionString);
                Session["BL"] = objBL;
                TipoMaterial();
            }
            else
            {
                objBL = (logicanegocioconstr)Session["BL"];
                GridView1.DataSource = Session["tipomaterial"];
                GridView1.DataBind();

            }

            
        }
        public void TipoMaterial()
        {
            string m = "";
            Session["tipo"] = objBL.obtenMaterial(ref m);
            GridView1.DataSource = Session["tipo"];
            GridView1.DataBind();


        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string m = "";
            string md = "";
            if (GridView1.SelectedIndex >= 0)
            {
                objBL.InsertarMaterial(TextBox1.Text, TextBox2.Text, TextBox3.Text, Convert.ToInt16(GridView1.Rows[GridView1.SelectedIndex].Cells[1].Text),ref m);
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
            GridView2.DataSource = objBL.obtenMaterial(ref m);
            GridView2.DataBind();
            TextBox5.Text = m;
            md = objBL.MiMessageBox("CONSULTA CORRECTA", m, 2);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "etiqueta" + 1, "" + md + "", true);
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}