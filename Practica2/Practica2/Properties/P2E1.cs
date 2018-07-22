using System;

namespace Practica2
{
	public class P2E1
	{
		public P2E1 ()
		{
		}

		public static void ejer1(){
			Console.WriteLine("Numero: ");
			int n = int.Parse (Console.ReadLine());

			switch (n) {
			case 1:
				Console.WriteLine ("Enero");
				break;
			case 2:
				Console.WriteLine ("Febrero");
				break;
			case 3:
				Console.WriteLine ("Marzo");
				break;
			case 4:
				Console.WriteLine ("Abril");
				break;
			case 5:
				Console.WriteLine ("Mayo");
				break;
			case 6:
				Console.WriteLine ("Junio");
				break;
			case 7:
				Console.WriteLine ("Julio");
				break;
			case 8:
				Console.WriteLine ("Agosto");
				break;
			case 9: 
				Console.WriteLine ("Septiembre");
				break;
			case 10:
				Console.WriteLine ("Octubre");
				break;
			case 11:
				Console.WriteLine ("Noviembre");
				break;
			case 12:
				Console.WriteLine ("Diciembre");
				break;
			default:
				Console.WriteLine ("Fuera de rango");
				break;
			}

			Console.ReadKey ();
		}
	}
}

