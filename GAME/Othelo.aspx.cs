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
        static Boolean UnaVez=true;

        static char[,] XmasM= new char[8,8]; //X+
        static char[,] XmenM= new char[8,8]; //X-
        static char[,] YmasM= new char[8,8]; //Y+
        static char[,] YmenM= new char[8,8]; //Y-
        ///////
        static char[,] YmasXmenM= new char[8,8];//Y+X-
        static char[,] YmenXmenM = new char[8,8];//Y-X-
        static char[,] YmenXmasM = new char[8,8];//Y-X+
        static char[,] YmasXmasM = new char[8,8];//Y+X+
        ImageButton[,] BotonMulti() {
            ImageButton[,] boton = {
               //0   1   2   3   4   4   6   7
                {BA1,BB1,BC1,BD1,BE1,BF1,BG1,BH1},//0
                {BA2,BB2,BC2,BD2,BE2,BF2,BG2,BH2},//1
                {BA3,BB3,BC3,BD3,BE3,BF3,BG3,BH3},//2
                {BA4,BB4,BC4,BD4,BE4,BF4,BG4,BH4},//3
                {BA5,BB5,BC5,BD5,BE5,BF5,BG5,BH5},//4
                {BA6,BB6,BC6,BD6,BE6,BF6,BG6,BH6},//5
                {BA7,BB7,BC7,BD7,BE7,BF7,BG7,BH7},//6
                {BA8,BB8,BC8,BD8,BE8,BF8,BG8,BH8}//7
                //A   B   C   D   E   F   G   H
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
        //POS X, POS Y, BLANCO|NEGRO
        //"~/IMG/1.png"; NEGRO
        //"~/IMG/2.png"; BLANCO
        public void Xmas(int x, int y, String url) {//COLOR NEGREO
            ImageButton[,] Botones = BotonMulti();
            if (x < 8) {//CAUSE ERROR POSICON
                if (Botones[x, y].ImageUrl.Equals(url)) {//SIG POS ES BLANCO
                    if (x+1 < 8) {//NO ERROR
                        if (Botones[x+1, y].ImageUrl.Equals("")) {//SIG + SIG POS ES NULO ACTIVAR
                            Botones[x+1, y].Enabled = true;
                            XmasM[x + 1, y] = 'S';//GUARDAR EL BOTON QUE SE PUEDE ACTIVAR
                        }
                        else if(Botones[x+1, y].ImageUrl.Equals(url)) {//SIG + SIG POS ES BLANCO SEGUIR SIGUIENTE POS
                            XmasM[x, y] = 'N';//GUARDAR LAS
                            XmasM[x + 1, y] = 'N';//POSICIONES QUE SE SALTO ANTERIORMENTE
                            Xmas(x + 1, y, url);//INTERCALAR FICHAS
                        }
                    }
                }
            }
        }/*1*/
        public void Xmen(int x, int y, String url)
        {
            ImageButton[,] Botones = BotonMulti();
            if (x >= 0)
            {//CAUSE ERROR POSICON
                if (Botones[x, y].ImageUrl.Equals(url))
                {//SIG POS ES BLANCO
                    if (x - 1 >= 0)
                    {//NO ERROR
                        if (Botones[x-1, y].ImageUrl.Equals(""))
                        {//SIG + SIG POS ES NULO ACTIVAR
                            Botones[x - 1, y].Enabled = true;
                            XmenM[x - 1, y] = 'S';//GUARDAR EL BOTON QUE SE PUEDE ACTIVAR
                        }
                        else if (Botones[x-1, y].ImageUrl.Equals(url))
                        {//SIG + SIG POS ES BLANCO SEGUIR SIGUIENTE POS
                            XmenM[x, y] = 'N';//GUARDAR LAS
                            XmenM[x - 1, y] = 'N';//POSICIONES QUE SE SALTO ANTERIORMENTE
                            Xmen(x - 1, y, url);//INTERCALAR FICHAS
                        }
                    }
                }
            }
        }/*2*/
        public void Ymas(int x, int y, String url)
        {
            ImageButton[,] Botones = BotonMulti();
            if (y < 8)
            {//CAUSE ERROR POSICON
                if (Botones[x, y].ImageUrl.Equals(url))
                {//SIG POS ES BLANCO
                    if (y + 1 < 8)
                    {//NO ERROR
                        if (Botones[x, y+1].ImageUrl.Equals(""))
                        {//SIG + SIG POS ES NULO ACTIVAR
                            Botones[x,y+1].Enabled = true;
                            YmasM[x , y+1] = 'S';//GUARDAR EL BOTON QUE SE PUEDE ACTIVAR
                        }
                        else if (Botones[x, y+1].ImageUrl.Equals(url))
                        {//SIG + SIG POS ES BLANCO SEGUIR SIGUIENTE POS
                            YmasM[x, y] = 'N';//GUARDAR LAS
                            YmasM[x, y+1] = 'N';//POSICIONES QUE SE SALTO ANTERIORMENTE
                            Ymas(x, y+1, url);//INTERCALAR FICHAS
                        }
                    }
                }
            }
        }/*3*/
        public void Ymen(int x, int y, String url)
        {
            ImageButton[,] Botones = BotonMulti();
            if (y >= 0)
            {//CAUSE ERROR POSICON
                if (Botones[x, y].ImageUrl.Equals(url))
                {//SIG POS ES BLANCO
                    if (y - 1 >= 0)
                    {//NO ERROR
                        if (Botones[x, y-1].ImageUrl.Equals(""))
                        {//SIG + SIG POS ES NULO ACTIVAR
                            Botones[x, y-1].Enabled = true;
                            YmenM[x , y-1] = 'S';//GUARDAR EL BOTON QUE SE PUEDE ACTIVAR
                        }
                        else if (Botones[x, y-1].ImageUrl.Equals(url))
                        {//SIG + SIG POS ES BLANCO SEGUIR SIGUIENTE POS
                            YmenM[x, y] = 'N';//GUARDAR LAS
                            YmenM[x, y-1] = 'N';//POSICIONES QUE SE SALTO ANTERIORMENTE
                            Ymen(x, y-1, url);//INTERCALAR FICHAS
                        }
                    }
                }
            }
        }/*4*/
        ///
        public void YmasXmen(int x, int y, String url)
        {
            ImageButton[,] Botones = BotonMulti();
            if (y < 8 && x>=0)
            {//CAUSE ERROR POSICON
                if (Botones[x, y].ImageUrl.Equals(url))
                {//SIG POS ES BLANCO
                    if (y + 1 < 8 && x-1>=0)
                    {//NO ERROR
                        if (Botones[x-1, y + 1].ImageUrl.Equals(""))
                        {//SIG + SIG POS ES NULO ACTIVAR
                            Botones[x-1, y + 1].Enabled = true;
                            YmasM[x-1, y + 1] = 'S';//GUARDAR EL BOTON QUE SE PUEDE ACTIVAR
                        }
                        else if (Botones[x-1, y + 1].ImageUrl.Equals(url))
                        {//SIG + SIG POS ES BLANCO SEGUIR SIGUIENTE POS
                            YmasM[x, y] = 'N';//GUARDAR LAS
                            YmasM[x-1, y + 1] = 'N';//POSICIONES QUE SE SALTO ANTERIORMENTE
                            YmasXmen(x-1, y + 1, url);//INTERCALAR FICHAS

                        }
                    }
                }
            }
        }//5
        public void YmenXmen(int x, int y, String url)
        {
            ImageButton[,] Botones = BotonMulti();
            if (y >= 0 && x>=0)
            {//CAUSE ERROR POSICON
                if (Botones[x, y].ImageUrl.Equals(url))
                {//SIG POS ES BLANCO
                    if (y - 1 >= 0 && x-1 >= 0)
                    {//NO ERROR
                        if (Botones[x-1, y - 1].ImageUrl.Equals(""))
                        {//SIG + SIG POS ES NULO ACTIVAR
                            Botones[x-1, y - 1].Enabled = true;
                            YmasM[x-1, y - 1] = 'S';//GUARDAR EL BOTON QUE SE PUEDE ACTIVAR
                        }
                        else if (Botones[x-1, y - 1].ImageUrl.Equals(url))
                        {//SIG + SIG POS ES BLANCO SEGUIR SIGUIENTE POS
                            YmasM[x, y] = 'N';//GUARDAR LAS
                            YmasM[x-1, y - 1] = 'N';//POSICIONES QUE SE SALTO ANTERIORMENTE
                            YmenXmen(x-1, y - 1, url);//INTERCALAR FICHAS

                        }
                    }
                }
            }
        }//6
        public void YmenXmas(int x, int y, String url)
        {
            ImageButton[,] Botones = BotonMulti();
            if (y >= 0 && x<8)
            {//CAUSE ERROR POSICON
                if (Botones[x, y].ImageUrl.Equals(url))
                {//SIG POS ES BLANCO
                    if (y - 1 >= 0 && x+1<8)
                    {//NO ERROR
                        if (Botones[x+1, y - 1].ImageUrl.Equals(""))
                        {//SIG + SIG POS ES NULO ACTIVAR
                            Botones[x+1, y - 1].Enabled = true;
                            YmasM[x+1, y - 1] = 'S';//GUARDAR EL BOTON QUE SE PUEDE ACTIVAR
                        }
                        else if (Botones[x+1, y - 1].ImageUrl.Equals(url))
                        {//SIG + SIG POS ES BLANCO SEGUIR SIGUIENTE POS
                            YmasM[x, y] = 'N';//GUARDAR LAS
                            YmasM[x+1, y - 1] = 'N';//POSICIONES QUE SE SALTO ANTERIORMENTE
                            YmenXmas(x+1, y - 1, url);//INTERCALAR FICHAS

                        }
                    }
                }
            }
        }//7
        public void YmasXmas(int x, int y, String url)
        {
            ImageButton[,] Botones = BotonMulti();
            if (y < 8 && x<8)
            {//CAUSE ERROR POSICON
                if (Botones[x, y].ImageUrl.Equals(url))
                {//SIG POS ES BLANCO
                    if (y + 1 < 8 && x+1<8)
                    {//NO ERROR
                        if (Botones[x+1, y + 1].ImageUrl.Equals(""))
                        {//SIG + SIG POS ES NULO ACTIVAR
                            Botones[x+1, y + 1].Enabled = true;
                            YmasM[x+1, y + 1] = 'S';//GUARDAR EL BOTON QUE SE PUEDE ACTIVAR
                        }
                        else if (Botones[x+1, y + 1].ImageUrl.Equals(url))
                        {//SIG + SIG POS ES BLANCO SEGUIR SIGUIENTE POS
                            YmasM[x, y] = 'N';//GUARDAR LAS
                            YmasM[x+1, y + 1] = 'N';//POSICIONES QUE SE SALTO ANTERIORMENTE
                            YmasXmas(x+1, y + 1, url);//INTERCALAR FICHAS

                        }
                    }
                }
            }
        }//8
        public void SearchSus(int posx, int posy, String url) {
            ImageButton[,] Botones = BotonMulti();
            if (XmasM[posx,posy] == 'T')
            {
                for (int x = 0; x < 8; x++)
                {
                    for (int y = 0; y < 8; y++)
                    {
                        if (XmasM[x, y] == 'N')
                        {
                            Botones[x, y].ImageUrl = url;
                        }
                    }
                }
            }
            else if (XmenM[posx,posy] == 'T')
            {
                for (int x = 0; x < 8; x++)
                {
                    for (int y = 0; y < 8; y++)
                    {
                        if (XmenM[x, y] == 'N')
                        {
                            Botones[x, y].ImageUrl = url;
                        }
                    }
                }
            }
            else if (YmasM[posx,posy] == 'T')
            {
                for (int x = 0; x < 8; x++)
                {
                    for (int y = 0; y < 8; y++)
                    {
                        if (YmasM[x, y] == 'N')
                        {
                            Botones[x, y].ImageUrl = url;
                        }
                    }
                }
            }
            else if (YmenM[posx,posy] == 'T')
            {
                for (int x = 0; x < 8; x++)
                {
                    for (int y = 0; y < 8; y++)
                    {
                        if (YmenM[x, y] == 'N')
                        {
                            Botones[x, y].ImageUrl = url;
                        }
                    }
                }
            }
            else if (YmasXmenM[posx,posy] == 'T')
            {
                for (int x = 0; x < 8; x++)
                {
                    for (int y = 0; y < 8; y++)
                    {
                        if (YmasXmenM[x, y] == 'N')
                        {
                            Botones[x, y].ImageUrl = url;
                        }
                    }
                }
            }
            else if (YmenXmenM[posx,posy] == 'T')
            {
                for (int x = 0; x < 8; x++)
                {
                    for (int y = 0; y < 8; y++)
                    {
                        if (YmenXmenM[x, y] == 'N')
                        {
                            Botones[x, y].ImageUrl = url;
                        }
                    }
                }
            }
            else if (YmenXmasM[posx,posy] == 'T')
            {
                for (int x = 0; x < 8; x++)
                {
                    for (int y = 0; y < 8; y++)
                    {
                        if (YmenXmasM[x, y] == 'N')
                        {
                            Botones[x, y].ImageUrl = url;
                        }
                    }
                }
            }
            else if (YmasXmasM[posx,posy] == 'T')
            {
                for (int x = 0; x < 8; x++)
                {
                    for (int y = 0; y < 8; y++)
                    {
                        if (YmasXmasM[x, y] == 'N')
                        {
                            Botones[x, y].ImageUrl = url;
                        }
                    }
                }
            }
        }
        public void GAME()
        {
            //ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('SESION')", true);
            ImageButton[,] Botones = BotonMulti();
            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    Botones[x, y].Enabled = false;
                }
            }

            for (int x = 0; x < 8; x++)
                {
                    for (int y = 0; y < 8; y++)
                    {
                        Console.WriteLine("siguiente");
                    if (player % 2 == 0)//NEGRO
                        {
                            //[X,Y]
                            if (Botones[x, y].ImageUrl.Equals("~/IMG/1.png"))
                            {
                                Xmas(x+1,y, "~/IMG/2.png");
                                Xmen(x-1, y, "~/IMG/2.png");
                                Ymas(x, y+1, "~/IMG/2.png");
                                Ymen(x, y-1, "~/IMG/2.png");
                                //GUARDO MATRIZ DE MATRIZ POS
                            }
                        }
                        else {
                            if (Botones[x,y].ImageUrl.Equals("~/IMG/2.png")) {
                                Xmas(x + 1, y, "~/IMG/1.png");
                                Xmen(x - 1, y, "~/IMG/1.png");
                                Ymas(x, y + 1, "~/IMG/1.png");
                                Ymen(x, y - 1, "~/IMG/1.png");
                                //GUARDO MATRIZ DE MATRIZ POS
                            }

                        }
                    }
                }
        }
        protected void BA1_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";//NEGRO
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";//BLANCO
                    player++;
                }
            }
            GAME();
            if (player % 2 == 0)
            {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
                SearchSus(0,0, "~/IMG/2.png");
            }
            else {
                SearchSus(0,0, "~/IMG/1.png");
            }
        }//[0,0]
        protected void BA2_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";//NEGRO
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";//BLANCO
                    player++;
                }
            }
            GAME();
            if (player % 2 == 0)
            {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
                SearchSus(1, 0, "~/IMG/2.png");
            }
            else
            {
                SearchSus(1, 0, "~/IMG/1.png");
            }
        }//[1,0]
        protected void BA3_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";//NEGRO
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";//BLANCO
                    player++;
                }
            }
            GAME();
            if (player % 2 == 0)
            {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
                SearchSus(2, 0, "~/IMG/2.png");
            }
            else
            {
                SearchSus(2, 0, "~/IMG/1.png");
            }
        }//[2,0]
        protected void BA4_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";//NEGRO
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";//BLANCO
                    player++;
                }
            }
            GAME();
            if (player % 2 == 0)
            {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
                SearchSus(3, 0, "~/IMG/2.png");
            }
            else
            {
                SearchSus(3, 0, "~/IMG/1.png");
            }
        }//[3,0]
        protected void BA5_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";//NEGRO
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";//BLANCO
                    player++;
                }
            }
            GAME();
            if (player % 2 == 0)
            {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
                SearchSus(4, 0, "~/IMG/2.png");
            }
            else
            {
                SearchSus(4, 0, "~/IMG/1.png");
            }
        }//[4,0]
        protected void BA6_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";//NEGRO
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";//BLANCO
                    player++;
                }
            }
            GAME();
            if (player % 2 == 0)
            {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
                SearchSus(5, 0, "~/IMG/2.png");
            }
            else
            {
                SearchSus(5, 0, "~/IMG/1.png");
            }
        }//[5,0]
        protected void BA7_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";//NEGRO
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";//BLANCO
                    player++;
                }
            }
            GAME();
            if (player % 2 == 0)
            {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
                SearchSus(6, 0, "~/IMG/2.png");
            }
            else
            {
                SearchSus(6, 0, "~/IMG/1.png");
            }
        }//[6,0]
        protected void BA8_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";//NEGRO
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";//BLANCO
                    player++;
                }
            }
            GAME();
            if (player % 2 == 0)
            {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
                SearchSus(7, 0, "~/IMG/2.png");
            }
            else
            {
                SearchSus(7, 0, "~/IMG/1.png");
            }
        }//[7,0]


        protected void BB1_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";//NEGRO
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";//BLANCO
                    player++;
                }
            }
            GAME();
            if (player % 2 == 0)
            {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
                SearchSus(0, 1, "~/IMG/2.png");
            }
            else
            {
                SearchSus(0, 1, "~/IMG/1.png");
            }
        }//[0,1]
        protected void BB2_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";//NEGRO
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";//BLANCO
                    player++;
                }
            }
            GAME();
            if (player % 2 == 0)
            {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
                SearchSus(1, 1, "~/IMG/2.png");
            }
            else
            {
                SearchSus(1, 1, "~/IMG/1.png");
            }
        }//[1,1]
        protected void BB3_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";//NEGRO
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";//BLANCO
                    player++;
                }
            }
            GAME();
            if (player % 2 == 0)
            {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
                SearchSus(2, 1, "~/IMG/2.png");
            }
            else
            {
                SearchSus(2, 1, "~/IMG/1.png");
            }
        }//[2,1]
        protected void BB4_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";//NEGRO
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";//BLANCO
                    player++;
                }
            }
            GAME();
            if (player % 2 == 0)
            {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
                SearchSus(3, 1, "~/IMG/2.png");
            }
            else
            {
                SearchSus(3, 1, "~/IMG/1.png");
            }
        }//[3,1]
        protected void BB5_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";//NEGRO
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";//BLANCO
                    player++;
                }
            }
            GAME();
            if (player % 2 == 0)
            {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
                SearchSus(4, 1, "~/IMG/2.png");
            }
            else
            {
                SearchSus(4, 1, "~/IMG/1.png");
            }
        }//[4,1]
        protected void BB6_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";//NEGRO
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";//BLANCO
                    player++;
                }
            }
            GAME();
            if (player % 2 == 0)
            {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
                SearchSus(5, 1, "~/IMG/2.png");
            }
            else
            {
                SearchSus(5, 1, "~/IMG/1.png");
            }
        }//[5,1]
        protected void BB7_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";//NEGRO
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";//BLANCO
                    player++;
                }
            }
            GAME();
            if (player % 2 == 0)
            {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
                SearchSus(6, 1, "~/IMG/2.png");
            }
            else
            {
                SearchSus(6, 1, "~/IMG/1.png");
            }
        }//[6,1]
        protected void BB8_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";//NEGRO
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";//BLANCO
                    player++;
                }
            }
            GAME();
            if (player % 2 == 0)
            {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
                SearchSus(7, 1, "~/IMG/2.png");
            }
            else
            {
                SearchSus(7, 1, "~/IMG/1.png");
            }
        }//[7,1]


        protected void BC1_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";//NEGRO
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";//BLANCO
                    player++;
                }
            }
            GAME();
            if (player % 2 == 0)
            {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
                SearchSus(0, 2, "~/IMG/2.png");
            }
            else
            {
                SearchSus(0, 2, "~/IMG/1.png");
            }
        }//[0,2]
        protected void BC2_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";//NEGRO
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";//BLANCO
                    player++;
                }
            }
            GAME();
            if (player % 2 == 0)
            {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
                SearchSus(1, 2, "~/IMG/2.png");
            }
            else
            {
                SearchSus(1, 2, "~/IMG/1.png");
            }
        }//[1,2]
        protected void BC3_Click(object sender, ImageClickEventArgs e)
        {
          ImageButton button = (ImageButton)sender;
          if (button.ImageUrl == "")
          {
              if (player % 2 == 0)
              {
                  button.ImageUrl = "~/IMG/1.png";//NEGRO
                  player++;
              }
              else
              {
                  button.ImageUrl = "~/IMG/2.png";//BLANCO
                  player++;
              }
          }
          GAME();
          if (player % 2 == 0)
          {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
              SearchSus(2, 2, "~/IMG/2.png");
          }
          else
          {
              SearchSus(2, 2, "~/IMG/1.png");
          }
        }//[2,2]
        protected void BC4_Click(object sender, ImageClickEventArgs e)
        {
          ImageButton button = (ImageButton)sender;
          if (button.ImageUrl == "")
          {
              if (player % 2 == 0)
              {
                  button.ImageUrl = "~/IMG/1.png";//NEGRO
                  player++;
              }
              else
              {
                  button.ImageUrl = "~/IMG/2.png";//BLANCO
                  player++;
              }
          }

          GAME();
          if (player % 2 == 0)
          {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
              SearchSus(3, 2, "~/IMG/2.png");
          }
          else
          {
              SearchSus(3, 2, "~/IMG/1.png");
          }
        }//[3,2]
        protected void BC5_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";//NEGRO
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";//BLANCO
                    player++;
                }
            }
            if (UnaVez == true)
            {
                ImageButton[,] Botones = BotonMulti();
                Botones[4, 3].ImageUrl = "~/IMG/1.png";
            }
            
            GAME();
            if (UnaVez == false)
            {
                if (player % 2 == 0)
                {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
                    SearchSus(4, 2, "~/IMG/2.png");
                }
                else
                {
                    SearchSus(4, 2, "~/IMG/1.png");
                }
            }
            UnaVez = false;

        }//[4,2] BOTON 1
        protected void BC6_Click(object sender, ImageClickEventArgs e)
        {
          ImageButton button = (ImageButton)sender;
          if (button.ImageUrl == "")
          {
              if (player % 2 == 0)
              {
                  button.ImageUrl = "~/IMG/1.png";//NEGRO
                  player++;
              }
              else
              {
                  button.ImageUrl = "~/IMG/2.png";//BLANCO
                  player++;
              }
          }
          GAME();
          if (player % 2 == 0)
          {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
              SearchSus(5, 2, "~/IMG/2.png");
          }
          else
          {
              SearchSus(5, 2, "~/IMG/1.png");
          }

        }//[5,2]
        protected void BC7_Click(object sender, ImageClickEventArgs e)
        {
          ImageButton button = (ImageButton)sender;
          if (button.ImageUrl == "")
          {
              if (player % 2 == 0)
              {
                  button.ImageUrl = "~/IMG/1.png";//NEGRO
                  player++;
              }
              else
              {
                  button.ImageUrl = "~/IMG/2.png";//BLANCO
                  player++;
              }
          }
          GAME();
          if (player % 2 == 0)
          {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
              SearchSus(6, 2, "~/IMG/2.png");
          }
          else
          {
              SearchSus(6, 2, "~/IMG/1.png");
          }
        }//[6,2]
        protected void BC8_Click(object sender, ImageClickEventArgs e)
        {
          ImageButton button = (ImageButton)sender;
          if (button.ImageUrl == "")
          {
              if (player % 2 == 0)
              {
                  button.ImageUrl = "~/IMG/1.png";//NEGRO
                  player++;
              }
              else
              {
                  button.ImageUrl = "~/IMG/2.png";//BLANCO
                  player++;
              }
          }
          GAME();
          if (player % 2 == 0)
          {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
              SearchSus(7, 2, "~/IMG/2.png");
          }
          else
          {
              SearchSus(7, 2, "~/IMG/1.png");
          }
        }//[7,2]


        protected void BD1_Click(object sender, ImageClickEventArgs e)
        {
          ImageButton button = (ImageButton)sender;
          if (button.ImageUrl == "")
          {
              if (player % 2 == 0)
              {
                  button.ImageUrl = "~/IMG/1.png";//NEGRO
                  player++;
              }
              else
              {
                  button.ImageUrl = "~/IMG/2.png";//BLANCO
                  player++;
              }
          }
          GAME();
          if (player % 2 == 0)
          {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
              SearchSus(0, 3, "~/IMG/2.png");
          }
          else
          {
              SearchSus(0, 3, "~/IMG/1.png");
          }
        }//[0,3]
        protected void BD2_Click(object sender, ImageClickEventArgs e)
        {
          ImageButton button = (ImageButton)sender;
          if (button.ImageUrl == "")
          {
              if (player % 2 == 0)
              {
                  button.ImageUrl = "~/IMG/1.png";//NEGRO
                  player++;
              }
              else
              {
                  button.ImageUrl = "~/IMG/2.png";//BLANCO
                  player++;
              }
          }
          GAME();
          if (player % 2 == 0)
          {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
              SearchSus(1, 3, "~/IMG/2.png");
          }
          else
          {
              SearchSus(1, 3, "~/IMG/1.png");
          }
        }//[1,3]
        protected void BD3_Click(object sender, ImageClickEventArgs e)
        {
          ImageButton button = (ImageButton)sender;
          if (button.ImageUrl == "")
          {
              if (player % 2 == 0)
              {
                  button.ImageUrl = "~/IMG/1.png";//NEGRO
                  player++;
              }
              else
              {
                  button.ImageUrl = "~/IMG/2.png";//BLANCO
                  player++;
              }
          }
          GAME();
          if (player % 2 == 0)
          {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
              SearchSus(2, 3, "~/IMG/1.png");
          }
          else
          {
              SearchSus(2, 3, "~/IMG/2.png");
          }
        }//[2,3]
        protected void BD4_Click(object sender, ImageClickEventArgs e)
        {
          ImageButton button = (ImageButton)sender;
          if (button.ImageUrl == "")
          {
              if (player % 2 == 0)
              {
                  button.ImageUrl = "~/IMG/1.png";//NEGRO
                  player++;
              }
              else
              {
                  button.ImageUrl = "~/IMG/2.png";//BLANCO
                  player++;
              }
          }
          GAME();
          if (player % 2 == 0)
          {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
              SearchSus(3, 3, "~/IMG/2.png");
          }
          else
          {
              SearchSus(3, 3, "~/IMG/1.png");
          }
        }//[3,3]
        protected void BD5_Click(object sender, ImageClickEventArgs e)
        {
          ImageButton button = (ImageButton)sender;
          if (button.ImageUrl == "")
          {
              if (player % 2 == 0)
              {
                  button.ImageUrl = "~/IMG/1.png";//NEGRO
                  player++;
              }
              else
              {
                  button.ImageUrl = "~/IMG/2.png";//BLANCO
                  player++;
              }
          }
          GAME();
          if (player % 2 == 0)
          {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
              SearchSus(4, 3, "~/IMG/2.png");
          }
          else
          {
              SearchSus(4, 3, "~/IMG/1.png");
          }
        }//[4,3]
        protected void BD6_Click(object sender, ImageClickEventArgs e)
        {
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
            if (UnaVez == true)
            {
                ImageButton[,] Botones = BotonMulti();
                Botones[4, 3].ImageUrl = "~/IMG/1.png";
            }

            GAME();
            if (UnaVez == false)
            {
                if (player % 2 == 0)
                {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
                    SearchSus(5, 3, "~/IMG/2.png");
                }
                else
                {
                    SearchSus(5, 3, "~/IMG/1.png");
                }
            }
            UnaVez = false;
        }//[5,3] BOTON 2
        protected void BD7_Click(object sender, ImageClickEventArgs e)
        {
          ImageButton button = (ImageButton)sender;
          if (button.ImageUrl == "")
          {
              if (player % 2 == 0)
              {
                  button.ImageUrl = "~/IMG/1.png";//NEGRO
                  player++;
              }
              else
              {
                  button.ImageUrl = "~/IMG/2.png";//BLANCO
                  player++;
              }
          }
          GAME();
          if (player % 2 == 0)
          {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
              SearchSus(6, 3, "~/IMG/2.png");
          }
          else
          {
              SearchSus(6, 3, "~/IMG/1.png");
          }
        }//[6,3]
        protected void BD8_Click(object sender, ImageClickEventArgs e)
        {
          ImageButton button = (ImageButton)sender;
          if (button.ImageUrl == "")
          {
              if (player % 2 == 0)
              {
                  button.ImageUrl = "~/IMG/1.png";//NEGRO
                  player++;
              }
              else
              {
                  button.ImageUrl = "~/IMG/2.png";//BLANCO
                  player++;
              }
          }
          GAME();
          if (player % 2 == 0)
          {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
              SearchSus(7, 3, "~/IMG/2.png");
          }
          else
          {
              SearchSus(7, 3, "~/IMG/1.png");
          }
        }//[7,3]


        protected void BE1_Click(object sender, ImageClickEventArgs e)
        {
          ImageButton button = (ImageButton)sender;
          if (button.ImageUrl == "")
          {
              if (player % 2 == 0)
              {
                  button.ImageUrl = "~/IMG/1.png";//NEGRO
                  player++;
              }
              else
              {
                  button.ImageUrl = "~/IMG/2.png";//BLANCO
                  player++;
              }
          }
          GAME();
          if (player % 2 == 0)
          {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
              SearchSus(0, 4, "~/IMG/2.png");
          }
          else
          {
              SearchSus(0, 4, "~/IMG/1.png");
          }
        }//[0,4]
        protected void BE2_Click(object sender, ImageClickEventArgs e)
        {
          ImageButton button = (ImageButton)sender;
          if (button.ImageUrl == "")
          {
              if (player % 2 == 0)
              {
                  button.ImageUrl = "~/IMG/1.png";//NEGRO
                  player++;
              }
              else
              {
                  button.ImageUrl = "~/IMG/2.png";//BLANCO
                  player++;
              }
          }
          GAME();
          if (player % 2 == 0)
          {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
              SearchSus(1, 4, "~/IMG/2.png");
          }
          else
          {
              SearchSus(1, 4, "~/IMG/1.png");
          }
        }//[1,4]
        protected void BE3_Click(object sender, ImageClickEventArgs e)
        {
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
            if (UnaVez == true)
            {
                ImageButton[,] Botones = BotonMulti();
                Botones[3, 4].ImageUrl = "~/IMG/1.png";
            }

            GAME();
            if (UnaVez == false)
            {
                if (player % 2 == 0)
                {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
                    SearchSus(2, 4, "~/IMG/2.png");
                }
                else
                {
                    SearchSus(2, 4, "~/IMG/1.png");
                }
            }
            UnaVez = false;
        }//[2,4] BOTON 3
        protected void BE4_Click(object sender, ImageClickEventArgs e)
        {
          ImageButton button = (ImageButton)sender;
          if (button.ImageUrl == "")
          {
              if (player % 2 == 0)
              {
                  button.ImageUrl = "~/IMG/1.png";//NEGRO
                  player++;
              }
              else
              {
                  button.ImageUrl = "~/IMG/2.png";//BLANCO
                  player++;
              }
          }
          GAME();
          if (player % 2 == 0)
          {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
              SearchSus(3, 4, "~/IMG/2.png");
          }
          else
          {
              SearchSus(3, 4, "~/IMG/1.png");
          }
        }//[3,4]
        protected void BE5_Click(object sender, ImageClickEventArgs e)
        {
          ImageButton button = (ImageButton)sender;
          if (button.ImageUrl == "")
          {
              if (player % 2 == 0)
              {
                  button.ImageUrl = "~/IMG/1.png";//NEGRO
                  player++;
              }
              else
              {
                  button.ImageUrl = "~/IMG/2.png";//BLANCO
                  player++;
              }
          }
          GAME();
          if (player % 2 == 0)
          {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
              SearchSus(4, 4, "~/IMG/2.png");
          }
          else
          {
              SearchSus(4, 4, "~/IMG/1.png");
          }
        }//[4,4]
        protected void BE6_Click(object sender, ImageClickEventArgs e)
        {
          ImageButton button = (ImageButton)sender;
          if (button.ImageUrl == "")
          {
              if (player % 2 == 0)
              {
                  button.ImageUrl = "~/IMG/1.png";//NEGRO
                  player++;
              }
              else
              {
                  button.ImageUrl = "~/IMG/2.png";//BLANCO
                  player++;
              }
          }
          GAME();
          if (player % 2 == 0)
          {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
              SearchSus(5, 4, "~/IMG/2.png");
          }
          else
          {
              SearchSus(5, 4, "~/IMG/1.png");
          }
        }//[5,4]
        protected void BE7_Click(object sender, ImageClickEventArgs e)
        {
          ImageButton button = (ImageButton)sender;
          if (button.ImageUrl == "")
          {
              if (player % 2 == 0)
              {
                  button.ImageUrl = "~/IMG/1.png";//NEGRO
                  player++;
              }
              else
              {
                  button.ImageUrl = "~/IMG/2.png";//BLANCO
                  player++;
              }
          }
          GAME();
          if (player % 2 == 0)
          {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
              SearchSus(6, 4, "~/IMG/2.png");
          }
          else
          {
              SearchSus(6, 4, "~/IMG/1.png");
          }
        }//[6,4]
        protected void BE8_Click(object sender, ImageClickEventArgs e)
        {
          ImageButton button = (ImageButton)sender;
          if (button.ImageUrl == "")
          {
              if (player % 2 == 0)
              {
                  button.ImageUrl = "~/IMG/1.png";//NEGRO
                  player++;
              }
              else
              {
                  button.ImageUrl = "~/IMG/2.png";//BLANCO
                  player++;
              }
          }
          GAME();
          if (player % 2 == 0)
          {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
              SearchSus(7, 4, "~/IMG/2.png");
          }
          else
          {
              SearchSus(7, 4, "~/IMG/1.png");
          }
        }//[7,4]


        protected void BF1_Click(object sender, ImageClickEventArgs e)
        {
          ImageButton button = (ImageButton)sender;
          if (button.ImageUrl == "")
          {
              if (player % 2 == 0)
              {
                  button.ImageUrl = "~/IMG/1.png";//NEGRO
                  player++;
              }
              else
              {
                  button.ImageUrl = "~/IMG/2.png";//BLANCO
                  player++;
              }
          }
          GAME();
          if (player % 2 == 0)
          {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
              SearchSus(0, 5, "~/IMG/2.png");
          }
          else
          {
              SearchSus(0, 5, "~/IMG/1.png");
          }
        }//[0,5]
        protected void BF2_Click(object sender, ImageClickEventArgs e)
        {
          ImageButton button = (ImageButton)sender;
          if (button.ImageUrl == "")
          {
              if (player % 2 == 0)
              {
                  button.ImageUrl = "~/IMG/1.png";//NEGRO
                  player++;
              }
              else
              {
                  button.ImageUrl = "~/IMG/2.png";//BLANCO
                  player++;
              }
          }
          GAME();
          if (player % 2 == 0)
          {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
              SearchSus(1, 5, "~/IMG/2.png");
          }
          else
          {
              SearchSus(1, 5, "~/IMG/1.png");
          }
        }//[1,5]
        protected void BF3_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "")
            {
                if (player % 2 == 0)
                {
                    button.ImageUrl = "~/IMG/1.png";//NEGRO
                    player++;
                }
                else
                {
                    button.ImageUrl = "~/IMG/2.png";//BLANCO
                    player++;
                }
            }
            GAME();
            if (player % 2 == 0)
            {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
                SearchSus(2, 5, "~/IMG/2.png");
            }
            else
            {
                SearchSus(2, 5, "~/IMG/1.png");
            }
        }//[2,5]
        protected void BF4_Click(object sender, ImageClickEventArgs e)
        {
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
            if (UnaVez == true)
            {
                ImageButton[,] Botones = BotonMulti();
                Botones[3, 4].ImageUrl = "~/IMG/1.png";
            }

            GAME();
            if (UnaVez == false)
            {
                if (player % 2 == 0)
                {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
                    SearchSus(4, 2, "~/IMG/2.png");
                }
                else
                {
                    SearchSus(4, 2, "~/IMG/1.png");
                }
            }
            UnaVez = false;
        }//[3,5] BOTON 4
        protected void BF5_Click(object sender, ImageClickEventArgs e)
        {
          ImageButton button = (ImageButton)sender;
          if (button.ImageUrl == "")
          {
              if (player % 2 == 0)
              {
                  button.ImageUrl = "~/IMG/1.png";//NEGRO
                  player++;
              }
              else
              {
                  button.ImageUrl = "~/IMG/2.png";//BLANCO
                  player++;
              }
          }
          GAME();
          if (player % 2 == 0)
          {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
              SearchSus(4, 5, "~/IMG/2.png");
          }
          else
          {
              SearchSus(4, 5, "~/IMG/1.png");
          }
        }//[4,5]
        protected void BF6_Click(object sender, ImageClickEventArgs e)
        {
          ImageButton button = (ImageButton)sender;
          if (button.ImageUrl == "")
          {
              if (player % 2 == 0)
              {
                  button.ImageUrl = "~/IMG/1.png";//NEGRO
                  player++;
              }
              else
              {
                  button.ImageUrl = "~/IMG/2.png";//BLANCO
                  player++;
              }
          }
          GAME();
          if (player % 2 == 0)
          {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
              SearchSus(5, 5, "~/IMG/2.png");
          }
          else
          {
              SearchSus(5, 5, "~/IMG/1.png");
          }
        }//[5,5]
        protected void BF7_Click(object sender, ImageClickEventArgs e)
        {
          ImageButton button = (ImageButton)sender;
          if (button.ImageUrl == "")
          {
              if (player % 2 == 0)
              {
                  button.ImageUrl = "~/IMG/1.png";//NEGRO
                  player++;
              }
              else
              {
                  button.ImageUrl = "~/IMG/2.png";//BLANCO
                  player++;
              }
          }
          GAME();
          if (player % 2 == 0)
          {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
              SearchSus(6, 5, "~/IMG/2.png");
          }
          else
          {
              SearchSus(6, 5, "~/IMG/1.png");
          }
        }//[6,5]
        protected void BF8_Click(object sender, ImageClickEventArgs e)
        {
          ImageButton button = (ImageButton)sender;
          if (button.ImageUrl == "")
          {
              if (player % 2 == 0)
              {
                  button.ImageUrl = "~/IMG/1.png";//NEGRO
                  player++;
              }
              else
              {
                  button.ImageUrl = "~/IMG/2.png";//BLANCO
                  player++;
              }
          }
          GAME();
          if (player % 2 == 0)
          {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
              SearchSus(7, 5, "~/IMG/2.png");
          }
          else
          {
              SearchSus(7, 5, "~/IMG/1.png");
          }
        }//[7,5]


        protected void BG1_Click(object sender, ImageClickEventArgs e)
        {
          ImageButton button = (ImageButton)sender;
          if (button.ImageUrl == "")
          {
              if (player % 2 == 0)
              {
                  button.ImageUrl = "~/IMG/1.png";//NEGRO
                  player++;
              }
              else
              {
                  button.ImageUrl = "~/IMG/2.png";//BLANCO
                  player++;
              }
          }
          GAME();
          if (player % 2 == 0)
          {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
              SearchSus(0, 6, "~/IMG/2.png");
          }
          else
          {
              SearchSus(0, 6, "~/IMG/1.png");
          }
        }//[0,6]
        protected void BG2_Click(object sender, ImageClickEventArgs e)
        {
          ImageButton button = (ImageButton)sender;
          if (button.ImageUrl == "")
          {
              if (player % 2 == 0)
              {
                  button.ImageUrl = "~/IMG/1.png";//NEGRO
                  player++;
              }
              else
              {
                  button.ImageUrl = "~/IMG/2.png";//BLANCO
                  player++;
              }
          }
          GAME();
          if (player % 2 == 0)
          {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
              SearchSus(1, 6, "~/IMG/2.png");
          }
          else
          {
              SearchSus(1, 6, "~/IMG/1.png");
          }
        }//[1,6]
        protected void BG3_Click(object sender, ImageClickEventArgs e)
        {
          ImageButton button = (ImageButton)sender;
          if (button.ImageUrl == "")
          {
              if (player % 2 == 0)
              {
                  button.ImageUrl = "~/IMG/1.png";//NEGRO
                  player++;
              }
              else
              {
                  button.ImageUrl = "~/IMG/2.png";//BLANCO
                  player++;
              }
          }
          GAME();
          if (player % 2 == 0)
          {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
              SearchSus(2, 6, "~/IMG/2.png");
          }
          else
          {
              SearchSus(2, 6, "~/IMG/1.png");
          }
        }//[2,6]
        protected void BG4_Click(object sender, ImageClickEventArgs e)
        {
          ImageButton button = (ImageButton)sender;
          if (button.ImageUrl == "")
          {
              if (player % 2 == 0)
              {
                  button.ImageUrl = "~/IMG/1.png";//NEGRO
                  player++;
              }
              else
              {
                  button.ImageUrl = "~/IMG/2.png";//BLANCO
                  player++;
              }
          }
          GAME();
          if (player % 2 == 0)
          {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
              SearchSus(3, 6, "~/IMG/2.png");
          }
          else
          {
              SearchSus(3, 6, "~/IMG/1.png");
          }
        }//[3,6]
        protected void BG5_Click(object sender, ImageClickEventArgs e)
        {
          ImageButton button = (ImageButton)sender;
          if (button.ImageUrl == "")
          {
              if (player % 2 == 0)
              {
                  button.ImageUrl = "~/IMG/1.png";//NEGRO
                  player++;
              }
              else
              {
                  button.ImageUrl = "~/IMG/2.png";//BLANCO
                  player++;
              }
          }
          GAME();
          if (player % 2 == 0)
          {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
              SearchSus(4, 6, "~/IMG/2.png");
          }
          else
          {
              SearchSus(4, 6, "~/IMG/1.png");
          }
        }//[4,6]
        protected void BG6_Click(object sender, ImageClickEventArgs e)
        {
          ImageButton button = (ImageButton)sender;
          if (button.ImageUrl == "")
          {
              if (player % 2 == 0)
              {
                  button.ImageUrl = "~/IMG/1.png";//NEGRO
                  player++;
              }
              else
              {
                  button.ImageUrl = "~/IMG/2.png";//BLANCO
                  player++;
              }
          }
          GAME();
          if (player % 2 == 0)
          {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
              SearchSus(5, 6, "~/IMG/2.png");
          }
          else
          {
              SearchSus(5, 6, "~/IMG/1.png");
          }
        }//[5,6]
        protected void BG7_Click(object sender, ImageClickEventArgs e)
        {
          ImageButton button = (ImageButton)sender;
          if (button.ImageUrl == "")
          {
              if (player % 2 == 0)
              {
                  button.ImageUrl = "~/IMG/1.png";//NEGRO
                  player++;
              }
              else
              {
                  button.ImageUrl = "~/IMG/2.png";//BLANCO
                  player++;
              }
          }
          GAME();
          if (player % 2 == 0)
          {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
              SearchSus(6, 6, "~/IMG/2.png");
          }
          else
          {
              SearchSus(6, 6, "~/IMG/1.png");
          }
        }//[6,6]
        protected void BG8_Click(object sender, ImageClickEventArgs e)
        {
          ImageButton button = (ImageButton)sender;
          if (button.ImageUrl == "")
          {
              if (player % 2 == 0)
              {
                  button.ImageUrl = "~/IMG/1.png";//NEGRO
                  player++;
              }
              else
              {
                  button.ImageUrl = "~/IMG/2.png";//BLANCO
                  player++;
              }
          }
          GAME();
          if (player % 2 == 0)
          {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
              SearchSus(7, 6, "~/IMG/2.png");
          }
          else
          {
              SearchSus(7, 6, "~/IMG/1.png");
          }
        }//[7,6]


        protected void BH1_Click(object sender, ImageClickEventArgs e)
        {
          ImageButton button = (ImageButton)sender;
          if (button.ImageUrl == "")
          {
              if (player % 2 == 0)
              {
                  button.ImageUrl = "~/IMG/1.png";//NEGRO
                  player++;
              }
              else
              {
                  button.ImageUrl = "~/IMG/2.png";//BLANCO
                  player++;
              }
          }
          GAME();
          if (player % 2 == 0)
          {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
              SearchSus(0, 7, "~/IMG/2.png");
          }
          else
          {
              SearchSus(0, 7, "~/IMG/1.png");
          }
        }//[0,7]
        protected void BH2_Click(object sender, ImageClickEventArgs e)
        {
          ImageButton button = (ImageButton)sender;
          if (button.ImageUrl == "")
          {
              if (player % 2 == 0)
              {
                  button.ImageUrl = "~/IMG/1.png";//NEGRO
                  player++;
              }
              else
              {
                  button.ImageUrl = "~/IMG/2.png";//BLANCO
                  player++;
              }
          }
          GAME();
          if (player % 2 == 0)
          {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
              SearchSus(1, 7, "~/IMG/2.png");
          }
          else
          {
              SearchSus(1, 7, "~/IMG/1.png");
          }
        }//[1,7]
        protected void BH3_Click(object sender, ImageClickEventArgs e)
        {
          ImageButton button = (ImageButton)sender;
          if (button.ImageUrl == "")
          {
              if (player % 2 == 0)
              {
                  button.ImageUrl = "~/IMG/1.png";//NEGRO
                  player++;
              }
              else
              {
                  button.ImageUrl = "~/IMG/2.png";//BLANCO
                  player++;
              }
          }
          GAME();
          if (player % 2 == 0)
          {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
              SearchSus(2, 7, "~/IMG/2.png");
          }
          else
          {
              SearchSus(2, 7, "~/IMG/1.png");
          }
        }//[2,7]
        protected void BH4_Click(object sender, ImageClickEventArgs e)
        {
          ImageButton button = (ImageButton)sender;
          if (button.ImageUrl == "")
          {
              if (player % 2 == 0)
              {
                  button.ImageUrl = "~/IMG/1.png";//NEGRO
                  player++;
              }
              else
              {
                  button.ImageUrl = "~/IMG/2.png";//BLANCO
                  player++;
              }
          }
          GAME();
          if (player % 2 == 0)
          {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
              SearchSus(3, 7, "~/IMG/2.png");
          }
          else
          {
              SearchSus(3, 7, "~/IMG/1.png");
          }
        }//[3,7]
        protected void BH5_Click(object sender, ImageClickEventArgs e)
        {
          ImageButton button = (ImageButton)sender;
          if (button.ImageUrl == "")
          {
              if (player % 2 == 0)
              {
                  button.ImageUrl = "~/IMG/1.png";//NEGRO
                  player++;
              }
              else
              {
                  button.ImageUrl = "~/IMG/2.png";//BLANCO
                  player++;
              }
          }
          GAME();
          if (player % 2 == 0)
          {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
              SearchSus(4, 7, "~/IMG/2.png");
          }
          else
          {
              SearchSus(4, 7, "~/IMG/1.png");
          }
        }//[4,7]
        protected void BH6_Click(object sender, ImageClickEventArgs e)
        {
          ImageButton button = (ImageButton)sender;
          if (button.ImageUrl == "")
          {
              if (player % 2 == 0)
              {
                  button.ImageUrl = "~/IMG/1.png";//NEGRO
                  player++;
              }
              else
              {
                  button.ImageUrl = "~/IMG/2.png";//BLANCO
                  player++;
              }
          }
          GAME();
          if (player % 2 == 0)
          {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
              SearchSus(5, 7, "~/IMG/2.png");
          }
          else
          {
              SearchSus(5, 7, "~/IMG/1.png");
          }
        }//[5,7]
        protected void BH7_Click(object sender, ImageClickEventArgs e)
        {
          ImageButton button = (ImageButton)sender;
          if (button.ImageUrl == "")
          {
              if (player % 2 == 0)
              {
                  button.ImageUrl = "~/IMG/1.png";//NEGRO
                  player++;
              }
              else
              {
                  button.ImageUrl = "~/IMG/2.png";//BLANCO
                  player++;
              }
          }
          GAME();
          if (player % 2 == 0)
          {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
              SearchSus(6, 7, "~/IMG/2.png");
          }
          else
          {
              SearchSus(6, 7, "~/IMG/1.png");
          }
        }//[6,7]
        protected void BH8_Click(object sender, ImageClickEventArgs e)
        {
          ImageButton button = (ImageButton)sender;
          if (button.ImageUrl == "")
          {
              if (player % 2 == 0)
              {
                  button.ImageUrl = "~/IMG/1.png";//NEGRO
                  player++;
              }
              else
              {
                  button.ImageUrl = "~/IMG/2.png";//BLANCO
                  player++;
              }
          }
          GAME();
          if (player % 2 == 0)
          {//YA AUMENTO PERO NECEISTO QUE LO QUE LE DE CLICK SE QUEDE EN EL ANTERIOR COLOR
              SearchSus(7, 7, "~/IMG/2.png");
          }
          else
          {
              SearchSus(7, 7, "~/IMG/1.png");
          }
        }//[7,7]
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
