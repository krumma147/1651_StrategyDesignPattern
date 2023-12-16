using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeClassLibrary;

namespace TreeManagerConsoleApp.Menu
{
    public class PlantMenu
    {

        //input tree
        private Tree PlantTree()
        {
            Console.WriteLine("Enter the name of the tree:");
            var name = ConsoleCommons.InputName();

            // Console.WriteLine("Enter the number of fruits:");
            // int fruits = ConsoleCommons.InputInterger();
            //
            // Console.WriteLine("Enter the number of leafs:");
            // int leafs = ConsoleCommons.InputInterger();
            //
            // Console.WriteLine("Enter the height of the tree:");
            // double height = ConsoleCommons.InputDouble();
            //
            // Console.WriteLine("Enter the health status of the tree (1 for Good, 2 for Fair, 3 for Poor):");
            // var healthStatus = (HealthStatus)ConsoleCommons.InputInterger(); // Input tree health status
            var tree = new Tree(name);
            return tree;
        }

        //plant tree
        // private void PlantTree(List<Tree> garden)
        // {
        //     garden.Add(InputTree());
        // }

        //plant tree in empty index of graden
        private void QuickPlant(List<Tree> garden)
        {
			garden.Add(new Tree());
		}

        public IEnumerable<Tree> PlantOption(List<Tree> garden)
        {
			//Console.WriteLine("");
			//Console.BackgroundColor = ConsoleColor.DarkBlue;
			var newTrees = new List<Tree>();
			int option;
			do
            {
                PrintMenu();
                Console.WriteLine("Select plant tree option:");
                option = ConsoleCommons.InputInteger();
                var newTree = PlantTree(option);
                if (newTree != null)
                {
	                newTrees.Add(newTree);
                }
                /*Console.Clear();*/
            } while (option != 0);
			//Console.ResetColor();
			//Console.WriteLine();
			return newTrees;
        }

        private Tree? PlantTree(int option)
        {
	        Tree? tree = null;
            switch (option)
            {
                case 0:
                    Console.WriteLine("Exit the plan tree menu");
                    break;
                case 1:
                    tree = PlantTree();
                    Console.WriteLine($"New Tree added");
                    return tree;
                case 2:
     //                QuickPlant(garden);
					// Console.WriteLine($"New Tree added, garden have {garden.Count} trees");
					break;

            }

            return tree;
        }

        private void PrintMenu()
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
