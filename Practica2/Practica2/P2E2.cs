using System;

namespace Practica2
{
	public class P2E2
	{
		public P2E2 ()
		{
		}

		public static  void ejer2(){
			Console.WriteLine("Numero : ");
			int n1 = int.Parse (Console.ReadLine());
			Console.WriteLine("Numero : ");
			int n2 = int.Parse (Console.ReadLine());
			Console.WriteLine("Numero : ");
			int n3 = int.Parse (Console.ReadLine());

			int[] datos = new int[3];

			datos [0] = n1;
			datos [1] = n2;
			datos [2] = n3;

			for (int i = 0; i < 3; i++) {
				for (int j = 0;j<3;j++){
					if ((j + 1) < 3) {
					if(datos[j]> datos[j + 1]){
					int aux;
					
					aux = datos[j];

						datos [j] = datos [j + 1];
						datos [j + 1] = aux;
					}

					}}
				
			}
			for (int f=0;f<3;f++){

				Console.Write (datos[f]);


			}
			Console.ReadKey ();
		}

	}
}

