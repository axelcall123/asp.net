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
     class Help : System.Web.UI.Page
    {
        /*static string X;
        static string Y;

        public String GetX()
        {
            X = (String)(Context.Session["N"]);
            //return Request.QueryString["N"].ToString();
            return X;
        }

        public String Gety()
        {
            Y = (String)(Context.Session["M"]);
            //return Request.QueryString["M"].ToString();
            return Y;
        }*/
    }

    public partial class Extreme : System.Web.UI.Page
    {
        
        String texto = "";//CONSOLA
        ///VARIABLES/////
        static String[] PlayerUno = new String[5];//COLROES P1
        static String[] PlayerDos = new String[5];//COLORES P2
        static int PU = 0;
        static int PD = 0;
        static int Tn=8 ;
        static int Tm=6 ;
        

        /*static int Tn = help.GetX();
        static int Tm = help.GetY();*/
        //MATRIZ POSICIONES PARA RELLENAR
        static char[,] XmasM = new char[Tn, Tm]; //X+
        static char[,] XmenM = new char[Tn, Tm]; //X-
        static char[,] YmasM = new char[Tn, Tm]; //Y+
        static char[,] YmenM = new char[Tn, Tm]; //Y-
        ///////
        static char[,] YmasXmenM = new char[Tn, Tm];//Y+X-
        static char[,] YmenXmenM = new char[Tn, Tm];//Y-X-
        static char[,] YmenXmasM = new char[Tn, Tm];//Y-X+
        static char[,] YmasXmasM = new char[Tn, Tm];//Y+X+
        //TURNOS QUE PASAN
        static int turno = 0;//
        //GENERAR
        ImageButton[,] CUADROS = new ImageButton[Tn, Tm];//MATRIZ CUADROS
        ImageButton[,] MARCO = new ImageButton[Tn + 2, Tm + 2];//MATRIZ NUMERO LETRAS
        static Char[,] TAB = new char[Tn, Tm];//MATRIZ DE AYUDA PARA LAS REGLAS DE OTHELLO
        Panel[] PANEL = new Panel[(Tm + 2)];//DIVS
        //BORRAR
        public void borrar()
        {
            for (int x = 0; x < Tn; x++)
            {
                for (int y = 0; y < Tm; y++)
                {
                    XmasM[x, y] = ' ';
                    XmenM[x, y] = ' ';
                    YmasM[x, y] = ' ';
                    YmenM[x, y] = ' ';
                    YmasXmenM[x, y] = ' ';
                    YmenXmenM[x, y] = ' ';
                    YmenXmasM[x, y] = ' ';
                    YmasXmasM[x, y] = ' ';
                }
            }
        }
        //CUATRO PASOS
        public void Muerto() {
            //MATRIZ N*M
            /*for (int x = 0; x < n; x++)
                    {
                        for (int y = 0; y < m; y++)
                        {
                            texto = texto +"|."+TAB[x, y]+".|";
                        }
                        texto = texto + "<br>";
                        TT.Text = texto;
                    }*/
            ////MATRIZ N*M PARA EL TABLERO EN TEXTO
            ///
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
                        if (y == 0 || y == (m + 2 - 1))
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
        } //CODIGO MUERTO
        public void PCuaPasos() {//PRIMERO CUATRO PASOS RELLENAR CUATRO BOTONES
            PlayerUno[0] = "azul";
            PlayerUno[1] = "rojo";
            PlayerUno[2] = "amarillo";
            //////
            PlayerDos[0] = "cafe";
            PlayerDos[1] = "celeste";
            /////
            //CUADROS[(n / 2), (m / 2)].Enabled = true;

            if (turno == 0)
            {
                CUADROS[(Tn / 2) - 1, (Tm / 2) - 1].Enabled = true;
                CUADROS[(Tn / 2) - 1, (Tm / 2) - 1].Click += delegate
                {
                    PasarColor((Tn / 2) - 1, (Tm / 2) - 1);
                    CUADROS[(Tn / 2) - 1, (Tm / 2)].Enabled = true;
                    CUADROS[(Tn / 2) - 1, (Tm / 2) - 1].Enabled = false;
                };

            }
            else if (turno == 1)
            {
                CUADROS[(Tn / 2) - 1, (Tm / 2)].Click += delegate
                {
                    PasarColor((Tn / 2) - 1, (Tm / 2));
                    CUADROS[(Tn / 2), (Tm / 2)].Enabled = true;
                    CUADROS[(Tn / 2) - 1, (Tm / 2)].Enabled = false;
                };

            }
            else if (turno == 2)
            {
                CUADROS[(Tn / 2), (Tm / 2)].Click += delegate
                {
                    PasarColor((Tn / 2), (Tm / 2));
                    CUADROS[(Tn / 2), (Tm / 2) - 1].Enabled = true;
                    CUADROS[(Tn / 2), (Tm / 2)].Enabled = false;
                };

            }
            else if (turno == 3) {//INICIALIZAR
                CUADROS[(Tn / 2), (Tm / 2) - 1].Click += delegate
                  {
                      PasarColor((Tn / 2), (Tm / 2) - 1);

                      CUADROS[(Tn / 2), (Tm / 2) - 2].Enabled = true;
                      CUADROS[(Tn / 2) - 2, (Tm / 2)].Enabled = true;
                      CUADROS[(Tn / 2) - 1, (Tm / 2) + 1].Enabled = true;
                      CUADROS[(Tn / 2) + 1, (Tm / 2) - 1].Enabled = true;
                      CUADROS[(Tn / 2), (Tm / 2) - 1].Enabled = false;
                  };

            }
        }//PRIMEROS CUATROS PASOS
        public void PasarColor(int xPlayer, int yPlayer) {
            if (turno % 2 == 0)//PLAYER 1 BLANCO
            {
                Player1.Enabled = true;
                Player2.Enabled = false;
                if (PU < 3)
                {
                    CUADROS[xPlayer, yPlayer].ImageUrl = "~/IMG/EX/" + PlayerUno[PU] + ".png";
                    TAB[xPlayer, yPlayer] = 'B';
                    PU += 1;
                }
                else {
                    PU = 0;
                    CUADROS[xPlayer, yPlayer].ImageUrl = "~/IMG/EX/" + PlayerUno[PU] + ".png";
                    TAB[xPlayer, yPlayer] = 'B';
                }
            }
            else {//PLAYER 2 NEGRO
                Player1.Enabled = false;
                Player2.Enabled = true;
                if (PD < 2)
                {
                    CUADROS[xPlayer, yPlayer].ImageUrl = "~/IMG/EX/" + PlayerDos[PD] + ".png";
                    PD += 1;
                    TAB[xPlayer, yPlayer] = 'N';
                }
                else
                {
                    PD = 0;
                    CUADROS[xPlayer, yPlayer].ImageUrl = "~/IMG/EX/" + PlayerDos[PD] + ".png";
                    TAB[xPlayer, yPlayer] = 'N';
                }
            }

            turno += 1;
        }//PRIMEROS 4 PASOS
        //NO SE COMO LLAMARLO
        public void BuscarID(String id, Char BN)//BUSCA Y AYUDA A CLICK_FIRST
        {
            for (int x = 0; x < Tn; x++)
            {
                for (int y = 0; y < Tm; y++)
                {
                    if (CUADROS[x, y].ID == id)
                    {
                        TAB[x, y] = BN;
                        x = Tm;
                        break;
                    }
                }
            }
        }
        public void rellenar(int a, int b, char cambio,char aceptar) {//EJECUTA LAS REGLAS PARA RELLENAR
            XmasR(a + 1, b, cambio, aceptar);
            XmenR(a - 1, b, cambio, aceptar);
            YmasR(a, b + 1, cambio, aceptar);
            YmenR(a, b - 1, cambio, aceptar);

            YmasXmenR(a - 1, b + 1, cambio, aceptar);
            YmenXmenR(a - 1, b - 1, cambio, aceptar);
            YmenXmasR(a + 1, b - 1, cambio, aceptar);
            YmasXmasR(a + 1, b + 1, cambio, aceptar);
            borrar();
        }
        public void blancoNegro(int x,int y)
        {
            if (turno % 2 == 0) {
                rellenar(x,y,'B','N');
            }
            else{
                rellenar(x, y, 'N', 'B');
            }
        }
        public void Clik_F(object sender, ImageClickEventArgs e) {
            Player1.Enabled = true;
            Player2.Enabled = false;
            ImageButton button = (ImageButton)sender;
            for (int x = 0; x < Tn; x++) {
                for (int y = 0; y < Tm; y++)
                {
                    if (CUADROS[x, y].ID == button.ID)
                    {
                        TAB[x, y] = 'B';

                        if (x==(Tn / 2)&& y== (Tm / 2) - 2) {//1
                            button.ImageUrl = CUADROS[(Tn/2),(Tm/2)].ImageUrl;
                            TAB[(Tn/2), (Tm/2)-1] = 'B';
                        }
                        else if (x==(Tn / 2) - 2 && y== (Tm / 2)) {//2
                            button.ImageUrl = CUADROS[(Tn / 2), (Tm / 2)].ImageUrl;
                            TAB[(Tn / 2)-1, (Tm / 2)] = 'B';
                        }
                        else if (x==(Tn / 2) - 1 && y== (Tm / 2) + 1) {//3
                            button.ImageUrl = CUADROS[(Tn / 2)-1, (Tm / 2)-1].ImageUrl;
                            TAB[(Tn / 2)-1, (Tm / 2)] = 'B';
                        }
                        else if (x==(Tn / 2) + 1 && y== (Tm / 2) - 1) {//4
                            button.ImageUrl = CUADROS[(Tn / 2)-1, (Tm / 2)-1].ImageUrl;
                            TAB[(Tn / 2), (Tm / 2) - 1] = 'B';
                        }
                        x = Tn;
                        break;
                    }
                }
            }
            turno += 1;
            for (int x = 0; x < Tn; x++)
            {
                for (int y = 0; y < Tm; y++)
                {
                    texto = texto + "|." + TAB[x, y] + ".|";
                }
                texto = texto + "<br>";
            }
            EjecutarReglas();

        }
        public void Cliks(object sender, ImageClickEventArgs e)
        {
            ImageButton button = (ImageButton)sender;
            if (button.ImageUrl == "~/IMG/EX/z.png")
            {
                if (turno % 2 == 0)//PLAYER 1 BLANCO
                {//RELOJ
                    Player1.Enabled = true;
                    Player2.Enabled = false;
                    if (PU < 3)//LIMITE DE LOS COLORES
                    {
                        button.ImageUrl = "~/IMG/EX/" + PlayerUno[PU] + ".png";
                        String id = button.ID;
                        BuscarID(id, 'B');//AYUDA EN BUSCAR EN LA MATRIZ TAB PARA RELLENAR SI ES BLANCO O NEGRO
                        //TAB[xPlayer, yPlayer] = 'B';
                        PU += 1;
                    }
                    else
                    {//REGRESAR PRINCIPIO MATRIZ DE LOS COLORES
                        PU = 0;
                        button.ImageUrl = "~/IMG/EX/" + PlayerUno[PU] + ".png";
                        String id = button.ID;
                        BuscarID(id, 'B');
                        //TAB[xPlayer, yPlayer] = 'B';
                    }
                }
                else
                {//PLAYER 2 NEGRO
                    //RELOJ
                    Player1.Enabled = false;
                    Player2.Enabled = true;
                    if (PD < 2)//LIMITE DE LOS COLORES
                    {
                        button.ImageUrl = "~/IMG/EX/" + PlayerDos[PD] + ".png";
                        PD += 1;
                        String id = button.ID;
                        BuscarID(id, 'N');
                        //TAB[xPlayer, yPlayer] = 'N';
                    }
                    else
                    {//REGRESAR PRINCIPIO MATRIZ DE LOS COLORES
                        PD = 0;
                        button.ImageUrl = "~/IMG/EX/" + PlayerDos[PD] + ".png";
                        String id = button.ID;
                        BuscarID(id, 'N');
                        //TAB[xPlayer, yPlayer] = 'N';
                    }
                }
            }
            turno += 1;
            for (int x = 0; x < Tn; x++)
            {
                for (int y = 0; y < Tm; y++)
                {
                    if (CUADROS[x, y].ID== button.ID) {
                        blancoNegro(x, y);//MANDA POSICIONES Y VE EL BLANCO Y NEGRO
                        x = Tn;
                        break;
                    }
                }
            }
            for (int x = 0; x < Tn; x++)
            {
                for (int y = 0; y < Tm; y++)
                {
                    texto = texto + "|." + TAB[x, y] + ".|";
                }
                texto = texto + "<br>";
            }
            EjecutarReglas();
        }
        //REGLAS DEL JUEGO SIGUIENTE POSICION VERDADERA
        public void Xmas(int x, int y, Char nb)
        {
            if (x < Tn)    
            {//CAUSE ERROR POSICON
                if (TAB[x,y].Equals(nb))
                {//SIG COLOR ES DIFERENTE
                    if (x + 1 < Tn) {
                        if (TAB[x + 1, y].Equals('*')) {//SI ESTA VACIO
                            texto = texto + CUADROS[x+1, y].ID + " Xmas T<br>";
                            CUADROS[x + 1, y].Enabled = true;
                        }
                        else if (TAB[x + 1, y].Equals(nb)){
                            Xmas(x + 1, y, nb);
                        }
                    }
                }
            }
        }
        public void Ymas(int x, int y, Char nb)
        {
            if (y < Tm)
            {//CAUSE ERROR POSICON
                
                if (TAB[x, y].Equals(nb))
                {//SIG COLOR ES DIFERENTE
                    if (y + 1 < Tm)
                    {                       
                        if (TAB[x, y+1].Equals('*'))
                        {
                            texto = texto + CUADROS[x, y+1].ID + " Ymas T<br>";
                            CUADROS[x, y+1].Enabled = true;
                        }
                        else if (TAB[x, y+1].Equals(nb))
                        {
                            Ymas(x, y+1, nb);
                        }
                    }
                }
            }
        }
        public void Xmen(int x, int y, Char nb)
        {
            if (x >= 0)
            {//CAUSE ERROR POSICON
                if (TAB[x, y].Equals(nb))
                {//SIG COLOR ES DIFERENTE
                    if (x - 1 >= 0)
                    {
                        if (TAB[x - 1, y].Equals('*'))
                        {
                            texto = texto + CUADROS[x-1,y].ID +" Xmen T<br>";
                            CUADROS[x - 1, y].Enabled = true;
                        }
                        else if (TAB[x - 1, y].Equals(nb))
                        {
                            Xmen(x - 1, y, nb);
                        }
                    }
                }
            }
        }
        public void Ymen(int x, int y, Char nb)
        {
            if (y >= 0)
            {//CAUSE ERROR POSICON
                if (TAB[x, y].Equals(nb))
                {//SIG COLOR ES DIFERENTE
                    if (y - 1 >= 0)
                    {
                        if (TAB[x, y - 1].Equals('*'))
                        {
                            texto = texto + CUADROS[x, y-1].ID + " Ymen T<br>";
                            CUADROS[x, y - 1].Enabled = true;
                        }
                        else if (TAB[x, y - 1].Equals(nb))
                        {
                            Ymen(x, y - 1, nb);
                        }
                    }
                }
            }
        }

        public void YmasXmas(int x, int y, Char nb)
        {
            if (x < Tn && y<Tm)
            {//CAUSE ERROR POSICON
                if (TAB[x, y].Equals(nb))
                {//SIG COLOR ES DIFERENTE
                    if (x + 1 < Tn && y+1<Tm)
                    {
                        if (TAB[x + 1, y+1].Equals('*'))
                        {
                            texto = texto + CUADROS[x + 1, y+1].ID + " Xmas T<br>";
                            CUADROS[x + 1, y+1].Enabled = true;
                        }
                        else if (TAB[x + 1, y+1].Equals(nb))
                        {
                            YmasXmas(x + 1, y+1, nb);
                        }
                    }
                }
            }
        }
        public void YmenXmen(int x, int y, Char nb)
        {
            if (x >= 0 && y >= 0)
            {//CAUSE ERROR POSICON
                if (TAB[x, y].Equals(nb))
                {//SIG COLOR ES DIFERENTE
                    if (x - 1 >= 0 && y - 1 >= 0)
                    {
                        if (TAB[x - 1, y - 1].Equals('*'))
                        {
                            texto = texto + CUADROS[x - 1, y - 1].ID + " Xmas T<br>";
                            CUADROS[x - 1, y - 1].Enabled = true;
                        }
                        else if (TAB[x - 1, y - 1].Equals(nb))
                        {
                            YmenXmen(x - 1, y - 1, nb);
                        }
                    }
                }
            }
        }
        public void YmenXmas(int x, int y, Char nb)
        {
            if (x < Tn && y >= 0)
            {//CAUSE ERROR POSICON
                if (TAB[x, y].Equals(nb))
                {//SIG COLOR ES DIFERENTE
                    if (x + 1 < Tn && y - 1 >= 0)
                    {
                        if (TAB[x + 1, y - 1].Equals('*'))
                        {
                            texto = texto + CUADROS[x + 1, y - 1].ID + " Xmas T<br>";
                            CUADROS[x + 1, y - 1].Enabled = true;
                        }
                        else if (TAB[x + 1, y - 1].Equals(nb))
                        {
                            YmasXmas(x + 1, y - 1, nb);
                        }
                    }
                }
            }
        }
        public void YmasXmen(int x, int y, Char nb)
        {
            if (x >= 0 && y < Tm)
            {//CAUSE ERROR POSICON
                if (TAB[x, y].Equals(nb))
                {//SIG COLOR ES DIFERENTE
                    if (x - 1 >= 0 && y + 1 < Tm)
                    {
                        if (TAB[x - 1, y + 1].Equals('*'))
                        {
                            texto = texto + CUADROS[x - 1, y + 1].ID + " Xmas T<br>";
                            CUADROS[x - 1, y + 1].Enabled = true;
                        }
                        else if (TAB[x - 1, y + 1].Equals(nb))
                        {
                            YmasXmas(x - 1, y + 1, nb);
                        }
                    }
                }
            }
        }
        //RELLENAR
        public void XmasR(int x, int y, Char nb, Char BN)
        {
            if (x < Tn)
            {
                if (TAB[x, y].Equals(nb)) {//COLOR CONTRARIO AL QUE SE ESTA
                    XmasM[x, y] = 'N';//MATRIZ QUE AYUDA A VER QUE CUAROS ESTAN PARA RELLENAR
                    if (x + 1 < Tn)
                    {
                        if (TAB[x + 1, y].Equals(BN))
                        {//
                            for (int a = 0; a < Tn; a++)
                            {
                                for (int b = 0; b < Tm; b++)
                                {
                                    if (XmasM[a, b] == 'N') {//SI ES PARA RELLENAR HAS ESTO
                                        String color = CUADROS[x + 1, y].ImageUrl;
                                        TAB[a, b] = BN;//MATRIZ AYUDA
                                        CUADROS[a, b].ImageUrl =color;//RELLNAR DEL MISMO COLOR
                                    }
                                }
                            }
                        }
                        else if (TAB[x+1, y].Equals(nb))//NEXT POSICION
                        {
                            XmasM[x+1, y] = 'N';
                            XmasR(x+1,y,nb,BN);
                        }
                    }
                    
                }
            }
        }
        public void YmasR(int x, int y, Char nb, Char BN)
        {
            if (y < Tm)
            {
                if (TAB[x, y].Equals(nb))
                {//COLOR CONTRARIO AL QUE SE ESTA
                    YmasM[x, y] = 'N';
                    if (y + 1 < Tm)
                    {
                        if (TAB[x, y + 1].Equals(BN))
                        {//
                            for (int a = 0; a < Tn; a++)
                            {
                                for (int b = 0; b < Tm; b++)
                                {
                                    if (YmasM[a, b] == 'N')
                                    {
                                        String color = CUADROS[x, y + 1].ImageUrl;
                                        TAB[a, b] = BN;//MATRIZ AYUDA
                                        CUADROS[a, b].ImageUrl = color;//RELLNAR DEL MISMO COLOR
                                    }
                                }
                            }
                        }
                        else if (TAB[x, y + 1].Equals(nb))//NEXT POSICION
                        {
                            YmasM[x, y + 1] = 'N';
                            YmasR(x, y + 1, nb, BN);
                        }
                    }

                }
            }
        }
        public void XmenR(int x, int y, Char nb, Char BN)
        {
            if (x >= 0)
            {
                if (TAB[x, y].Equals(nb))
                {//COLOR CONTRARIO AL QUE SE ESTA
                    XmenM[x, y] = 'N';
                    if (x - 1 >= 0)
                    {
                        if (TAB[x - 1, y].Equals(BN))
                        {//
                            for (int a = 0; a < Tn; a++)
                            {
                                for (int b = 0; b < Tm; b++)
                                {
                                    if (XmenM[a, b] == 'N')
                                    {
                                        String color = CUADROS[x - 1, y].ImageUrl;
                                        TAB[a, b] = BN;//MATRIZ AYUDA
                                        CUADROS[a, b].ImageUrl = color;//RELLNAR DEL MISMO COLOR
                                    }
                                }
                            }
                        }
                        else if (TAB[x - 1, y].Equals(nb))//NEXT POSICION
                        {
                            XmenM[x - 1, y] = 'N';
                            XmenR(x - 1, y, nb, BN);
                        }
                    }

                }
            }
        }
        public void YmenR(int x, int y, Char nb, Char BN)
        {
            if (y >= 0)
            {
                if (TAB[x, y].Equals(nb))
                {//COLOR CONTRARIO AL QUE SE ESTA
                    YmenM[x, y] = 'N';
                    if (y - 1 >= 0)
                    {
                        if (TAB[x, y - 1].Equals(BN))
                        {//
                            for (int a = 0; a < Tn; a++)
                            {
                                for (int b = 0; b < Tm; b++)
                                {
                                    if (YmenM[a, b] == 'N')
                                    {
                                        String color = CUADROS[x, y - 1].ImageUrl;
                                        TAB[a, b] = BN;//MATRIZ AYUDA
                                        CUADROS[a, b].ImageUrl = color;//RELLNAR DEL MISMO COLOR
                                    }
                                }
                            }
                        }
                        else if (TAB[x, y - 1].Equals(nb))//NEXT POSICION
                        {
                            YmenM[x, y - 1] = 'N';
                            YmenR(x, y - 1, nb, BN);
                        }
                    }

                }
            }
        }

        public void YmasXmasR(int x, int y, Char nb, Char BN)
        {
            if (y < Tm && x<Tn)
            {
                if (TAB[x, y].Equals(nb))
                {//COLOR CONTRARIO AL QUE SE ESTA
                    YmasXmasM[x, y] = 'N';
                    if (y + 1 < Tm && x +1< Tn)
                    {
                        if (TAB[x+1, y + 1].Equals(BN))
                        {//
                            for (int a = 0; a < Tn; a++)
                            {
                                for (int b = 0; b < Tm; b++)
                                {
                                    if (YmasXmasM[a, b] == 'N')
                                    {
                                        String color = CUADROS[x+1, y + 1].ImageUrl;
                                        TAB[a, b] = BN;//MATRIZ AYUDA
                                        CUADROS[a, b].ImageUrl = color;//RELLNAR DEL MISMO COLOR
                                    }
                                }
                            }
                        }
                        else if (TAB[x+1, y + 1].Equals(nb))//NEXT POSICION
                        {
                            YmasXmasM[x+1, y + 1] = 'N';
                            YmasXmasR(x+1, y + 1, nb, BN);
                        }
                    }

                }
            }
        }
        public void YmenXmenR(int x, int y, Char nb, Char BN)
        {
            if (y >= 0 && x>=0)
            {
                if (TAB[x, y].Equals(nb))
                {//COLOR CONTRARIO AL QUE SE ESTA
                    YmenXmenM[x, y] = 'N';
                    if (y - 1 >= 0 && x -1>= 0)
                    {
                        if (TAB[x-1, y - 1].Equals(BN))
                        {//
                            for (int a = 0; a < Tn; a++)
                            {
                                for (int b = 0; b < Tm; b++)
                                {
                                    if (YmenXmenM[a, b] == 'N')
                                    {
                                        String color = CUADROS[x-1, y - 1].ImageUrl;
                                        TAB[a, b] = BN;//MATRIZ AYUDA
                                        CUADROS[a, b].ImageUrl = color;//RELLNAR DEL MISMO COLOR
                                    }
                                }
                            }
                        }
                        else if (TAB[x-1, y - 1].Equals(nb))//NEXT POSICION
                        {
                            YmenXmenM[x-1, y - 1] = 'N';
                            YmenXmenR(x-1, y - 1, nb, BN);
                        }
                    }

                }
            }
        }
        public void YmenXmasR(int x, int y, Char nb, Char BN)
        {
            if (y >= 0 && x < Tn)
            {
                if (TAB[x, y].Equals(nb))
                {//COLOR CONTRARIO AL QUE SE ESTA
                    YmenXmasM[x, y] = 'N';
                    if (y-1 >= 0 && x + 1 < Tn)
                    {
                        if (TAB[x + 1, y - 1].Equals(BN))
                        {//
                            for (int a = 0; a < Tn; a++)
                            {
                                for (int b = 0; b < Tm; b++)
                                {
                                    if (YmenXmasM[a, b] == 'N')
                                    {
                                        String color = CUADROS[x + 1, y - 1].ImageUrl;
                                        TAB[a, b] = BN;//MATRIZ AYUDA
                                        CUADROS[a, b].ImageUrl = color;//RELLNAR DEL MISMO COLOR
                                    }
                                }
                            }
                        }
                        else if (TAB[x + 1, y - 1].Equals(nb))//NEXT POSICION
                        {
                            YmenXmasM[x + 1, y - 1] = 'N';
                            YmenXmasR(x + 1, y - 1, nb, BN);
                        }
                    }

                }
            }
        }
        public void YmasXmenR(int x, int y, Char nb, Char BN)
        {
            if (y < Tm && x >= 0)
            {
                if (TAB[x, y].Equals(nb))
                {//COLOR CONTRARIO AL QUE SE ESTA
                    YmasXmenM[x, y] = 'N';
                    if (y + 1 < Tm && x -1>= 0)
                    {
                        if (TAB[x - 1, y + 1].Equals(BN))
                        {//
                            for (int a = 0; a < Tn; a++)
                            {
                                for (int b = 0; b < 8; Tm++)
                                {
                                    if (YmasXmenM[a, b] == 'N')
                                    {
                                        String color = CUADROS[x - 1, y + 1].ImageUrl;
                                        TAB[a, b] = BN;//MATRIZ AYUDA
                                        CUADROS[a, b].ImageUrl = color;//RELLNAR DEL MISMO COLOR
                                    }
                                }
                            }
                        }
                        else if (TAB[x - 1, y + 1].Equals(nb))//NEXT POSICION
                        {
                            YmasXmenM[x - 1, y + 1] = 'N';
                            YmasXmenR(x - 1, y + 1, nb, BN);
                        }
                    }

                }
            }
        }
        //REGLAS
        public void EjecutarReglas()//EJECUTA LOS BOTONES QUE SE PUEDEN ACTIVAR
        {
            for (int x = 0; x < Tn; x++)
            {
                for (int y = 0; y < Tm; y++)
                {
                    CUADROS[x, y].Enabled = false;
                }
            }

            for (int x = 0; x < Tn; x++)
            {
                for (int y = 0; y < Tm; y++)
                {
                    if (turno % 2 == 0)//BLANCO
                    {
                        if (TAB[x, y].Equals('B')){
                            texto =texto+ "BLANCO<br>";
                            Xmas(x + 1, y, 'N');
                            Xmen(x - 1, y, 'N');
                            Ymas(x, y + 1, 'N');
                            Ymen(x, y - 1, 'N');
                            
                            YmasXmen(x - 1, y + 1, 'N');
                            YmenXmen(x - 1, y - 1, 'N');
                            YmenXmas(x + 1, y - 1, 'N');
                            YmasXmas(x + 1, y + 1, 'N');
                        }
                    }
                    else {//NEGRO
                        if (TAB[x, y].Equals('N'))
                        {
                            texto = texto + "NEGRO<br>";
                            Xmas(x + 1, y, 'B');
                            Xmen(x - 1, y, 'B');
                            Ymas(x, y + 1, 'B');
                            Ymen(x, y - 1, 'B');

                            
                            YmasXmen(x - 1, y + 1, 'B');
                            YmenXmen(x - 1, y - 1, 'B');
                            YmenXmas(x + 1, y - 1, 'B');
                            YmasXmas(x + 1, y + 1, 'B');
                        }
                    }
                }
            }
            TT.Text = texto;
        }
        /*protected void Button1_Click(object sender, EventArgs e)
        {
            if (reloj % 2 == 0)
            {
                Player1.Enabled = true;
                Player2.Enabled = false;
            }
            else {
                Player1.Enabled = false;
                Player2.Enabled = true;
            }
            reloj ++;
        }*/
        protected void Player1_Tick(object sender, EventArgs e)
        {
            int segundos = int.Parse(P_1.Text);
            if (segundos < 1000)
            {
                P_1.Text = (segundos + 1).ToString();
            }
            else
            {
                Player1.Enabled = false;
            }
        }
        protected void Player2_Tick(object sender, EventArgs e)
        {
            int segundos = int.Parse(P_2.Text);
            if (segundos < 1000)
            {
                P_2.Text = (segundos + 1).ToString();
            }
            else
            {
                Player2.Enabled = false;
            }
        }
        //INICIO DE TODO
        protected void Page_Load(object sender, EventArgs e)//m*n m iz yy n abajo
        {
            
            /*Help h = new Help();
            TT.Text = "TEXTO: " + h.Gety() + " ; " + h.GetX();*/
            /*Tn = int.Parse(h.Gety());
            Tm = int.Parse(h.GetX());*/
            /*texto = texto + Request.QueryString["N"]+" Numero1<br>";
            texto = texto + Request.QueryString["M"] + " Numero2<br>";
            TT.Text = texto;*/
            int id1 = 97;
            for (int x = 0; x < (Tn + 2); x++)
            {
                PANEL[x] = new Panel();
                PANEL[x].CssClass = "Extreme";
                for (int y = 0; y < (Tm + 2); y++)
                {//test[x, y];
                    MARCO[x, y] = new ImageButton();//(2,m+2)
                    if (x == 0 || x == (Tn + 2 - 1))//*|A|B|C|D|E|*
                    {
                        if (y == 0 || y == (Tm + 2 - 1))//*|     |*
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
                            MARCO[x, y].ImageUrl = "~/IMG/Le/" + Char.ToString(Convert.ToChar(id1)) + ".png";
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
                        if (y == 0 || y == (Tm + 2 - 1))
                        {//1|       |1
                         //2|       |2
                         //3|       |3
                            if (y == 0)//1| 2| 3|
                            {
                                MARCO[x, y].ImageUrl = "~/IMG/Nu/" + x.ToString() + ".png";
                                MARCO[x, y].Enabled = false;
                                MARCO[x, y].Width = 30;
                                MARCO[x, y].Height = 30;
                                PANEL[x].Controls.Add(MARCO[x, y]);
                            }
                            else
                            {//|1 |2 |3
                                MARCO[x, y].ImageUrl = "~/IMG/Nu/" + x.ToString() + ".png";
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
                            CUADROS[x - 1, y - 1].Enabled = false;
                            CUADROS[x - 1, y - 1].ID = "B" + Char.ToString(Convert.ToChar(id1)) + x.ToString();
                            PANEL[x].Controls.Add(CUADROS[x - 1, y - 1]);
                            id1 += 1;
                        }

                    }
                }
                Panel1.Controls.Add(PANEL[x]);
                id1 = 97;
            }//RELLENA TODO

            if (turno < 4)
            {
                if (turno == 0)
                {
                    for (int x = 0; x < Tn; x++)
                    {
                        for (int y = 0; y < Tm; y++)
                        {
                            TAB[x, y] = '*';
                        }
                    }//RELLENO MATRIZ
                }   //SOLO PARA QUE RELLENE LOS ESPACIOS VACIOS
                PCuaPasos();
            }//PONER 4 FICHAS PRIMERAS
            else if (turno == 4)
            {//PONER EL INICIO DE LAS FICHAS Y REGLAS
                CUADROS[(Tn / 2), (Tm / 2) - 2].Click += new ImageClickEventHandler(this.Clik_F);
                CUADROS[(Tn / 2) - 2, (Tm / 2)].Click += new ImageClickEventHandler(this.Clik_F);
                CUADROS[(Tn / 2) - 1, (Tm / 2) + 1].Click += new ImageClickEventHandler(this.Clik_F);
                CUADROS[(Tn / 2) + 1, (Tm / 2) - 1].Click += new ImageClickEventHandler(this.Clik_F);
            }
            else
            {
                for (int x = 0; x < Tn; x++)
                {
                    for (int y = 0; y < Tm; y++)
                    {
                        CUADROS[x,y].Click += new ImageClickEventHandler(this.Cliks);
                    }
                }
            }
        }
        /*protected void Timer1_Tick(object sender, EventArgs e)
        {
            int seconds = int.Parse(Label1.Text);
            if (seconds > 0)
              Label1.Text = (seconds - 1).ToString();
            else
              Timer1.Enabled = false;
        }*/
    }
}