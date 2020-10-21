/**
 * jeu du nombre caché
 * Léa Serrié
 * 20/10/2020
 */
using System;

namespace testConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			int valeur, essai, nombre = 1;
			bool correct = false;

			while (!correct)
			{
				try
				{
					Console.Write("Entrez le nombre à chercher =");
					valeur = int.Parse(Console.ReadLine());
					correct = true;
				}
				catch
				{
					Console.WriteLine("Erreur. Saisissez un nombre entier.");
				}
			}
			Console.Clear();

			Console.Write("Entrez le nombre à chercher =");
			valeur = int.Parse(Console.ReadLine());

			Console.Write("Entrez un essai =");
			essai = int.Parse(Console.ReadLine());

				Console.Clear();

			while (essai != valeur)
			{
				if (essai < valeur)
				{
					Console.WriteLine("Trop petit !");
				}
				else
				{
					Console.WriteLine("Trop grand !");
				}

				Console.Write("Entrez un essai =");
				essai = int.Parse(Console.ReadLine());
				nombre++;
			}

			Console.WriteLine("Trouvé !");
			Console.WriteLine("Vous avez trouvé en " + nombre + " fois");

		

				{
					Console.ReadLine();
				}


			}
		}
	}		
