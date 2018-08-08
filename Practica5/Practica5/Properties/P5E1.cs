using System;

namespace Practica5
{
	public class P5E1
	{
		public P5E1 ()
		{
		}

		public static void ValorInicial(){

			int numero = 12;


			Console.WriteLine ("Valor incial "+numero);

			PasandoPorReferencia(ref numero);

			Console.WriteLine ("Valor Despues"+numero);
			 

	}
		public static void PasandoPorReferencia(ref int num){

			num = num + 1;
			 
			Console.WriteLine ("Valor Actualizado "+num);
			 

		}
	}}

