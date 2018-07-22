using System;

namespace Practica2
{
	public class P2E7
	{
		public P2E7 ()
		{
		}
		public static void ejer7(){
			Console.WriteLine ("Inserte el monto a retirar: ");
			double monto = double.Parse (Console.ReadLine());
			int contBM = 0;//contador de billetes de mil
			int contBQ = 0;//contador de billetes de quinentos
			int contBC = 0;//contador de billetes de cien
			double montoCajero = 200000.00;
			if (monto <= montoCajero) {
				while (monto >= 1000) {
					monto = monto - 1000;
					contBM++;

				} 

				while (monto >= 500) {
					monto = monto - 500;
						
					contBQ++;

				}

				while (monto >= 100) {
					monto = monto - 100;
					Console.Write (monto + "\n");
					contBC++;
						
				}


				Console.WriteLine (contBM + " billetes de 1000");
				Console.WriteLine (contBQ + " billetes de 500");
				Console.WriteLine (contBC + " billetes de 100");
			} else {
				Console.WriteLine ("Por Dios! No tenemos ese dinero!");
			}
			Console.ReadKey ();
						







			
		
			}

		}
	}

	
