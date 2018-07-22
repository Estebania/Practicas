using System;

namespace Practica1
{
	public class P1E10
	{
		public P1E10 ()
		{
		}

		public static void ejer10(){
			int con = 0;
			int sum = 0;
			int num;

			do {
				Console.Write ("Inserte un numero: ");
				num = int.Parse (Console.ReadLine ());

				sum += num;
				con++;
			} while (num != 0);
			Console.Write ("Has introducido " + con + " números y su suma es " + sum);
			Console.ReadKey ();
		}
	}
}

