using System;

namespace Practica4
{
	public class Cliente
	{
		public Cliente ()
		{
		}

		private string Nombre, Apellido;
		private double valorCuenta;
		private int numCuenta, numCliente;



		Cliente(string Nombre,string Apell, double valCue, int numCuen, int numCliente){
			this.Nombre = Nombre;
			this.Apellido = Apell;
			this.valorCuenta = valCue;
			this.numCuenta = numCuen;
			this.numCliente = numCliente;


		}





		public  void LlenarRegistro(){//Metodo para guardar los datos de los clientes
			Cliente[] Clientes = new Cliente[3];

			Cliente c1 = new Cliente("Juan","Duarte",200000.00,1,1); 
			Cliente c2 = new Cliente("Pablo","Sánchez",175896.45,2,2);
			Cliente c3 = new Cliente("Francisco","Mella",999999.99,3,3);

			Clientes [0] = c1;
			Clientes [1] = c2;
			Clientes [2] = c3;


			menu (Clientes);//llamada al metodo menu

		}


		public void menu(Cliente[] cli){

			int opc = 0;

			Console.Write ("Introduzca su numero de cuenta: ");
			int numCuenta = int.Parse (Console.ReadLine());

			Console.WriteLine ("Que decea realizar: \n1-Retiro\n2-Transferncia\n3-Deposito");//opciones del menu
			opc = int.Parse (Console.ReadLine());

			switch(opc){
			case 1://si es un retiro
				for(int i=0;i<cli.Length;i++){

					if (cli[i].numCuenta==numCuenta) {

						Console.WriteLine ("Valor a retirar: ");
						double monto = double.Parse (Console.ReadLine ());

						if (monto < cli [i].valorCuenta) {
							cli [i].valorCuenta = cli [i].valorCuenta - monto;
							Console.Clear ();
							Console.WriteLine ("**Informe de Movimiento**");
							Console.WriteLine ("Numero de cuenta: " + cli [i].numCuenta);
							Console.WriteLine ("Propietario(s): " + cli [i].Nombre + " " + cli [i].Apellido);
							Console.WriteLine ("Cliente: #" + cli [i].numCliente);
							Console.WriteLine ("Monto retirado: " + monto);
							Console.WriteLine ("Monto disponible en la cuenta: " + cli [i].valorCuenta);
						} else {

							Console.WriteLine ("No dispone de esa cantidad");
						}


					}


				}
				break;
				//fin
			case 2://si es una transferencia
				Console.WriteLine ("Cuenta a la que descea transferir: ");
				int numCuenta2 = int.Parse (Console.ReadLine());

				for (int i = 0; i < cli.Length; i++) {
					if (cli[i].numCuenta==numCuenta) {
						for (int j = 0; j < cli.Length; j++) {
							if (cli [j].numCuenta == numCuenta2 && numCuenta != numCuenta2) {
								Console.WriteLine ("Monto a transferir: ");
								double monto = double.Parse (Console.ReadLine ());
								if (monto < cli [i].valorCuenta) {
									cli [i].valorCuenta = cli [i].valorCuenta - monto;
									cli [j].valorCuenta = cli [j].valorCuenta + monto;
									Console.Clear ();
									Console.WriteLine ("**Informe de Movimiento**");
									Console.WriteLine ("Numero de cuenta: " + cli [i].numCuenta);
									Console.WriteLine ("Propietario(s): " + cli [i].Nombre + " " + cli [i].Apellido);
									Console.WriteLine ("Cliente: #" + cli [i].numCliente);
									Console.WriteLine ("Monto retirado: " + monto);
									Console.WriteLine ("Monto disponible en la cuenta: " + cli [i].valorCuenta);


								} else {
									Console.WriteLine ("No dispone de esa cantidad");	
								}
							} else {
								Console.WriteLine ("Numero de cuenta no valido");

							}

						}


					}
				}
				break;//fin
			case 3://si es un deposito

				for(int i=0;i<cli.Length;i++){

					if (cli[i].numCuenta==numCuenta) {

						Console.WriteLine ("Valor a depositar: ");
						double monto = double.Parse (Console.ReadLine ());

						cli [i].valorCuenta += monto;
						Console.Clear ();
						Console.WriteLine ("**Informe de Movimiento**");
						Console.WriteLine ("Numero de cuenta: "+ cli[i].numCuenta);
						Console.WriteLine ("Propietario(s): " + cli[i].Nombre +" "+cli[i].Apellido);
						Console.WriteLine ("Cliente: #"+cli[i].numCliente);
						Console.WriteLine ("Monto retirado: "+ monto);
						Console.WriteLine ("Monto disponible en la cuenta: "+ cli[i].valorCuenta);



					}


				}

				break;//fin
			default:
				break;

			}
			Console.WriteLine ("Desea realizar otra operacion\n1-Si\n2-No");//confirmar salida
			int respuesta = int.Parse (Console.ReadLine());
			if (respuesta == 1) {
				Console.Clear ();

				menu (cli);
			} else {
				Environment.Exit(0);
			}
		}

	}
}

