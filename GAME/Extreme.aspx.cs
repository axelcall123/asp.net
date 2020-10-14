using System;
using System.Collections.Generic;
using System.Data.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GAME
{
    public partial class Extreme : System.Web.UI.Page
    {

        String texto = "";
        ImageButton[,] CUADROS = new ImageButton[6,8];
        ImageButton[,] MARCO = new ImageButton[6+2,8+2];
        Panel[] PANEL = new Panel[(8+2)];
        /*String[,] test = {
            {"1","2","3","4"},
            {"10","20","30","40"},
            {"100","200","300","400"},
        };
        for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    texto = texto + "||" + test[x, y];
                }
                texto = texto + "||<br>";
            }*/
protected void Page_Load(object sender, EventArgs e)//8*6 8 iz yy 6 abajo
        {
            int id1 = 97;
            /*for (int x = 0; x < (6 + 2); x++)
            {
                for (int y = 0; y < (8 + 2); y++)
                {//test[x, y];
                    if (x == 0 || x == (6 + 2 - 1))//*|A|B|C|D|E|*
                    {
                        if (y == 0 || y == (8 + 2 - 1))//*|     |*
                        {
                            
                            if (y == 0)//*|
                            {
                                texto = texto + "*";
                            }
                            else {
                                texto = texto + "*<br>";//|*
                            }
                        }// A|B|C|D|E
                        else
                        {
                            texto = texto + "|"+ Char.ToString(Convert.ToChar(id1))+"|";
                            id1 += 1;
                        }
                    }
                    else {
                        //1|BA1|BB1|BC1|BD1|BE1|1
                        //2|BA2|BB2|BC2|BD2|BE2|2
                        //3|BA3|BB3|BC3|BD3|BE3|3
                        if (y == 0 || y == (8 + 2 - 1))
                        {//1|       |1
                         //2|       |2
                         //3|       |3
                            if (y == 0)//1| 2| 3|
                            {
                                texto = texto + (x);
                            }
                            else {//|1 |2 |3
                                texto = texto + (x)+"<br>";
                            }
                                
                        }
                        else {//BA1|BB1|BC1|BD1|BE1
                              //BA2|BB2|BC2|BD2|BE2
                              //BA3|BB3|BC3|BD3|BE3
                            texto = texto +"|()|";
                        }
                        
                    }
                    
                }
                id1 = 97;
            }
            */
            for (int x = 0; x < (6 + 2); x++)
            {
                PANEL[x] = new Panel();
                
                for (int y = 0; y < (8 + 2); y++)
                {//test[x, y];
                    MARCO[x, y] = new ImageButton();//(2,8+2)
                    if (x == 0 || x == (6 + 2 - 1))//*|A|B|C|D|E|*
                    {
                        if (y == 0 || y == (8 + 2 - 1))//*|     |*
                        {
                            
                            if (y == 0)//*|
                            {
                                MARCO[x, y].ImageUrl = "~/IMG/Le/por.png";
                                MARCO[x, y].Enabled = false;
                                MARCO[x, y].Width = 30;
                                MARCO[x, y].Height = 30;
                                PANEL[x].Controls.Add(MARCO[x, y]);
                            }
                            else//|*
                            {
                                MARCO[x, y].ImageUrl = "~/IMG/Le/por.png";
                                MARCO[x, y].Enabled = false;
                                MARCO[x, y].Width = 30;
                                MARCO[x, y].Height = 30;
                                PANEL[x].Controls.Add(MARCO[x, y]);
                                continue;
                            }
                        }
                        else
                        {// A|B|C|D|E
                            MARCO[x, y].ImageUrl = Char.ToString(Convert.ToChar(id1));
                            MARCO[x, y].Enabled = false;
                            MARCO[x, y].Width = 30;
                            MARCO[x, y].Height = 30;
                            PANEL[x].Controls.Add(MARCO[x, y]);
                            id1 += 1;
                        }
                    }
                    else
                    {
                        //1|BA1|BB1|BC1|BD1|BE1|1
                        //2|BA2|BB2|BC2|BD2|BE2|2
                        //3|BA3|BB3|BC3|BD3|BE3|3
                        if (y == 0 || y == (8 + 2 - 1))
                        {//1|       |1
                         //2|       |2
                         //3|       |3
                            if (y == 0)//1| 2| 3|
                            {
                                MARCO[x, y].Text = x.ToString();
                                MARCO[x, y].Enabled = false;
                                MARCO[x, y].Width = 30;
                                MARCO[x, y].Height = 30;
                                PANEL[x].Controls.Add(MARCO[x, y]);
                            }
                            else
                            {//|1 |2 |3
                                MARCO[x, y].Text = x.ToString();
                                MARCO[x, y].Enabled = false;
                                MARCO[x, y].Width = 30;
                                MARCO[x, y].Height = 30;
                                PANEL[x].Controls.Add(MARCO[x, y]);
                                continue;
                            }

                        }
                        else
                        {//BA1|BB1|BC1|BD1|BE1
                         //BA2|BB2|BC2|BD2|BE2
                         //BA3|BB3|BC3|BD3|BE3
                            CUADROS[x - 1, y - 1] = new ImageButton();
                            CUADROS[x - 1, y - 1].Width = 30;
                            CUADROS[x - 1, y - 1].Height = 30;
                            CUADROS[x - 1, y - 1].ImageUrl = "~/IMG/EX/z.png";
                            PANEL[x].Controls.Add(CUADROS[x-1, y-1]);
                        }
                        
                    }
                }
                Panel1.Controls.Add(PANEL[x]);
                id1 = 97;
            }




            /*texto = texto + Request.QueryString["n"].ToString()+"<br>";
            texto = texto + Request.QueryString["m"].ToString();*/
            //TT.Text = texto;
            
        }

    }
}