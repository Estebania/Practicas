using System;

namespace Practica2
{
	public class P2E3
	{
		public P2E3 ()
		{
		}

		public static void ejer3(){

			Console.WriteLine("Numero N1: ");
			int n1 = int.Parse (Console.ReadLine());
			Console.WriteLine("Numero N2: ");
			int n2 = int.Parse (Console.ReadLine());
			Console.WriteLine("Numero N3: ");
			int n3 = int.Parse (Console.ReadLine());

			int mul = n1 * n2;

			if (mul == n3) {
				Console.WriteLine (n1 + "x" + n2 + " es igual a N3: " + n3);
			} else {
				Console.WriteLine (n1 + "x" + n2 + " no es igual a N3: " + n3);
			}
			Console.ReadKey ();
	}
}
}
