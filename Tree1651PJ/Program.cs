using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Tree1651PJ;

namespace TreeManagerConsoleApp
{
	class Program
	{
        public static List<Tree>  Garden = new List<Tree>();
        public static List<IProduct> Products = new List<IProduct>();
		//check name
        private static bool IsValidName(string name)
        {
            return Regex.IsMatch(name, "^[a-zA-Z ]+$", RegexOptions.IgnoreCase);
        }
		//input name
		public static string InputName()
		{
			string name;
            do
            {
                name = Console.ReadLine();
                if (!IsValidName(name))
                {
                    Console.WriteLine("Invalid name! Please enter a name with letters only (a-z).");
                }
            } while (!IsValidName(name));

            return name;
		}

		public static int InputInterger()
		{
            bool isValidInput = false;
            int option=0;
			do
			{
				try
				{
					option = int.Parse(Console.ReadLine());
					if (option < 0)
					{
						Console.WriteLine("Please enter a non-negative number.");
					}
					else
					{
						isValidInput = true;
					}
				}
				catch (FormatException)
				{
					Console.WriteLine("Invalid input, please enter a valid number.");
				}
			} while (!isValidInput);

            return option;
        }

        //input tree
        public static Tree inputTree()
        {
            Console.WriteLine("Enter the name of the tree:");
            string name = InputName();

            Console.WriteLine("Enter the number of fruits:");
            int fruits = InputInterger();

            Console.WriteLine("Enter the number of leafs:");
            int leafs = InputInterger();

            Console.WriteLine("Enter the height of the tree:");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the health status of the tree (1 for Good, 2 for Fair, 3 for Poor):");
			var healthStatus = (HealthStatus) InputInterger(); // Input tree health status
            var tree = new Tree(fruits, leafs, name, height, healthStatus);
            return tree;
        }

        //plant tree
        public static void plantTree()
		{
			Garden.Add(inputTree());
        }
        static void Main(string[] args)
		{
			// Display the number of command line arguments.
			int option = -1;
			Farmer farmer = new Farmer();
            Console.WriteLine("Farmer Name: ");
			farmer.Name = InputName();

			farmer.Gender = InputGender();
			do
			{
				PrintMainMenu(farmer);
				Console.WriteLine("Select your option here:");
				//validate option
                try
                {
                    option = int.Parse(Console.ReadLine());
                    MainMenuSelect(option);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input, please enter a valid number.");
                    continue;
                }
			} while (option != 0);
		}

		public static void MainMenuSelect(int option)
		{
			switch (option)
			{
				case 0:
					Console.WriteLine("Exit the program");
					return;
				case 1:
					PlantTreeOption();
					break;
				case 2:
					GrowthTreeOption();
					break;
				case 3:
					HarvestMenu.Menu();
					break;
				case 4:
					TreeStatusOption();
					break;
				case 5:
					ClearConSoleOption();
					break;
				default:
					Console.WriteLine("Other!");
					break;
			}
		}

		public static void PrintMainMenu(Farmer farmer)
		{
            Console.WriteLine("|-----------------------------------------------------------------------------------------------|");
            Console.WriteLine("|				*______* Tree Management Menu *______*				|");
            Console.WriteLine("|-----------------------------------------------------------------------------------------------|");
			Console.WriteLine($"\nWelcome {farmer.Name} - {farmer.Gender}!\n");
			Console.WriteLine("|-----------------------------------------------------------------------------------------------|\n");
			Console.WriteLine("1. Plant Tree");
			Console.WriteLine("2. Growth Tree");
			Console.WriteLine("3. Harvest Tree");
			Console.WriteLine("4. Tree Status");
			Console.WriteLine("5. Clear Console");
			Console.WriteLine("0. Exit");
		}

		public static bool InputGender()
		{
			string gender = "";
			bool result;
			do
			{
				Console.WriteLine("Input farmer gender (M/F): ");
				gender = Console.ReadLine();
				if (gender.ToLower() == "m" || gender.ToLower() == "male")
					result = true;
				else
					result = false;
			}while(gender.ToLower() !="m" && gender.ToLower() != "f" && gender.ToLower() != "male" && gender.ToLower() != "female");
			return result;
		}

		public static void PlantTreeOption()
		{
			int option;
			do
			{
				PrintPlantTreeMenu();
				Console.WriteLine("Select plant tree option:");
				option = int.Parse(Console.ReadLine());
				PlantTreeSelect(option);
				/*Console.Clear();*/
			} while (option != 0);
		}

		public static void PlantTreeSelect(int option)
		{
			switch (option)
			{
				case 0:
					Console.WriteLine("Exit the plan tree menu");
					return;
				case 1:
					plantTree();
					Console.WriteLine("New Tree added");
					return;
				case 2:
					Tree tree = new Tree();
					Garden.Add(tree);
					Console.WriteLine("New Tree added at land index..");
					break;
			}
		}

		public static void PrintPlantTreeMenu()
		{
			Console.WriteLine("|-----------------------------------------------------------------------------------------------|");
			Console.WriteLine("|				*______* Plant Tree Option Menu *______*				|");
			Console.WriteLine("|-----------------------------------------------------------------------------------------------|");
			Console.WriteLine("1. Plant New Tree");
			Console.WriteLine("2. Plant New Tree at land index");
			Console.WriteLine("0. Return to main menu");
		}

		public static void GrowthTreeOption()
		{
			int option;
			do
			{
				PrintGrowthTreeMenu();
				Console.WriteLine("Select growth tree option:");
				option = int.Parse(Console.ReadLine());
				GrowthTreeSelect(option);
			} while (option != 0);
		}

		public static void GrowthTreeSelect(int option)
		{
			switch (option)
			{
				case 0:
					return;
				case 1:
                    Console.WriteLine("Watering"); // Watering Function
                    break;
				case 2:
					Console.WriteLine("Fertilizing"); // Fertilizing Function
					break;
				case 3:
                    Console.WriteLine("Providing CO2"); // Provide CO2 Function
                    break;
			}
		}

		public static void PrintGrowthTreeMenu()
		{
			Console.WriteLine("|-----------------------------------------------------------------------------------------------|");
			Console.WriteLine("|				*______* Growth Tree Option Menu *______*				|");
			Console.WriteLine("|-----------------------------------------------------------------------------------------------|");
			Console.WriteLine("1. Water the plant");
			Console.WriteLine("2. Fertilize the plant");
			Console.WriteLine("3. Provide CO2");
			Console.WriteLine("0. Return to main menu");
		}

		public static void TreeStatusOption()
		{
			int option;
			
			//Console.WriteLine("Tree status option!");
			foreach(Tree tree in Garden)
			{
				Console.WriteLine(tree.GetTreeStatus());
			}
		}

		public static void ClearConSoleOption()
		{
			Console.Clear();
			Console.SetCursorPosition(0, 0); /*FIXME: Con trỏ chuột chưa về trên cùng*/
		}
	}
}
