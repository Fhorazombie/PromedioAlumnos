using System;

public class calificaciones
{
	public struct alumno
	{
		public string id;
		public string nombre;
		public int edad;
		public float caliMate;
		public float caliEspa;
		public float caliQuim;
		public float caliFisi;
		public float promedio;
	}

	public static void Main()
	{

		/* https://stackoverflow.com/questions/1064901/random-number-between-2-double-numbers */
		double GetRandomNumber(float minimum, float maximum)
		{
			Random random = new Random();
			return random.NextDouble() * (maximum - minimum) + minimum;
		}

		string formatText(string str, int spaces)
        {
			string nombreformato = str;
			while (nombreformato.Length < spaces)
			{
				nombreformato = nombreformato + " ";
			}
			return nombreformato;
		}

		alumno[] alumnos = new alumno[10];

		alumnos[0].id = "alumno1";
		alumnos[0].nombre = "Pedro Mendez";

		alumnos[1].id = "alumno2";
		alumnos[1].nombre = "Rodolfo Holgado";

		alumnos[2].id = "alumno3";
		alumnos[2].nombre = "Alejandra Mestre";

		alumnos[3].id = "alumno4";
		alumnos[3].nombre = "Casimiro Betancor";

		alumnos[4].id = "alumno5";
		alumnos[4].nombre = "Jacobo Morilla";

		alumnos[5].id = "alumno6";
		alumnos[5].nombre = "Pedro Mendez";

		alumnos[6].id = "alumno7";
		alumnos[6].nombre = "Elisabeth Maya";

		alumnos[7].id = "alumno8";
		alumnos[7].nombre = "Melchor Amoros";

		alumnos[8].id = "alumno9";
		alumnos[8].nombre = "Uxia Morales";

		alumnos[9].id = "alumno10";
		alumnos[9].nombre = "Álvaro Tome";


		for (int i = 0; i < alumnos.Length; i++)
		{
			alumnos[i].edad = (int)(GetRandomNumber(18, 25));
			alumnos[i].caliMate = (float)(Math.Round(GetRandomNumber(6, 10), 1));
			alumnos[i].caliEspa = (float)(Math.Round(GetRandomNumber(6, 10), 1));
			alumnos[i].caliQuim = (float)(Math.Round(GetRandomNumber(6, 10), 1));
			alumnos[i].caliFisi = (float)(Math.Round(GetRandomNumber(6, 10), 1));
		}

		/* https://www.ascii-art-generator.org  https://social.msdn.microsoft.com/Forums/es-ES/649fd923-5153-47dd-9597-7d0485882089/tengo-un-problema-con-secuencia-de-escape-no-reconocida?forum=vcses*/
		Console.WriteLine("   ______      ___ _____                 _                      ");
		Console.WriteLine("  / ____/___ _/ (_) __(_)________ ______(_)___  ____  ___  _____");
		Console.WriteLine(@" / /   / __ `/ / / /_/ / ___/ __ `/ ___/ / __ \/ __ \/ _ \/ ___/");
		Console.WriteLine("/ /___/ /_/ / / / __/ / /__/ /_/ / /__/ / /_/ / / / /  __(__  ) ");
		Console.WriteLine(@"\____/\__,_/_/_/_/ /_/\___/\__,_/\___/_/\____/_/ /_/\___/____/  ");
		Console.WriteLine("															       ");
		Console.WriteLine("    ___    __                                ");
		Console.WriteLine("   /   |  / /_  ______ ___  ____  ____  _____");
		Console.WriteLine(@"  / /| | / / / / / __ `__ \/ __ \/ __ \/ ___/");
		Console.WriteLine(" / ___ |/ / /_/ / / / / / / / / / /_/ (__  ) ");
		Console.WriteLine(@"/_/  |_/_/\__,_/_/ /_/ /_/_/ /_/\____/____/  ");
		Console.WriteLine("										        ");


		Console.WriteLine("----------------------------------------------------------------------------------");
		Console.WriteLine("| Id       | Nombre              | Edad | Mat. | Esp. | Quím. | Físi. | Promedio |");
		Console.WriteLine("----------------------------------------------------------------------------------");
		for (int i = 0; i < alumnos.Length; i++)
		{
			float promedio = (alumnos[i].caliMate + alumnos[i].caliEspa + alumnos[i].caliQuim + alumnos[i].caliFisi)/4;
			alumnos[i].promedio = (float)(Math.Round(promedio, 1));

				Console.WriteLine("----------------------------------------------------------------------------------");
			Console.WriteLine("| {0} | {1} | {2} | {3} | {4} | {5} | {6} | {7} |",
			formatText(alumnos[i].id, 8), 
			formatText(alumnos[i].nombre,19),
			formatText(alumnos[i].edad.ToString("00"), 4),
			formatText(alumnos[i].caliMate.ToString("0.0"), 4),
			formatText(alumnos[i].caliEspa.ToString("0.0"), 4),
			formatText(alumnos[i].caliQuim.ToString("0.0"), 5),
			formatText(alumnos[i].caliFisi.ToString("0.0"), 5),
			formatText(alumnos[i].promedio.ToString("0.0"), 8)
			);
			Console.WriteLine("----------------------------------------------------------------------------------");

		}
        unsafe
		{
			float*[] punterocalificaciones = new float*[10];
			for (int i = 0; i < alumnos.Length; i++)
			{
				fixed( float* puntero = &alumnos[i].promedio)
                {
					punterocalificaciones[i] = puntero;

					Console.WriteLine("----------------------------------------------------------------------------------");
					Console.WriteLine("----------------------------------------------------------------------------------");
					Console.WriteLine("Puntero de calificacion estudiante");
					Console.WriteLine("Estudiante: {0}", alumnos[i].nombre);
					Console.WriteLine("Puntero: {0}", *punterocalificaciones[i]);
				}
			}
		}

		/*https://generadordenombres.online*/
	}
}