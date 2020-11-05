using System;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace GAME
{
    
    public partial class Get : System.Web.UI.Page
    {
        String usuario = "";
        Boolean tf;
        static int idJugador = 0;
        public void insertPartida(int player2) {

            String connectionString = ConfigurationManager.ConnectionStrings["JuegoConnectionString"].ConnectionString;
            SqlConnection sql = new SqlConnection(connectionString);
            sql.Open();/*ABRIENDO BASE DE DATOS*/
            SqlCommand com = new SqlCommand();
            com.Connection = sql;
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "getIdJugador";
            com.Parameters.AddWithValue("@Nombre_Usuario", usuario);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())//OBTIENE SI ES VERDADERO EL NOMBRE O NO
            {
                idJugador = dr.GetInt32(0);

            }
            dr.Close();
            sql.Close();
            //CPU = 1
            //INVITADO = 2
            SqlConnection sql1 = new SqlConnection(connectionString);
            sql1.Open();/*ABRIENDO BASE DE DATOS*/
            SqlCommand com1 = new SqlCommand();
            com1.Connection = sql1;
            com1.CommandType = CommandType.StoredProcedure;
            com1.CommandText = "spInsertPartida";
            com1.Parameters.AddWithValue("@Id_Jugador1", idJugador);
            com1.Parameters.AddWithValue("@Id_Jugador2", player2);
            com1.ExecuteNonQuery();

            Session["IdJugador1"] = idJugador;//ENVIAR ID JUGADOR SESION
            Session["IdJugador2"] = idJugador;//ENVIAR ID JUGADOR SESION
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["JuegoConnectionString"].ConnectionString;
            //Label1.Text = "hola "+(string)(Session["Sesion"]);
            String help =" "+(string)(Session["Sesion"]);//EVITAR ERRORES QUE NO EXISTE USUARIO
            if (help.Equals(" "))
            {
                usuario = "A";
            }
            else {
                usuario = (string)(Session["Sesion"]);
            }    

        }
        
        protected void Button1_Click(object sender, EventArgs e)
        {
            insertPartida(1);
            //Label1.Text = "ID: jugador= " + idJugador.ToString();  
            tf = true;
            Response.Redirect("Ocpu.aspx?CpuVs=" + tf);//PASA EL VALOR A LA OTRA PAGINA
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            insertPartida(2);
            //Label1.Text = "ID: jugador= " + idJugador.ToString();
            tf = false;
            Response.Redirect("Ocpu.aspx?CpuVs=" + tf);//PASA EL VALOR A LA OTRA PAGINA
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int x = int.Parse(N.Text);//SI ES PAR
            int y = int.Parse(M.Text);
            if ( x%2== 0 && y % 2 == 0) {
                /* Session["N"] = N.Text;
                 Session["M"] = M.Text;*/
                //insertPartida(2);
                Response.Redirect("Extreme.aspx?N=" + N.Text + "&M=" + M.Text);//ENVIAR TAMAÑO DE MATRIZ
                
                /*help.SetX(x);//N
                help.SetY(y);//M*/
            }
        }

        protected void Torneo_Click(object sender, EventArgs e)
        {
            Response.Redirect("Torneo.aspx");
        }
    }
}