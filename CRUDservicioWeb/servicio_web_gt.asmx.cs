using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CRUDservicioWeb
{
    /// <summary>
    /// Summary description for servicio_web_gt
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class servicio_web_gt : System.Web.Services.WebService
    {

     
        //datos para la conexión a la BD
        String host;
        String bd;
        String user;
        String password;
        String CadenaConexion;


        //constructor para inicializar las varibles y la cadena de conexion 
        public servicio_web_gt() {
            this.host = "localhost";
            this.bd = "tutoriales";
            this.user= "root";
            this.password = "";

            this.CadenaConexion = "server=" + this.host + 
                                  "; port=3306" + 
                                  "; User Id=" + this.user + 
                                  "; password=" + this.password + 
                                  "; database=" + this.bd + ";"; 
        }



        //metodo para devolver una cosulta completa al servicio web
        //data adpter me sirve para usarlo como puente entre la BD y el Data Set
        //el resultado me lo entregara en XML
        [WebMethod]
        public DataSet WSListado() {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = this.CadenaConexion;
            MySqlDataAdapter da = new MySqlDataAdapter("select * from frameworks", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }


        //metodo para insersar datos a la BD de MySQL
        //se utilizar el MySqlCommand para poder ejecutar DML en la BD 
        [WebMethod]
        public void WSInsertar(String nombre, int lanzamento, String desarrollador ) {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = this.CadenaConexion;
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "insert into frameworks  (id, nombre, lanzamiento, desarrollador) values ( null , '"+nombre+"',"+lanzamento+", '"+desarrollador+"' ) ";
            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        //metodo para modificar un registro en la BD MySQL
        [WebMethod]
        public void WSModificar(int id, String Nombre, int Lanzamiento, String desarrollador) {

            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = this.CadenaConexion;
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "update frameworks set nombre='" + Nombre + "', lanzamiento=" + Lanzamiento + ", desarrollador='" + desarrollador + "' where id=" + id;
            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        [WebMethod]
        public void WSeliminar(int id) {

            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = this.CadenaConexion;
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "delete from frameworks where id=" + id;
            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        




        
        

        

       
    }
}
