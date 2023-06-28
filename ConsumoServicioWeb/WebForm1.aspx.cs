using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConsumoServicioWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServicioChamoy.servicio_web_gtSoapClient ws = new ServicioChamoy.servicio_web_gtSoapClient();   
            DataSet ds = ws.WSListado();
            GridView1.DataSource = ds.Tables[0];    
            GridView1.AutoGenerateSelectButton = true;  
            GridView1.DataBind();   

        }
    }
}