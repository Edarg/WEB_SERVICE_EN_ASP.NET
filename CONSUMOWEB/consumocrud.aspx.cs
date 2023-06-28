using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CONSUMOWEB
{
    public partial class consumocrud : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //despues de que se realiza la referencia del servico que vamos a usar 
            //se procede  obterener el listo total de la BD y posteriormente almacenarle en ds DataSet
            ServicioChamoy.servicio_web_gtSoapClient ws = new ServicioChamoy.servicio_web_gtSoapClient();
            DataSet ds = ws.WSListado();
            //se procede insertar en elgrid la consulta 
            GridView1.DataSource = ds.Tables[0];

            GridView1.AutoGenerateSelectButton = true;  
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtId.Text = GridView1.SelectedRow.Cells[1].Text.ToString();
            txtNombre.Text = GridView1.SelectedRow.Cells[2].Text.ToString();
            txtLanzamiento.Text = GridView1.SelectedRow.Cells[3].Text.ToString();
            txtDesarrollador.Text = GridView1.SelectedRow.Cells[4].Text.ToString();




        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            ServicioChamoy.servicio_web_gtSoapClient ws = new ServicioChamoy.servicio_web_gtSoapClient();
            ws.WSInsertar(txtNombre.Text, int.Parse(txtLanzamiento.Text), txtDesarrollador.Text);
            DataSet ds = ws.WSListado();
            //se procede insertar en elgrid la consulta 
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();


        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {

            ServicioChamoy.servicio_web_gtSoapClient ws = new ServicioChamoy.servicio_web_gtSoapClient();
            ws.WSeliminar(int.Parse(txtId.Text));

            DataSet ds = ws.WSListado();

            //se procede insertar en elgrid la consulta 
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();


        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            ServicioChamoy.servicio_web_gtSoapClient ws = new ServicioChamoy.servicio_web_gtSoapClient();
            ws.WSModificar(int.Parse(txtId.Text),txtNombre.Text, int.Parse(txtLanzamiento.Text), txtDesarrollador.Text);



            DataSet ds = ws.WSListado();

            //se procede insertar en elgrid la consulta 
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();


        }
    }
}