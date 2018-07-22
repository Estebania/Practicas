using System;

namespace Practica2
{
	public class P2E4
	{
		public P2E4 ()
		{
		}

		public static void ejer4(){
			Console.WriteLine ("Inserte el sueldo bruto: ");
			double sueldoBruto = double.Parse(Console.ReadLine());
			double sueldoNeto = 0.0;
			String tasa = "";


			if (sueldoBruto <= 34999) {
				sueldoNeto = sueldoBruto;
				tasa = "Exento";
			}
			else if (sueldoBruto >= 35000 && sueldoBruto <= 59999){
				sueldoNeto = sueldoBruto*(15/100);
				tasa = "15.0%";

			}
			else if (sueldoBruto >= 60000 && sueldoBruto <= 79999){
				sueldoNeto = sueldoBruto*(20/100);
				tasa = "20.0%";

			}else if (sueldoBruto >= 80000 ){
				sueldoNeto = sueldoBruto*(25/100);
				tasa = "25.0%";


			}

			double afp = sueldoBruto * 0.0287;

			double sfs = sueldoBruto * 0.0304;

			sueldoNeto= sueldoNeto - afp - sfs;

			Console.WriteLine ("Sueldo Bruto: " + sueldoBruto);
			Console.WriteLine ("ISR: "+ tasa);
			Console.WriteLine ("SFS: "+ sfs);
			Console.WriteLine ("AFP: "+ afp);
			Console.WriteLine ("Sueldo Neto: "+ sueldoNeto);
			Console.ReadKey ();
		}
	}
}

