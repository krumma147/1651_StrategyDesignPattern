using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeManagerConsoleApp
{
	public class HarvestMenu
	{
		public static void Menu()
		{
			int option;
			do
			{
				PrintMenu();
				Console.WriteLine("Select harvest tree option:");
				option = int.Parse(Console.ReadLine());
				Select(option);
			} while (option != 0);
		}

		public static void Select(int option)
		{
			switch (option)
			{
				case 0:
					break;
				case 1:
					Console.WriteLine("Watering");
					break;
				case 2:
					Console.WriteLine("Fertilizing");
					break;
				case 3:
					Console.WriteLine("Providing CO2");
					break;
			}
		}

		public static void PrintMenu()
		{
			Console.WriteLine("|-----------------------------------------------------------------------------------------------|");
			Console.WriteLine("|				*______* Harvest Tree Option Menu *______*				|");
			Console.WriteLine("|-----------------------------------------------------------------------------------------------|");
			Console.WriteLine("1. Harvest Fruit");
			Console.WriteLine("2. Harvest Wood");
			Console.WriteLine("3. Harvest Medicine Leaf");
			Console.WriteLine("0. Return to main menu");
		}
	}
}
