using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GAME
{
    public partial class Iniciar_Sesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Enviar_s_Click(object sender, EventArgs e)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["JuegoConnectionString"].ConnectionString;
            String usuario = usuario_s.Text;
            String contraseña = contraseña_s.Text;

            SqlConnection sql = new SqlConnection(connectionString);
            sql.Open();/*ABRIENDO BASE DE DATOS*/
            SqlCommand com = new SqlCommand();
            com.Connection = sql;
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "stpGetUserPass";
            com.Parameters.AddWithValue("@Nombre_Usuario", usuario);
            com.Parameters.AddWithValue("@Contraseña", contraseña);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())//OBTIENE SI ES VERDADERO EL NOMBRE O NO
            {
                int a = dr.GetInt32(0);
                if (a == 1)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('SESION')", true);
                    Session["Sesion"] = usuario;
                    Response.Redirect("Get.aspx");
                    
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('NO SESION')", true);
                }
            }
            dr.Close();
            /*int count = Convert.ToInt32(com.ExecuteScalar());
            com.ExecuteNonQuery();
            if (count == 1)
            {
                Response.Redirect("Othelo.aspx");
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('SESION')", true);
            }
            else {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('NO SESION')", true);
            }*/

        }
    }
}