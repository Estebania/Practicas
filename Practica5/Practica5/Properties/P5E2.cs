using System;

namespace Practica5
{
	public class Cliente
	{
		

		public string Nombre {
			get;
			set;
		}
		public int edad {
			get;
			set;
		}
		public Cliente()
		{
		}

		public static void CumplirAnyos(Cliente edad){

			edad.edad += 1;
			Console.WriteLine ("En el metodo: "+edad.edad);
		}
		public static void Clase(){

			Cliente cl = new Cliente ();

			cl.edad = 12;
			Console.WriteLine ("En la clase");
			Console.WriteLine ("Antes: " +cl.edad);

			Cliente.CumplirAnyos (cl);

			Console.WriteLine ("Despues: " +cl.edad);
			Console.WriteLine ("Paso por referencia");
		}

	}
	public struct ClienteEstructura
	{
		public string Nombre {
			get;
			set;
		}
		public int edad {
			get;
			set;
		}

		public static void CumplirAnyos(ClienteEstructura edad){

			edad.edad += 1;
			Console.WriteLine ("En el metodo: "+edad.edad);
		}
		public static void Estructura(){
			ClienteEstructura ce = new ClienteEstructura();

			ce.edad = 12;
			Console.WriteLine ("---------------");
			Console.WriteLine ("En la Estructura");
			Console.WriteLine ("Antes: " +ce.edad);

			ClienteEstructura.CumplirAnyos (ce);

			Console.WriteLine ("Despues: " +ce.edad);
			Console.WriteLine ("Paso por valor");

		}
		
	}
}

