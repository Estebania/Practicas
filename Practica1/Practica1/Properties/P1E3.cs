using System;

namespace Practica1
{
	public class P1E3
	{
		public P1E3 ()
		{
		}

		public static void ejer3(){

			Console.WriteLine ("Ingrese su edad");

			int edad = int.Parse (Console.ReadLine());

			if (edad >= 0 && edad <= 11) {
				Console.WriteLine("Es un niño");
			}
			else if (edad >=12 && edad <=17 ){

				Console.WriteLine("Es un adolecente");
			}
			else if (edad >=18){

				Console.WriteLine("Es un adulto");
			}
			Console.ReadKey ();
		}

	}
}

