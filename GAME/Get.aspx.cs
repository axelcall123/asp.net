using System;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Web;
using System.Xml;
using System.Xml.XPath;
using System.Linq;

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
        static string d = "";
        protected void Button3_Click(object sender, EventArgs e)
        {
            String coloresP1 = "";
            String coloresP2 = "";
            String modalidad = "";
            String fila = "";
            String columna = "";
            int tamañoColor1 = 0;
            int tamañoColor2 = 0;
            if (FileUpload1.HasFile)
            { //VER ARHCIVO
                String dos = System.IO.Path.GetFileName(FileUpload1.FileName);
                XDocument xml = XDocument.Load(HttpContext.Current.Server.MapPath("/XML/" + dos));//OBTIENE LOS ELMENTOS DE CIERTO NODO
                IEnumerable<XElement> employees = xml.Descendants("Jugador1").Descendants("color");
                foreach (var employee in employees)
                {
                    //d = d + employee.Value+"<br>";//SOLO UNO
                    // d = d + employee.Value + "<br>";
                    coloresP1 = coloresP1 + employee.Value + ";";
                    tamañoColor1++;
                }

                employees = xml.Descendants("Jugador2").Descendants("color");
                foreach (var employee in employees)
                {
                    //d = d + employee.Value + "<br>";
                    coloresP2= coloresP2+ employee.Value + ";";
                    tamañoColor2++;
                }
                modalidad = xml.Root.Element("Modalidad").Value;
                fila = xml.Root.Element("Filas").Value;
                columna = xml.Root.Element("Columnas").Value;
                /*d = coloresP1 + "<br>"+
                    coloresP2+ "<br>"+
                    modalidad+ "<br>"+
                    fila+ "<br>"+
                    columna+"<br>"+
                    tamañoColor1+" ; "+ tamañoColor2
                    ;*/

                /*char[] p1 = coloresP1.ToCharArray();
                String union = "";
                for (int x = 0; x < p1.Length; x++) {
                    if (p1[x].Equals(';'))
                    {
                        d =d+ union + "|<br>";
                        union = "";
                    }
                    else {
                        union = union + p1[x].ToString();
                    }
                }*/
                //Tamaño p1;p2|| Colores p1,p2|| Tipo|| Columa;Fila
                Response.Redirect("Extreme.aspx"
                    + "?Tap1=" + tamañoColor1//NUMERO COLORES P1 *
                    + "&Tap2=" + tamañoColor2//NUMERO COLORE P2 *
                    + "&Cop1=" + coloresP1//COLORE P1 *
                    + "&Cop2=" + coloresP2//COLORES P2 *
                    + "&Mod=" + modalidad//MODALIDAD 
                    + "&Col=" + columna//COLUMNAS *
                    + "&Fil=" + fila//FILAS *
                    );
            }
            else
            {
                Response.Write("SELECCIONE ARCHIVO");
            }
            
            Text.Text = d;
        }
        protected void Torneo_Click(object sender, EventArgs e)
        {
            String nombreTorneo = "";
            String nombreEquipos = "";
            String jugadores = "";
            if (FileUpload1.HasFile)
            { //VER ARHCIVO
                String dos = System.IO.Path.GetFileName(FileUpload1.FileName);
                XmlDocument doc = new XmlDocument();
                doc.Load(HttpContext.Current.Server.MapPath("/XML/" + dos));
                XDocument xml = XDocument.Load(HttpContext.Current.Server.MapPath("/XML/" + dos));//OBTIENE LOS ELMENTOS DE CIERTO NODO
                //NOMBRE DE LOS INTEGRANTES
                XmlElement root = doc.DocumentElement;
                XmlNodeList elemList = root.GetElementsByTagName("jugador");

                nombreTorneo= xml.Root.Element("nombre").Value;
                for (int i = 0; i < elemList.Count; i++)
                {
                    jugadores = jugadores + elemList[i].InnerXml+ ";";
                }
                //NOMBRE DEL TEAM
                elemList = root.GetElementsByTagName("nombreEquipo");
                for (int i = 0; i < elemList.Count; i++)
                {
                    nombreEquipos = nombreEquipos + elemList[i].InnerXml+";";
                }
                var cuenta = XDocument.Load(HttpContext.Current.Server.MapPath("/XML/" + dos)).XPathSelectElements("//equipo").Count();//CUENTA CUATNOS EQUIPOS HAY
                //TORNEO| NOMBRE EQUIPO|JUGADORES
                //d = d +"torneo: "+ nombreTorneo + "<br>";
                //d = d +"equipos: "+ nombreEquipos + "<br>";
                //d = d +"jugadores: "+ jugadores + "<br>";
                Response.Redirect("Torneo.aspx?"
                    + "Torn=" + nombreTorneo
                    + "&nEq=" + nombreEquipos
                    + "&pla=" + jugadores
                    + "&Tam=" + cuenta
                    );
                //https://localhost:44330/Torneo?Torn=Camp+uno&nEq=Uno%3bDos%3bTres%3bCuatro%3b&pla=A%3bB%3bC%3bD%3bE%3bF%3bG%3bH%3bI%3bJ%3bK%3bL%3b&Tam=4
            }
            else
            {
                Response.Write("SELECCIONE ARCHIVO");
            }
            Text.Text = d;
            int[] hola = { 1, 2, 3 };
        }
    }
}