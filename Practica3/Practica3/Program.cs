using System;

namespace Practica3
{
	class MainClass


	{

		public static void calcular(){
			int anio = 0;
			int mesesTrabajo = 0;
			try {
				Console.Write ("La fecha de su entrada: ");
				DateTime fechaEntrada = DateTime.Parse (Console.ReadLine());
				Console.Write ("La fecha de su salida: ");
				DateTime fechaSalida = DateTime.Parse (Console.ReadLine());
				//Console.Write ("La clase de trabajo ejecutado: ");
				//String trabajo = Console.ReadLine ();
				Console.Write ("El salario que devengaba: ");
				double sueldo = double.Parse (Console.ReadLine ());
				int diasEntada = fechaEntrada.Day;
				int diasSalida = fechaSalida.Day;

				int mesesSalida = fechaSalida.Month;
				int mesesEntrada = fechaEntrada.Month;



				double salarioDiario= sueldo /23.83;




				if(mesesSalida >=mesesEntrada){//calculo del anio
					if(diasSalida>=diasEntada){

						anio = fechaSalida.Year  - fechaEntrada.Year;
						mesesTrabajo = mesesSalida - mesesEntrada;

					}else { 

						anio = (fechaSalida.Year  - fechaEntrada.Year)-1;
						mesesTrabajo = mesesSalida - mesesEntrada;
					}
				}else if(mesesSalida< mesesEntrada){ 

					anio = (fechaSalida.Year  - fechaEntrada.Year)-1;

				}
				if(anio<=0){//calculo de meses

					mesesTrabajo = mesesSalida - mesesEntrada;
				}

				Console.WriteLine (anio);
				Console.WriteLine (mesesTrabajo);
				int diasSalario = 0;
				if (mesesTrabajo >= 3 && mesesTrabajo <= 6) {

					diasSalario = 6;

				} else if (mesesTrabajo >= 6 && anio <= 1) {
					diasSalario = 13;
				}
				else if(anio > 1 && anio<=5){

					diasSalario = 21;
				}else if(anio>5 ){
					diasSalario = 23 * anio;

				}

				//calculo de pagos

				double cesantias = salarioDiario * diasSalario;
				Console.Write("El sueldo que les coresponde es de: " + cesantias);

			}
			catch {

				Console.Clear ();
				Console.WriteLine("Error!\n Revise los datos");
				MainClass.calcular ();

			}
			//Calculo de dias correspondientes segun el art 80

			/*
             

Si el trabajador es pagado por mes, dividirá su salario ordinario entre 23.83 y 
el resultado de esa división será su salario diario;
			*/


		}
		public static void Main (string[] args)

		{
			
			//art.70
			// art. 74
			 //art.76
			// art. 80
			MainClass.calcular ();

			

	}
	}}
