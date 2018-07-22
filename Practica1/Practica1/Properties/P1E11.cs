using System;

namespace Practica1
{
	public class P1E11
	{
		public P1E11 ()
		{
		}

		public static void ejer11(){
			Console.Write ("Inserte un numero: ");
			int num = int.Parse (Console.ReadLine ());

			for(int i = 1;i<=12;i++){
				int res = num * i;

				Console.WriteLine (num + "x" + i + " = " + res );

			}
			Console.ReadKey ();
		}

	}
}

