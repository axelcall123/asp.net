using System;
using System.Configuration;
using System.Data;using System.Collections.Generic;using System.Linq;using System.Web; using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.UI;

namespace GAME
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /*String connectionString = ConfigurationManager.ConnectionStrings["JuegoConnectionString"].ConnectionString;*/
        /*String connectionString = @"Data Source=DESKTOP-FTJQFOD; Initial catalog=Partida; Integrated Security=True;";*/
        protected void Enviar_r_Click(object sender, EventArgs e)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["JuegoConnectionString"].ConnectionString;
            String nombre = nombre_r.Text;/*OBTNER TEXTO*/
            String apellido = apellido_r.Text;
            String usuario = usuario_r.Text;
            String contraseña = contraseña_r.Text;
            String fecha = fecha_r.Text;
            String pais = pais_r.Text;
            String correo = email_r.Text;
            
            /*using (SqlConnection sql = new SqlConnection(connectionString))
            {*/
         
                SqlConnection sql = new SqlConnection(connectionString);
                sql.Open();/*ABRIENDO BASE DE DATOS*/
                SqlCommand com = new SqlCommand();
                com.Connection = sql;
                com.CommandType = CommandType.StoredProcedure;
                com.CommandText = "spInsertUser";
                /*@Nombre@Apellido@Nombre_Usuario@Contraseña@Fecha_Nac@Pais@Correo*/
                /*com.Parameters.Add("@Id", SqlDbType.Int).Value = 1;*/
                com.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = nombre;
                com.Parameters.Add("@Apellido", SqlDbType.VarChar).Value = apellido;
                com.Parameters.Add("@Nombre_Usuario", SqlDbType.VarChar).Value = usuario;
                com.Parameters.Add("@Contraseña", SqlDbType.VarChar).Value = contraseña;
                com.Parameters.Add("@Fecha_Nac", SqlDbType.Date).Value = fecha;
                com.Parameters.Add("@Pais", SqlDbType.VarChar).Value = pais;
                com.Parameters.Add("@Correo", SqlDbType.VarChar).Value = correo;              
                com.ExecuteNonQuery();
                Response.Redirect("Default.aspx");
            /*}*/


        }

        protected void nombre_r_TextChanged(object sender, EventArgs e)
        {

        }
    }
}