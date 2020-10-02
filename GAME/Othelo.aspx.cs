using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;
namespace GAME
{
    public partial class Contact : Page
    {
        static int player = 0;
        ImageButton[,] BotonMulti() {
            ImageButton[,] boton = {
                {BA1,BB1,BC1,BD1,BE1,BF1,BG1,BH1},
                {BA2,BB2,BC2,BD2,BE2,BF2,BG2,BH2},
                {BA3,BB3,BC3,BD3,BE3,BF3,BG3,BH3},
                {BA4,BB4,BC4,BD4,BE4,BF4,BG4,BH4},
                {BA5,BB5,BC5,BD5,BE5,BF5,BG5,BH5},
                {BA6,BB6,BC6,BD6,BE6,BF6,BG6,BH6},
                {BA7,BB7,BC7,BD7,BE7,BF7,BG7,BH7},
                {BA8,BB8,BC8,BD8,BE8,BF8,BG8,BH8}
            };
            return boton;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        
        ImageButton[] BotonPro()
        {
            ImageButton[] boton ={/*ARREGLO DA IMAGEBUUTON*/
              BA1,BB1,BC1,BD1,BE1,BF1,BG1,BH1,
              BA2,BB2,BC2,BD2,BE2,BF2,BG2,BH2,
              BA3,BB3,BC3,BD3,BE3,BF3,BG3,BH3,
              BA4,BB4,BC4,BD4,BE4,BF4,BG4,BH4,
              BA5,BB5,BC5,BD5,BE5,BF5,BG5,BH5,
              BA6,BB6,BC6,BD6,BE6,BF6,BG6,BH6,
              BA7,BB7,BC7,BD7,BE7,BF7,BG7,BH7,
              BA8,BB8,BC8,BD8,BE8,BF8,BG8,BH8
            };
            return boton;
        }
        public void Ymen(int y, int x, String url) {
            ImageButton[,] Botones = BotonMulti();
            if (y > 0) {
                if (Botones[y, x].ImageUrl.Equals(url)){
                    int yy = y - 1;
                    if (yy > 0){
                        if (Botones[yy, x].ImageUrl == "") {
                            Botones[yy, x].Enabled = true;
                        }
                    }
                    else if (yy > 0){
                        if (Botones[yy, x].ImageUrl.Equals(url)) {
                            Ymen(y - 1, x, url);
                        }
                    }
                }
            }
        }/*1*/
        public void YmasXmen(int y, int x, String url) {
            /*ImageButton[,] Botones = BotonMulti();
            if (y < 8 && x>0)
            {    
                if (Botones[y, x].ImageUrl.Equals(url))
                {
                    int yy=y+1;
                    int xx=x-1;
                    if((y < 8 && x>0) && Botones[y, x].ImageUrl == ""){
                        Botones[yy, x].Enabled = true;
                    }
                    else if((y < 8 && x>0) && ){
                        
                    }
                    YmasXmen(y + 1, x - 1, url, url2);
                    
                }
            }*/
        }
        public void Ymas(int y, int x, String url, String url2) {
           /*ImageButton[,] Botones = BotonMulti();
            if (y < 8)
            {
                if (Botones[y, x].ImageUrl.Equals(url))
                {
                    Ymas(y + 1, x, url, url2);
                }
                else if (Botones[y, x].ImageUrl.Equals(url2))
                {
                    Botones[y, x].Enabled = true;
                    y = 8;
                }
                else if (Botones[y, x].ImageUrl.Equals(""))
                {
                    y = 8;
                }
            }*/
        }/*3*/
        public void XmasYmas(int y, int x, String url, String url2) {
            /*ImageButton[,] Botones = BotonMulti();
            if (y < 8 && x<8)
            {
                if (Botones[y, x].ImageUrl.Equals(url))
                {
                    XmasYmas(y + 1, x+1, url, url2);
                }
                else if (Botones[y, x].ImageUrl.Equals(url2))
                {
                    Botones[y, x].Enabled = true;
                    y = 8;
                }
                else if (Botones[y, x].ImageUrl.Equals(""))
                {
                    y = 8;
                }
            }*/
        }/*4*/
        public void Xmas(int y, int x, String url, String url2) {
            /*ImageButton[,] Botones = BotonMulti();
            if (x < 8)
            {
                if (Botones[y, x].ImageUrl.Equals(url))
                {
                    Xmas(y, x + 1, url, url2);
                }
                else if (Botones[y, x].ImageUrl.Equals(url2))
                {
                    Botones[y, x].Enabled = true;
                    x = 8;
                }
                else if (Botones[y, x].ImageUrl.Equals(""))
                {
                    x = 8;
                }
            }*/
        }/*5*/
        public void YmenXmas(int y, int x, String url, String url2) {
            /*ImageButton[,] Botones = BotonMulti();
            if (y>0 && x < 8)
            {
                if (Botones[y, x].ImageUrl.Equals(url))
                {
                    YmenXmas(y-1, x + 1, url, url2);
                }
                else if (Botones[y, x].ImageUrl.Equals(url2))
                {
                    Botones[y, x].Enabled = true;
                    y = 0;
                }
                else if (Botones[y, x].ImageUrl.Equals(""))
                {
                    y = 0;
                }
            }*/
        }/*6*/
        public void Xmen(int y, int x, String url, String url2) {
            /*ImageButton[,] Botones = BotonMulti();
            if (x> 0)
            {
                if (Botones[y, x].ImageUrl.Equals(url))
                {
                    Xmen(y, x - 1, url, url2);
                }
                else if (Botones[y, x].ImageUrl.Equals(url2))
                {
                    Botones[y, x].Enabled = true;
                    x = 0;
                }
                else if (Botones[y, x].ImageUrl.Equals(""))
                {
                    x = 0;
                }
            }*/
        }/*7*/
        public void YmenXmen(int y, int x, String url, String url2) {
            /*ImageButton[,] Botones = BotonMulti();
            if (x > 0 && x>0)
            {
                if (Botones[y, x].ImageUrl.Equals(url))
                {
                    Xmen(y-1, x - 1, url, url2);
                }
                else if (Botones[y, x].ImageUrl.Equals(url2))
                {
                    Botones[y, x].Enabled = true;
                    x = 0;
                }
                else if (Botones[y, x].ImageUrl.Equals(""))
                {
                    x = 0;
                }
            }*/
        }/*8*/
        public void GAME()
        {/*            [Y,X]
              1 Botones[i,a-1]*
              2 Botones[i+1,a-1]*
              3 Botones[i+1,a]*
              4 Botones[i+1,a+1]*
              5 Botones[i,a+1]*
              6 Botones[i-1,a+1]*
              7 Botones[i-1,a]
              8 Botones[i-1,a-1]
             i=y
             a=x
        */
            /*ImageButton[,] Botones = BotonMulti();
            for (int i = 0; i < 8; i++)
            {
                for (int a = 0; a < 8; a++)
                {
                    Botones[i, a].Enabled = false;
                }
            }

                    for (int i = 0; i < 8; i++)
            {
                for (int a = 0; a < 8; a++)
                {
                    if (player % 2 == 0)//NEGRO
                    {
                        //[Y,X]
                        if (Botones[i, a].ImageUrl.Equals("~/IMG/1.png"))
                        {
                            Ymen(i - 1, a, "~/IMG/2.png");//
                            YmasXmen(i + 1, a - 1, "~/IMG/2.png", "~/IMG/1.png");//
                            YmasXmen(i + 1, a - 1, "~/IMG/2.png", "~/IMG/1.png");//
                            Ymas(i + 1, a, "~/IMG/2.png", "~/IMG/1.png");//
                            XmasYmas(i + 1, a + 1, "~/IMG/2.png", "~/IMG/1.png");//
                            Xmas(i + 1, a, "~/IMG/2.png", "~/IMG/1.png");//
                            YmenXmas(i - 1, a + 1, "~/IMG/2.png", "~/IMG/1.png");//
                            Xmen(i, a - 1, "~/IMG/2.png", "~/IMG/1.png");//
                            YmenXmen(i - 1, a - 1, "~/IMG/2.png", "~/IMG/1.png");//
                        }
                    }
                    else {
                        if (Botones[i,a].ImageUrl.Equals("~/IMG/2.png")) {
                            Ymen(i - 1, a,"~/IMG/1.png", "~/IMG/2.png");//
                            YmasXmen(i + 1, a - 1, "~/IMG/1.png", "~/IMG/2.png");//
                            YmasXmen(i + 1, a - 1, "~/IMG/1.png", "~/IMG/2.png");//
                            Ymas(i + 1, a, "~/IMG/1.png", "~/IMG/2.png");//
                            XmasYmas(i + 1, a + 1, "~/IMG/1.png", "~/IMG/2.png");//
                            Xmas(i + 1, a, "~/IMG/1.png", "~/IMG/2.png");//
                            YmenXmas(i - 1, a + 1, "~/IMG/1.png", "~/IMG/2.png");//
                            Xmen(i, a - 1, "~/IMG/1.png", "~/IMG/2.png");//
                            YmenXmen(i - 1, a - 1, "~/IMG/1.png", "~/IMG/2.png");//
                        }
                    
                    }
                }
            }*/
        }
        protected void BA1_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";/*NEGRO*/
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }
        }
        protected void BA2_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }
        }
        protected void BA3_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }

        }
        protected void BA4_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }
        }
        protected void BA5_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }
        }
        protected void BA6_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }

        }
        protected void BA7_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }

        }
        protected void BA8_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }

        }

        protected void BB1_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }

        }
        protected void BB2_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }

        }
        protected void BB3_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }

        }
        protected void BB4_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }

        }
        protected void BB5_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }

        }
        protected void BB6_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }

        }
        protected void BB7_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }

        }
        protected void BB8_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }

        }

        protected void BC1_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }

        }
        protected void BC2_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }

        }
        protected void BC3_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }

        }
        protected void BC4_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }

        }
        protected void BC5_Click(object sender, ImageClickEventArgs e)
        {
                GAME();GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }

        }
        protected void BC6_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }

        }
        protected void BC7_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }

        }
        protected void BC8_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }

        }

        protected void BD1_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }

        }
        protected void BD2_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }
        }
        protected void BD3_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }

        }
        protected void BD4_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }

        }
        protected void BD5_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }

        }
        protected void BD6_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }

        }
        protected void BD7_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }

        }
        protected void BD8_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }
        }

        protected void BE1_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }

        }
        protected void BE2_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }

        }
        protected void BE3_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }

        }
        protected void BE4_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }

        }
        protected void BE5_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }

        }
        protected void BE6_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }

        }
        protected void BE7_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }

        }
        protected void BE8_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }

        }

        protected void BF1_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }

        }
        protected void BF2_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }

        }
        protected void BF3_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }

        }
        protected void BF4_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }

        }
        protected void BF5_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }

        }
        protected void BF6_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }
        }
        protected void BF7_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }

        }
        protected void BF8_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }

        }

        protected void BG1_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }

        }
        protected void BG2_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }

        }
        protected void BG3_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }

        }
        protected void BG4_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }
        }
        protected void BG5_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }

        }
        protected void BG6_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }

        }
        protected void BG7_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }

        }
        protected void BG8_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }

        }

        protected void BH1_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }

        }
        protected void BH2_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }
        }
        protected void BH3_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }

        }
        protected void BH4_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }

        }
        protected void BH5_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }

        }
        protected void BH6_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }

        }
        protected void BH7_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }

        }

        protected void BH8_Click(object sender, ImageClickEventArgs e)
        {   GAME();
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";
                    player++;
                }
            }
        }
        /*String[] UrlB() {
            string[] BotonesTexto =TENER MATRIZ DE TODO EL TEXTO
            {
                BA1.ImageUrl,   BB1.ImageUrl,   BC1.ImageUrl,   BD1.ImageUrl,   BE1.ImageUrl,   BF1.ImageUrl,   BG1.ImageUrl,   BH1.ImageUrl,
                BA2.ImageUrl,   BB2.ImageUrl,   BC2.ImageUrl,   BD2.ImageUrl,   BE2.ImageUrl,   BF2.ImageUrl,   BG2.ImageUrl,   BH2.ImageUrl,
                BA3.ImageUrl,   BB3.ImageUrl,   BC3.ImageUrl,   BD3.ImageUrl,   BE3.ImageUrl,   BF3.ImageUrl,   BG3.ImageUrl,   BH3.ImageUrl,
                BA4.ImageUrl,   BB4.ImageUrl,   BC4.ImageUrl,   BD4.ImageUrl,   BE4.ImageUrl,   BF4.ImageUrl,   BG4.ImageUrl,   BH4.ImageUrl,
                BA5.ImageUrl,   BB5.ImageUrl,   BC5.ImageUrl,   BD5.ImageUrl,   BE5.ImageUrl,   BF5.ImageUrl,   BG5.ImageUrl,   BH5.ImageUrl,
                BA6.ImageUrl,   BB6.ImageUrl,   BC6.ImageUrl,   BD6.ImageUrl,   BE6.ImageUrl,   BF6.ImageUrl,   BG6.ImageUrl,   BH6.ImageUrl,
                BA7.ImageUrl,   BB7.ImageUrl,   BC7.ImageUrl,   BD7.ImageUrl,   BE7.ImageUrl,   BF7.ImageUrl,   BG7.ImageUrl,   BH7.ImageUrl,
                BA8.ImageUrl,   BB8.ImageUrl,   BC8.ImageUrl,   BD8.ImageUrl,   BE8.ImageUrl,   BF8.ImageUrl,   BG8.ImageUrl,   BH8.ImageUrl,
            };
            return BotonesTexto;
        }
        String[] IdB() {
            string[] BotonesId =TENER MATRIZ DE TODO EL ID
            {
                BA1.ID,   BB1.ID,   BC1.ID,   BD1.ID,   BE1.ID,   BF1.ID,   BG1.ID,   BH1.ID,
                BA2.ID,   BB2.ID,   BC2.ID,   BD2.ID,   BE2.ID,   BF2.ID,   BG2.ID,   BH2.ID,
                BA3.ID,   BB3.ID,   BC3.ID,   BD3.ID,   BE3.ID,   BF3.ID,   BG3.ID,   BH3.ID,
                BA4.ID,   BB4.ID,   BC4.ID,   BD4.ID,   BE4.ID,   BF4.ID,   BG4.ID,   BH4.ID,
                BA5.ID,   BB5.ID,   BC5.ID,   BD5.ID,   BE5.ID,   BF5.ID,   BG5.ID,   BH5.ID,
                BA6.ID,   BB6.ID,   BC6.ID,   BD6.ID,   BE6.ID,   BF6.ID,   BG6.ID,   BH6.ID,
                BA7.ID,   BB7.ID,   BC7.ID,   BD7.ID,   BE7.ID,   BF7.ID,   BG7.ID,   BH7.ID,
                BA8.ID,   BB8.ID,   BC8.ID,   BD8.ID,   BE8.ID,   BF8.ID,   BG8.ID,   BH8.ID,
            };
            return BotonesId;
        }*/
        
        /*LEER ARCHIVO XML*/
        protected void Guardar_Click(object sender, EventArgs e)
        {
            /*String[] BotonesTexto = UrlB();
            String[] BotonesId = IdB();*/
            ImageButton[] boton = BotonPro();

            XDocument document = new XDocument(new XDeclaration("1.0", "utf-8", null));
            XElement nodoRaiz = new XElement("TABLERO");
            document.Add(nodoRaiz);
            for (int i = 0; i < 64; i++)/*PARA TODOA LA MATRIZ DE BOTONES*/
            {
                if (boton[i].ImageUrl.Equals("~/IMG/1.png") || boton[i].ImageUrl.Equals("~/IMG/2.png"))
                {/*SI ES BLANCO O NEGRO*/
                    XElement color = new XElement("FICHA");
                    if (boton[i].ImageUrl.Equals("~/IMG/1.png"))
                    {
                        color.Add(new XElement("COLOR", "blanca"));
                    }
                    else
                    {
                        color.Add(new XElement("COLOR", "negro"));
                    }
                    char[] ayuda = boton[i].ID.ToCharArray();/*CONVIETER EL ID EN B A 2*/
                    color.Add(new XElement("COLUMNA", ayuda[1]));/*A*/
                    color.Add(new XElement("FILA", ayuda[2]));/*2*/
                    nodoRaiz.Add(color);
                }

            }
            String nombre = "";
            nombre = NombreSalvar.Text;
            if (NombreSalvar.Text.Equals(""))/*SI NO HA ESCRITO NADA DEFAULT*/
            {
                nombre = "XML/Data.xml";
            }
            else
            {
                nombre = "XML/"+nombre + ".xml";/*GUARDA EL ARCHIVO*/
            }
            /*(@"C:\Demo\Demo\Data.xml"*/
            document.Save(HttpContext.Current.Server.MapPath(nombre));
            /*mlDocument.Save(@"C:\Demo\Demo\Data.xml");
              {BA1||BB1||BC1||BD1||BE1||BF1||BG1||BH1}
              {BA2||BB2||BC2||BD2||BE2||BF2||BG2||BH2}
              {BA3||BB3||BC3||BD3||BE3||BF3||BG3||BH3}
              {BA4||BB4||BC4||BD4||BE4||BF4||BG4||BH4}
              {BA5||BB5||BC5||BD5||BE5||BF5||BG5||BH5}
              {BA6||BB6||BC6||BD6||BE6||BF6||BG6||BH6}
              {BA7||BB7||BC7||BD7||BE7||BF7||BG7||BH7}
              {BA8||BB8||BC8||BD8||BE8||BF8||BG8||BH8}
              */
        }

        protected void Cargar_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            { /*VER ARHCIVO*/
                /*ext = System.IO.Path.GetExtension(FileUpload1.FileName);/*URL*/
                String dos = System.IO.Path.GetFileName(FileUpload1.FileName);

                XDocument xml = XDocument.Load(HttpContext.Current.Server.MapPath("XML/"+dos));
                IEnumerable<XElement> employees = xml.Root.Elements();
                foreach (var employee in employees)
                {
                    ImageButton[] boton = BotonPro();
                    /*Label1.Text= employee.Element("COLOR").Value;/*RECUPERA EL COLOR*/
                    String ID = "B" + employee.Element("COLUMNA").Value + employee.Element("FILA").Value;/*EL ID BA1*/
                    String Color = employee.Element("COLOR").Value;
                    for (int i = 0; i < 64; i++)
                    {
                        if (ID.Equals(boton[i].ID))
                        {/*If ID ES IGUAL ID BOTON*/
                            if (Color.Equals("negro"))
                            {
                                boton[i].ImageUrl = "~/IMG/2.png";
                            }
                            else
                            {
                                boton[i].ImageUrl = "~/IMG/1.png";
                            }
                        }
                    }
                }
            }
            else {
                Response.Write("SELECCIONE ARCHIVO");
            }


            
            
                /*XElement root = xml.Root;
                foreach (XElement d in root.Elements("FICHA"))
                {
                    Console.WriteLine("Elements : " + d.Value);
                    ImageButton1.ImageUrl = d.Value;
                }*/

            }

        protected void ImageButton1_Click1(object sender, ImageClickEventArgs e)
        {   
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl=="")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl= "~/IMG/2.png";/*BLANCO*/
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/1.png";/*NEGRO*/
                    player++;
                }
            }
        }
    }
}