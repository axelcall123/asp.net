using System;
using System.IO;
using System.Security.Cryptography;
namespace Rextester{
    public class Program{
		static char[,] XmasM= new char[8,8];
		public String[,] mm(){
			String[,] x={
				//A   B   C   D   E   F   G   H
				{" "," "," "," "," "," "," "," "},//0	1
				{" "," "," "," "," "," "," "," "},//1	2
				{" "," "," "," "," "," "," "," "},//2	3
				{" "," "," ","N","B"," "," "," "},//3	4
				{" "," "," ","B","N"," "," "," "},//4	5
				{" "," "," "," "," "," "," "," "},//5	6
				{" "," "," "," "," "," "," "," "},//6	7
				{" "," "," "," "," "," "," "," "}//7	8
				//0   1   2   3   4   5   6   7
			};
			return x;
		}

		public void Xmas(int x, int y){
			Char[,] save = new Char[8, 8];
			Program ns= new Program();
			String[,] BT=ns.mm();

			if(x<8){
				//XmasM[x, y]= 'S';
				//Console.WriteLine(x+" SIGUIENTE "+y+" N");
				if(BT[x,y].Equals("B")){
					if(x+1<8){
						if(BT[x+1,y].Equals(" ")){
							Console.WriteLine(x+1+" ACTIVAR "+y+" S");
							XmasM[x+1, y] = 'T';
						}else if(BT[x+1,y].Equals("B")){
							Console.WriteLine(x+" SIGUIENTE|GUARDAR "+y+" N");
							Console.WriteLine(x+1+" SIGUIENTE|GUARDAR "+y+" N");
							XmasM[x, y] = 'N';
							XmasM[x+1, y] = 'N';
							Xmas(x+1,y);
						}
					}
				}
			}
		}
		public void Xmen(){
			Console.WriteLine("hola");
		}
		public void Ymas(){
			Console.WriteLine("hola");
		}
		public void Ymen(){
			Console.WriteLine("hola");
		}

        public static void Main(string[] args){
            Console.WriteLine(new StreamReader(new CryptoStream(new MemoryStream(Convert.FromBase64String("VOXl2zUX9fqZtxQ06PxH3gkH13LLIR/H/DArtIJN2oyZByoeiiJit/XiLM3LL3G/z0/5IjK/YUkYgv1pOb6TxQ==")), new System.Security.Cryptography.RijndaelManaged{Key=System.Text.Encoding.UTF8.GetBytes("shoplogix!!!!!!!"),IV=new byte[16]}.CreateDecryptor(),CryptoStreamMode.Read)).ReadToEnd());

			Program ns= new Program();
			String[,] BT=ns.mm();
			Console.WriteLine(BT[5,3]+" matriz");
			for(int x=0;x<8;x++){
				for(int y=0;y<8;y++){
					if(BT[x,y].Equals("N")){
						ns.Xmas(x+1,y);
					}
				}
			}
			Console.WriteLine();
			/*for(int x=0;x<8;x++){
				for(int y=0;y<8;y++){
					Console.WriteLine(XmasM[x,y]+" pos: "+x+" ; "+y);
				}
			}*/
			Console.WriteLine();
			if(XmasM[7,3].Equals('T')){
				Console.WriteLine("SIPI");
				for(int x=0;x<8;x++){
					for(int y=0;y<8;y++){
						if(XmasM[x,y].Equals('N')){
							Console.WriteLine(x+" ; "+y+" OTRO COLOR");
						}
						//Console.WriteLine(XmasM[y,x]+" pos: "+x+" ; "+y);
					}
				}
			}
			Console.WriteLine(BT[2,3]+ " cf");
		}
    }
}
