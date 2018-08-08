using System;

namespace Practica5
{
	public delegate void Operar(int opc,int x, int y);
	public class P5E3
	{
		public P5E3 ()
		{
		}
		public static void Menu(){
			Console.WriteLine ("1-Suma\n2-Resta\n3-Multiplicacion\n4-Divicion");
			int opc = int.Parse (Console.ReadLine());
			Console.WriteLine ("Primer Numero: ");
			int x = int.Parse (Console.ReadLine());
			Console.WriteLine ("Segundo Numero");
			int y = int.Parse (Console.ReadLine());

			Operar op = new Operar (Calcular);

			op(opc,x,y);
			
		}

		public static void Calcular(int opc,int x, int y){

			try {
				switch (opc) {
				case 1:
					Console.WriteLine ("Resultado: " + (x+y));
					break;
				case 2:
					Console.WriteLine ("Resultado: " + (x-y));
					break;
				case 3:
					Console.WriteLine ("Resultado: " + (x*y));
					break;
				case 4:
					Console.WriteLine ("Resultado: " + (x/y));
					break;


				default:
					break;
				}
				
			} catch (Exception ex) {
				Console.WriteLine (ex.Message);
			}

		}

	}
}

