using System;

namespace Practica1
{
	public class P1E6
	{
		public P1E6 ()
		{
		}

		public static void ejer6(){
			Console.Write ("Inserte el primer  numero : ");
			int n1 = int.Parse (Console.ReadLine());
			Console.Write ("Inserte el segundo  numero : ");
			int n2 = int.Parse (Console.ReadLine());
			int resultado = n1 * n2;

			Console.WriteLine ("Resultado: " + resultado);
			Console.ReadKey ();


		}
	}
}

