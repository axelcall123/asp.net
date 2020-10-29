using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GAME
{
    
    public partial class Get : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        Boolean tf;
        protected void Button1_Click(object sender, EventArgs e)
        {
            tf = true;
            Response.Redirect("Ocpu.aspx?id=" + tf);//PASA EL VALOR A LA OTRA PAGINA
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //cls.id = false;
            tf = false;
            Response.Redirect("Ocpu.aspx?id="+tf);//PASA EL VALOR A LA OTRA PAGINA
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int x = int.Parse(N.Text);//SI ES PAR
            int y = int.Parse(M.Text);
            if ( x%2== 0 && y % 2 == 0) {
                Session["N"] = N.Text;
                Session["M"] = M.Text;
                Response.Redirect("Extreme.aspx?N=" + N.Text + "&M=" + M.Text);//ENVIAR TAMAÑO DE MATRIZ
                
                /*help.SetX(x);//N
                help.SetY(y);//M*/
            }
        }
    }
}