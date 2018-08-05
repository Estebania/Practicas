using System;
using System.Collections.Generic;

namespace ExamenII
{
	public partial class Contacto
	{
		public void PreCargar(){
			List<Contacto> _contactos = new List<Contacto>(){
				new Contacto(){
					ID=1,
					Nombre = "Juan Duarte",
					Telefono = "12345678",
					Email = "Juan@hotmail.com"

				},
				new Contacto(){
					ID=2,
					Nombre = "Marco Polo",
					Telefono = "1234543234",
					Email = "Marco@hotmail.com"

				},
				new Contacto(){
					ID=3,
					Nombre = "Maria de la Fuente",
					Telefono = "456654286764",
					Email = "MDLF@hotmail.com"

				},
				new Contacto(){
					ID=4,
					Nombre = "Lura Lopez",
					Telefono = "456654286764",
					Email = "Laura@hotmail.com"

				},
				new Contacto(){
					ID=5,
					Nombre = "Frank Jackson",
					Telefono = "4567898655",
					Email = "Frank@hotmail.com"

				},

			};
			Menu (_contactos);

		}
	}
}

