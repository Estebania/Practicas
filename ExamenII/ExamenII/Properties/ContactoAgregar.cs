using System;
using System.Collections.Generic;

namespace ExamenII
{
	public partial class Contacto
	{
		public void Nuevo(List<Contacto> contactos){
			Console.Clear ();
			Console.WriteLine ("**Agregar Contacto**");
			int cont=0;
			string nombre;
			string email; 
			foreach (var item in contactos) {
				cont++;
			}
			do{
				Console.WriteLine ("Nombre: ");
				nombre= Console.ReadLine ();
			}while(nombre =="");

			do{
				Console.WriteLine ("Email: ");
				email= Console.ReadLine ();
			}while(email=="");

			Console.WriteLine ("Telefono: ");
			string telefono = Console.ReadLine ();


			Contacto nc = new Contacto () {
				ID = cont+1,
				Nombre = nombre,
				Email = email,
				Telefono = telefono
			};
			contactos.Add (nc);

			Preguntar (contactos);
		}
	}
}

