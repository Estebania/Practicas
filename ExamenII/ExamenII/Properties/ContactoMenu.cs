using System;
using System.Collections.Generic;

namespace ExamenII
{
	public partial class Contacto
	{
	
		public void Menu(List<Contacto> contactos){
			Console.Clear ();
			Console.WriteLine ("**Welcome**");
			Console.WriteLine ("1-Agregar\n2-Buscar Por ID\n3-Buscar por Nombre\n4-Listar");
			Console.WriteLine ("-----------------");
			int opc = int.Parse (Console.ReadLine());

			switch (opc) {
			case 1:
				Nuevo (contactos);
				break;
			case 2:
				BuscarId (contactos);
				break;
			case 3:
				BuscarNombre (contactos);
				break;
			case 4:
				Mostrar (contactos);
				break;
			default:
				Preguntar (contactos);
				break;
			}


		}
	}
}

