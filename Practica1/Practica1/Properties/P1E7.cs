using System;

namespace Practica1
{
	public class P1E7
	{
		public P1E7 ()
		{
		}

		public static void ejer7(){
			Console.Write ("Inserte el primer  numero : ");
			double dato1 = double.Parse (Console.ReadLine());
			Console.Write ("Inserte el segundo  numero : ");
			double dato2 = double.Parse (Console.ReadLine());
			if (dato2 == 0) {
				Console.WriteLine ("Erro!!");

			} else {

				double resultado = dato1 / dato2;

				Console.WriteLine ("Resultado: " + resultado);

			}
			Console.ReadKey ();
		}
	}
}

