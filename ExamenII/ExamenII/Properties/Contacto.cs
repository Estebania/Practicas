using System;
using System.Collections.Generic;


namespace ExamenII
{
	public partial class Contacto
	{
		public int ID {
			get;
			set;
		}
		public string Nombre {
			get;
			set;
		}
		public string Telefono{
			get;
			set;
		}
		public string Email{
			get;
			set;
		}


		public void Mostrar(List<Contacto> contactos){
			
			Console.Clear ();
			foreach (var cont in contactos) {
				Console.WriteLine (cont.ID);
				Console.WriteLine (cont.Nombre);
				Console.WriteLine (cont.Telefono);
				Console.WriteLine (cont.Email);
			}
			Preguntar (contactos);
		}

		public void Preguntar(List<Contacto> contactos){
			
			Console.WriteLine ("\n\nRealizar otra operacion : (S)i o (N)o ");
			char res = char.Parse (Console.ReadLine());
			if (res=='S'|| res == 's') {
				Menu (contactos);
			}else {
				Environment.Exit(0);
			}
		}



		}
		}
	

