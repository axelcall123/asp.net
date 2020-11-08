using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GAME
{
    public partial class Torneo : System.Web.UI.Page
    {
        static int contador = 0;
        static int tamaño = 16;
        static String[] equipos =new String[tamaño];
        static String[,]  AllJugadores= new String[tamaño,3];
        protected void Page_Load(object sender, EventArgs e)
        {
            String nombreTorneo = Request.QueryString["Torn"];//NOMBRES DEL TORNEO
            String nombreEquipos = Request.QueryString["nEq"];//NOMBRE DE TODOS LOS EQUIPOS
            String jugadores = Request.QueryString["pla"];//JUGADORES
            tamaño = int.Parse(Request.QueryString["Tam"]);//Tamaño

            char[] nT = nombreEquipos.ToCharArray();
            char[] P = jugadores.ToCharArray();
            String union = "";
            int cont = 0;
            int cont2 = 0;
            //NOMBRE EQUIPOS
            for (int x = 0; x < nT.Length; x++)
            {
                if (nT[x].Equals(';'))
                {
                    equipos[cont] = union;
                    union = "";
                    cont++;
                }
                else
                {
                    union = union + nT[x].ToString();
                }
            }
            //JUGADORES
            union = "";
            cont = 0;
            cont2 = 0;
            for (int x = 0; x < P.Length; x++)
            {
                if (P[x].Equals(';'))
                {
                    if ((x + 1) % 3 == 0)
                    {
                        AllJugadores[cont2, cont] = union;
                        cont2++;
                        cont = 0;
                        union = "";
                    }
                    else
                    {
                        AllJugadores[cont2, cont] = union;
                        union = "";
                        cont++;
                    }
                }
                else
                {
                    union = union + P[x].ToString();
                }
            }

            if (tamaño == 16) {
                All.Visible = true;
                Verdad_2.Enabled = false;
                Verdad_3.Enabled = false;

                Ocho_U.Visible = true;
                Ocho_D.Visible = true;
                Cuatro_D.Visible = true;
                Cuatro_U.Visible = true;
                D_Uno_1.Text = equipos[0];
                D_Dos_1.Text = equipos[1];
                D_Tres_1.Text = equipos[2];
                D_Cuatro_1.Text = equipos[3];
                D_Cinco_1.Text = equipos[4];
                D_Seis_1.Text = equipos[5];
                D_Siete_1.Text = equipos[6];
                D_Ocho_1.Text = equipos[7];

                I_Uno_1.Text = equipos[8];
                I_Dos_1.Text = equipos[9];
                I_Tres_1.Text = equipos[10];
                I_Cuatro_1.Text = equipos[11];
                I_Cinco_1.Text = equipos[12];
                I_Seis_1.Text = equipos[13];
                I_Siete_1.Text = equipos[14];
                I_Ocho_1.Text = equipos[15];
                Verdad_2.Enabled = false;
            } else if (tamaño == 8) {
                All.Visible = true;
                Verdad.Enabled = false;
                Verdad_3.Enabled = false;
                Cuatro_D.Visible = true;
                Cuatro_U.Visible = true;

                D_Uno_2.Text = equipos[0];
                D_Dos_2.Text = equipos[1];
                D_Tres_2.Text = equipos[2];
                D_Cuatro_2.Text = equipos[3];

                I_Uno_2.Text = equipos[4];
                I_Dos_2.Text = equipos[5];
                I_Tres_2.Text = equipos[6];
                I_Cuatro_2.Text = equipos[7];
            }
            else if (tamaño == 4){
                All.Visible = true;
                Verdad.Enabled = false;
                Verdad_2.Enabled = false;

                D_Uno_3.Text = equipos[0];
                D_Dos_3.Text = equipos[1];

                I_Uno_3.Text = equipos[2];
                I_Dos_3.Text = equipos[3];
            }
        }
        //NUMERO 16
        protected void Verdad_Click(object sender, EventArgs e)
        {
            All.Visible = true;
            Ocho_U.Visible = true;
            Ocho_D.Visible = true;
            Cuatro_D.Visible = true;
            Cuatro_U.Visible = true;
            D_Uno_1.Text = "Team1";
            D_Dos_1.Text = "Team2";
            D_Tres_1.Text= "Team3";
            D_Cuatro_1.Text= "Team4";
            D_Cinco_1.Text= "Team5";
            D_Seis_1.Text= "Team6";
            D_Siete_1.Text= "Team7";
            D_Ocho_1.Text= "Team8";

            I_Uno_1.Text = "Team9";
            I_Dos_1.Text = "Team10";
            I_Tres_1.Text = "Team11";
            I_Cuatro_1.Text = "Team12";
            I_Cinco_1.Text = "Team13";
            I_Seis_1.Text = "Team14";
            I_Siete_1.Text = "Team15";
            I_Ocho_1.Text = "Team16";
            Verdad_2.Enabled = false;
        }
        //NUMERO OCHO
        protected void Verdad_2_Click(object sender, EventArgs e)
        {
            All.Visible = true;
            Verdad.Enabled = false;
            Cuatro_D.Visible = true;
            Cuatro_U.Visible = true;

            D_Uno_2.Text = "Team1";
            D_Dos_2.Text = "Team2";
            D_Tres_2.Text = "Team3";
            D_Cuatro_2.Text = "Team4";

            I_Uno_2.Text = "Team5";
            I_Dos_2.Text = "Team6";
            I_Tres_2.Text = "Team7";
            I_Cuatro_2.Text = "Team8";            
        }
        //NUMERO CUATRO
        protected void Verdad_3_Click(object sender, EventArgs e)
        {
            All.Visible = true;
            D_Uno_3.Text = "Team1";
            D_Dos_3.Text = "Team2";

            I_Uno_3.Text = "Team3";
            I_Dos_3.Text = "Team4";
        }
        protected void D_GanarT1_1_Click(object sender, EventArgs e)
        {
            D_GanarT1_2.Enabled = false;
            D_Uno_2.Text = "--Team1--";
            contador += 1;
        }
        protected void D_GanarT1_2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            D_GanarT1_1.Enabled = false;
            D_Uno_2.Text = "--Team2--";
            contador += 1;
        }
        protected void D_GanarT1_3_Click(object sender, EventArgs e)
        {
            D_GanarT1_4.Enabled = false;
            D_Dos_2.Text = "--Team3--";
            contador += 1;
        }
        protected void D_GanarT1_4_Click(object sender, EventArgs e)
        {
            D_GanarT1_3.Enabled = false;
            D_Dos_2.Text = "--Team4--";
            contador += 1;
        }
        protected void D_GanarT1_5_Click(object sender, EventArgs e)
        {
            D_GanarT1_6.Enabled = false;
            D_Tres_2.Text = "--Team5--";
            contador += 1;
        }
        protected void D_GanarT1_6_Click(object sender, EventArgs e)
        {
            D_GanarT1_5.Enabled = false;
            D_Tres_2.Text = "--Team6--";
            contador += 1;
        }
        protected void D_GanarT1_7_Click(object sender, EventArgs e)
        {
            D_GanarT1_8.Enabled = false;
            D_Cuatro_2.Text = "--Team7--";
            contador += 1;
        }
        protected void D_GanarT1_8_Click(object sender, EventArgs e)
        {
            D_GanarT1_7.Enabled = false;
            D_Cuatro_2.Text = "--Team8--";
            contador += 1;
        }
        //CUATRO
        protected void D_GanarT2_1_Click(object sender, EventArgs e)
        {
            D_GanarT2_2.Enabled = false;
            D_Uno_3.Text= D_Uno_2.Text;
        }
        protected void D_GanarT2_2_Click(object sender, EventArgs e)
        {
            D_GanarT2_1.Enabled = false;
            D_Uno_3.Text = D_Dos_2.Text;
        }
        protected void D_GanarT2_3_Click(object sender, EventArgs e)
        {
            D_GanarT2_4.Enabled = false;
            D_Dos_3.Text = D_Tres_2.Text;
        }
        protected void D_GanarT2_4_Click(object sender, EventArgs e)
        {
            D_GanarT2_3.Enabled = false;
            D_Dos_3.Text = D_Cuatro_2.Text;
        }
        //DOS
        protected void D_GanarT3_1_Click(object sender, EventArgs e)
        {
            D_GanarT3_2.Enabled = false;
            D_Uno_4.Text = D_Uno_3.Text;
        }
        protected void D_GanarT3_2_Click(object sender, EventArgs e)
        {
            D_GanarT3_1.Enabled = false;
            D_Uno_4.Text = D_Dos_3.Text;
        }

        //DOS
        protected void I_GanarT3_1_Click(object sender, EventArgs e)
        {
            I_GanarT3_2.Enabled = false;
            I_Uno_4.Text = I_Uno_3.Text;
        }

        protected void I_GanarT3_2_Click(object sender, EventArgs e)
        {
            I_GanarT3_1.Enabled = false;
            I_Uno_4.Text = I_Dos_3.Text;
        }
        //CUATRO
        protected void I_GanarT2_1_Click(object sender, EventArgs e)
        {//
            I_GanarT2_2.Enabled = false;
            I_Uno_3.Text = I_Uno_2.Text;
        }
        protected void I_GanarT2_2_Click(object sender, EventArgs e)
        {
            I_GanarT2_1.Enabled = false;
            I_Uno_3.Text = I_Dos_2.Text;
        }
        protected void I_GanarT2_3_Click(object sender, EventArgs e)
        {
            I_GanarT2_4.Enabled = false;
            I_Dos_3.Text = I_Tres_2.Text;
        }
        protected void I_GanarT2_4_Click(object sender, EventArgs e)
        {
            I_GanarT2_3.Enabled = false;
            I_Dos_3.Text = I_Cuatro_2.Text;
        }
        //OCHO
        protected void I_GanarT1_1_Click1(object sender, EventArgs e)
        {
            I_GanarT1_2.Enabled = false;
            I_Uno_2.Text = "--Team9--";
            contador += 1;
        }
        protected void I_GanarT1_2_Click(object sender, EventArgs e)
        {
            I_GanarT1_1.Enabled = false;
            I_Uno_2.Text = "--Team10--";
            contador += 1;
        }
        protected void I_GanarT1_3_Click(object sender, EventArgs e)
        {
            I_GanarT1_4.Enabled = false;
            I_Dos_2.Text = "--Team11--";
            contador += 1;
        }
        protected void I_GanarT1_4_Click(object sender, EventArgs e)
        {
            I_GanarT1_3.Enabled = false;
            I_Dos_2.Text = "--Team12--";
            contador += 1;
        }
        protected void I_GanarT1_5_Click(object sender, EventArgs e)
        {
            I_GanarT1_6.Enabled = false;
            I_Tres_2.Text = "--Team13--";
            contador += 1;
        }
        protected void I_GanarT1_6_Click(object sender, EventArgs e)
        {
            I_GanarT1_5.Enabled = false;
            I_Tres_2.Text = "--Team14--";
            contador += 1;
        }
        protected void I_GanarT1_7_Click(object sender, EventArgs e)
        {
            I_GanarT1_8.Enabled = false;
            I_Cuatro_2.Text = "--Team15--";
            contador += 1;
        }

        protected void I_GanarT1_8_Click(object sender, EventArgs e)
        {
            I_GanarT1_7.Enabled = false;
            I_Cuatro_2.Text = "--Team16--";
            contador += 1;
        }

        /////UNO
        protected void I_Uno_4_Click(object sender, EventArgs e)
        {
            
        }
        protected void D_GanarT4_1_Click(object sender, EventArgs e)
        {
        }
        protected void Cod_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < equipos.Length; x++)
            {
                d = d + equipos[x] + "<br>";
            }
            for (int x = 0; x < tamaño; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    d = d + AllJugadores[x, y] + "|";
                }
                d = d + "<br>";
            }
            d = d + "fin";
            T.Text = d;
        }

        static int cont1 = 0;
        static int cont2 = 0;
        static int cont3 = 0;
        static int cont4 = 0;
        static int cont5 = 0;
        static int cont6 = 0;
        static int cont7 = 0;
        static int cont8 = 0;
        static int cont9 = 0;
        static int cont10 = 0;
        static int cont11 = 0;
        static int cont12 = 0;
        static int contT13 = 0;
        static String d = "";
        protected void D_UB_1_1_Click(object sender, EventArgs e)
        {   //EQUIPO|| CPU O JUGADOR|| SI ES TORNEO|| 

            String equipo1 =D_Uno_1.Text;
            String equipo2 = D_Dos_1.Text;
            Boolean cpu = false;
            Boolean torneo = true;

            String u = "?id="+cpu;
            String d = "&Tu="+ equipo1;
            String t = "&Td="+ equipo2;
            String c = "&Torneo="+ torneo;
            String url = "window.open('Ocpu"+u+d+t+c + "', '_blank');";
            ScriptManager.RegisterStartupScript(this, this.GetType(), "OpenWindow", url, true);
        }
        
        protected void D_UB_3_1_Click(object sender, EventArgs e)
        {
            String equipo1 = D_Tres_1.Text;
            String equipo2 = D_Cuatro_1.Text;
            Boolean cpu = false;
            Boolean torneo = true;

            String u = "?id=" + cpu;
            String d = "&Tu=" + equipo1;
            String t = "&Td=" + equipo2;
            String c = "&Torneo=" + torneo;
            String url = "window.open('Ocpu" + u + d + t + c + "', '_blank');";
            ScriptManager.RegisterStartupScript(this, this.GetType(), "OpenWindow", url, true);
        }
        protected void D_UB_5_1_Click(object sender, EventArgs e)
        {

        }
        protected void D_UB_7_1_Click(object sender, EventArgs e)
        {

        }
        //
        protected void D_DB_1_1_Click(object sender, EventArgs e)
        {

        }
        protected void D_DB_3_1_Click(object sender, EventArgs e)
        {

        }
        //
        protected void D_TB_1_1_Click(object sender, EventArgs e)
        {

        }
        ///////
        protected void I_UB_1_1_Click(object sender, EventArgs e)
        {

        }
        protected void I_UB_3_1_Click(object sender, EventArgs e)
        {

        }
        protected void I_UB_5_1_Click(object sender, EventArgs e)
        {

        }
        protected void I_UB_7_1_Click(object sender, EventArgs e)
        {

        }
        //
        protected void I_DB_1_1_Click(object sender, EventArgs e)
        {

        }
        protected void I_DB_3_1_Click(object sender, EventArgs e)
        {

        }
        //
        protected void I_TB_1_1_Click(object sender, EventArgs e)
        {

        }
    }
}