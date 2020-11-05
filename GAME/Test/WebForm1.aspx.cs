using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace GAME.Test
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        static string t = "";
        static string d = "";
        protected void B_LUno_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            { /*VER ARHCIVO*/
                String dos = System.IO.Path.GetFileName(FileUpload1.FileName);

                var cuenta = XDocument.Load(HttpContext.Current.Server.MapPath("../XML/" + dos)).XPathSelectElements("//equipo").Count();//CUENTA CUATNOS EQUIPOS HAY

                XmlDocument doc = new XmlDocument();
                doc.Load(HttpContext.Current.Server.MapPath("../XML/" + dos));
                XDocument xml = XDocument.Load(HttpContext.Current.Server.MapPath("../XML/" + dos));//OBTIENE LOS ELMENTOS DE CIERTO NODO

                XmlElement root = doc.DocumentElement;
                XmlNodeList elemList = root.GetElementsByTagName("jugador");
                for (int i = 0; i < elemList.Count; i++)
                {   
                    t=t+elemList[i].InnerXml+"<br>";
                    if ((i + 1) % 3 == 0) {
                        t = t + "--<br>";
                    }
                }
                
            }
            else
            {
                Response.Write("SELECCIONE ARCHIVO");
            }
            Uno.Text = t;
        }

        protected void B_LDos_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            { /*VER ARHCIVO*/
                String dos = System.IO.Path.GetFileName(FileUpload1.FileName);
                //XDocument xdoc = XDocument.Load(HttpContext.Current.Server.MapPath("../XML/" + dos));
                XmlDocument doc = new XmlDocument();
                doc.Load(HttpContext.Current.Server.MapPath("../XML/" + dos));
                XDocument xml = XDocument.Load(HttpContext.Current.Server.MapPath("../XML/" + dos));//OBTIENE LOS ELMENTOS DE CIERTO NODO
                IEnumerable<XElement> employees = xml.Descendants("Jugador1").Descendants("color");
                //IEnumerable<XElement> employees = xml.Descendants("Jugador1");
                d = d + "P1<br>";
                foreach (var employee in employees)
                {
                    //d = d + employee.Value+"<br>";//SOLO UNO
                    d = d + employee.Value+"<br>";
                }
                d = d + "P2<br>";
                employees = xml.Descendants("Jugador2").Descendants("color");
                foreach (var employee in employees)
                {
                    //d = d + employee.Value+"<br>";//SOLO UNO
                    d = d + employee.Value + "<br>";
                }
                d = d + "modalidad: " + xml.Root.Element("Modalidad").Value+"<br>";
                d = d + "Fila: " + xml.Root.Element("Filas").Value + "<br>";
                d = d + "Columnas: " + xml.Root.Element("Columnas").Value + "<br>";
            }
            else
            {
                Response.Write("SELECCIONE ARCHIVO");
            }
            Dos.Text = d;
        }
    }
}