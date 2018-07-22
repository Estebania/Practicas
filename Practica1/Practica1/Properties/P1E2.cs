using System;

namespace Practica1
{
	public class P1E2
	{
		public P1E2 ()
		{
		}
		public static void ejer2(){

			Console.Write ("Inserte un numero: ");
			int num = int.Parse (Console.ReadLine());

			if ((num % 2) == 0) {
				Console.WriteLine ("El numero " + num + " es par ");
			}
			else{
				Console.WriteLine ("El numrero " + num + " es impar");
			}

		}
	}
}

