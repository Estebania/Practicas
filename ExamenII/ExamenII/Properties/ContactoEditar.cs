using System;
using System.Collections.Generic;

namespace ExamenII
{
	public partial class Contacto
	{
		public void Editar(List<Contacto> contactos, List<Contacto> res){
			int opc;
			Console.WriteLine ("Modificar: \n1-Nombre\n2-Telefono\n3-Email");
			opc = int.Parse (Console.ReadLine ());
			switch (opc) {
			case 1:
				string nom;
				do {
					Console.WriteLine ("Email: ");
					nom = Console.ReadLine ();
					if (nom == "") {

						Console.WriteLine ("Campo obligatorio");
					} 
				} while (nom == "");
				res [0].Nombre = nom;

				break;
			case 2:
				Console.WriteLine ("Telefono: ");
				res [0].Telefono = Console.ReadLine ();

				break;
			case 3:
				string ema;
				do {
					Console.WriteLine ("Email: ");
					ema = Console.ReadLine ();
					if (ema == "") {

						Console.WriteLine ("Campo obligatorio");
					} 
				} while (ema == "");
				res [0].Email = ema;

				break;
			default:
				break;
			}
			foreach (var i in contactos) {
				foreach (var j in res) {
					if (i.ID==j.ID) {
						i.Nombre = j.Nombre;
						i.Telefono = j.Telefono;
						i.Email = j.Email;
					}
				}
			}
			Preguntar (contactos);
		}
	}
}

