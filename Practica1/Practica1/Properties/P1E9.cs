using System;

namespace Practica1
{
	public class P1E9
	{
		public P1E9 ()
		{
		}

		public static void ejer9(){
			int num;

			do {
				Console.Write ("Inserte un numero: ");
				num = int.Parse (Console.ReadLine ());

				if ((num % 2) == 0) {
					Console.WriteLine ("El numero " + num + " es par ");
				} else {
					Console.WriteLine ("El numrero " + num + " es impar");
				}

			} while(num != 0);
			Console.ReadKey ();
		}
	}
}

