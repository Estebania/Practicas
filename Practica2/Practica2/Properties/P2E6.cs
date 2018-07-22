using System;

namespace Practica2
{
	public class P2E6
	{
		public P2E6 ()
		{
		}
		public static void ejer6(){
			Console.WriteLine ("Inserte el numero: ");
			int num = int.Parse (Console.ReadLine());

			for (int i = 1; i <= num; i++) {
				for (int j = 1; j <= 12; j++) {
					Console.WriteLine (i+"X"+j+"="+ i*j);
				}
				Console.WriteLine ();
			}
			Console.ReadKey ();
		}
	}
}

