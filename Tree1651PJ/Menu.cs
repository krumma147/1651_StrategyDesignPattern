using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Tree1651PJ
{
	
	internal class Menu
	{
		public static void Main(string[] args)
		{
			// Display the number of command line arguments.

			int option;
			do
			{
				PrintMenuLevel1();
                Console.WriteLine("Select your option here:");
                option = Convert.ToInt32(Console.ReadLine());
				MenuSelect(option);
			} while (option != 0);
		}

		public static void MenuSelect(int option)
		{
			switch (option)
			{
				case 0:
					Console.WriteLine("Exit the program");
					return;
				case 1:
					Console.WriteLine("Select Option 1");
					break;
				case 2:
					Console.WriteLine("Select Option 2");
					break;
				case 3:
					Console.WriteLine("Select Option 3");
					break;
				case 4:
					Console.WriteLine("Select Option 4");
					break;
				default:
					Console.WriteLine("Other!");
					break;
			}
		}

		public static void PrintMenuLevel1()
		{
			Console.WriteLine("*______* Tree Management Menu *______*");
			Console.WriteLine("Option 1");
			Console.WriteLine("Option 2");
			Console.WriteLine("Option 3");
			Console.WriteLine("Option 4");
			Console.WriteLine("Option 0 : Exit.");
		}

	}
}
