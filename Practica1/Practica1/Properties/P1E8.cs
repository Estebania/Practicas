using System;

namespace Practica1
{
	public class P1E8
	{
		public P1E8 ()
		{
		}

		public static void ejer8(){
			Console.Write ("Inserte el primer  numero : ");
			int num1 = int.Parse (Console.ReadLine());
			Console.Write ("Inserte el segundo  numero : ");
			int num2 = int.Parse (Console.ReadLine());
			if (num2 == 0) {
				Console.WriteLine ("Erro!!");

			} else {

				int resultado = num1 / num2;

				Console.WriteLine ("Resultado: " + resultado);

			}
			Console.ReadKey ();

		}
	}
}

