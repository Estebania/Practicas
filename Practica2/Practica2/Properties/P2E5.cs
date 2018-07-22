using System;

namespace Practica2
{
	public class P2E5
	{
		public P2E5 ()
		{
		}

		public static void ejer5(){
			int cont = 0;
			do {
				Console.Write ("Usuario: ");
				string usuario = Console.ReadLine ();
				Console.Write ("Contraseña: ");
				string contra = Console.ReadLine ();
				if (usuario == "Admin") {

					if (contra == "123") {
						cont = 4;
						Console.WriteLine ("Bienvenido!");
					}

				} else {

					cont++;
				}
				if (cont == 3) {

					Console.WriteLine ("ha intentado iniciar sesión 3 veces.\ncontacte al administrador.");
				}
			} while(cont < 3);
				Console.ReadKey();
		}
	}
}

