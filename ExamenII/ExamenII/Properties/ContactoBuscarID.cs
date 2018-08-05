using System;
using System.Collections.Generic;

namespace ExamenII
{
	public partial class Contacto
	{
		public void BuscarId(List<Contacto> contactos){
			Console.Clear();
			Console.WriteLine ("**Buscar Contacto**");

			Console.WriteLine ("ID contacto: ");
			int id = int.Parse (Console.ReadLine());
			var resultado = contactos.FindAll(c => c.ID == id);
			var res = resultado;
			foreach (var i in res) {
				Console.WriteLine(i.ID);
				Console.WriteLine (i.Nombre);
				Console.WriteLine (i.Email);
				Console.WriteLine (i.Telefono);
			}
			Console.WriteLine ("Editar(F2)\t\tBorrar(F3)dos veces");
			var tecla = Console.ReadKey ().Key;
			if (tecla==ConsoleKey.F2) {
				Editar (contactos, res);
			}
			else if (tecla==ConsoleKey.F3) {

				contactos.RemoveAt (id-1);
				Console.WriteLine ("Contacto Eliminado");

				for (int i = 0; i < contactos.Count; i++) {
					contactos [i].ID =  i + 1;
				}
			}
			Preguntar (contactos);

		}
	}
}

