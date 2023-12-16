using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tree1651PJ;

namespace TreeManagerConsoleApp.Menu
{
    public class PlantMenu
    {

        //input tree
        public static Tree inputTree()
        {
            Console.WriteLine("Enter the name of the tree:");
            string name = Validate.InputName();

            Console.WriteLine("Enter the number of fruits:");
            int fruits = Validate.InputInterger();

            Console.WriteLine("Enter the number of leafs:");
            int leafs = Validate.InputInterger();

            Console.WriteLine("Enter the height of the tree:");
            double height = Validate.InputDouble();

            Console.WriteLine("Enter the health status of the tree (1 for Good, 2 for Fair, 3 for Poor):");
            var healthStatus = (HealthStatus)Validate.InputInterger(); // Input tree health status
            var tree = new Tree(fruits, leafs, name, height, healthStatus);
            return tree;
        }

        //plant tree
        public static void plantTree(List<Tree> Garden)
        {
            Garden.Add(inputTree());
        }

        //plant tree in empty index of graden
        public static void quickPlant(List<Tree> Garden)
        {
			Tree tree = new Tree();
			Garden.Add(tree);
		}

        public static void PlantOption(List<Tree> Garden)
        {
			//Console.WriteLine("");
			//Console.BackgroundColor = ConsoleColor.DarkBlue;
			int option;
			do
            {
                PrintMenu();
                Console.WriteLine("Select plant tree option:");
                option = Validate.InputInterger();
                PlantSelect(option, Garden);
                /*Console.Clear();*/
            } while (option != 0);
			//Console.ResetColor();
			//Console.WriteLine();
		}

        public static void PlantSelect(int option, List<Tree> Garden)
        {
            switch (option)
            {
                case 0:
                    Console.WriteLine("Exit the plan tree menu");
                    return;
                case 1:
                    plantTree(Garden);
                    Console.WriteLine($"New Tree added, garden have {Garden.Count} trees");
                    return;
                case 2:
                    quickPlant(Garden);
					Console.WriteLine($"New Tree added, garden have {Garden.Count} trees");
					break;
            }
        }

        public static void PrintMenu()
        {
			Console.WriteLine("|-----------------------------------------------------------------------------------------------|");
			Console.WriteLine("|				*______* Plant Tree Option Menu *______*				|");
			Console.WriteLine("|-----------------------------------------------------------------------------------------------|");

			var table = new ConsoleTable("Option", "Description");

			table.AddRow("1", "Plant new tree");
			table.AddRow("2", "Quick plant new tree");
			table.AddRow("0", "Return to main menu");

			table.Write(Format.Alternative);
		}
    }
}
