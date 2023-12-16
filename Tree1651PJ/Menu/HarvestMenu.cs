using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tree1651PJ;
using TreeClassLibrary.Strategy;

namespace TreeManagerConsoleApp.Menu
{
    public class HarvestMenu
    {
        public static void Menu(List<Tree> Garden)
        {
            int option;
            Tree tree = SelectTree(Garden);
			do
            {
                PrintMenu();
                Console.WriteLine("Select harvest tree option:");
                option = Validate.InputInterger();
                Select(option, tree);
            } while (option != 0);
        }

        public static void Select(int option, Tree tree)
        {
            switch (option)
            {
                case 0:
                    break;
                case 1:
                    Console.WriteLine("Harvest Fruit");
                    //WoodHarvestStrategy;
                    break;
                case 2:
                    Console.WriteLine("Harvest Wood");
                    break;
                case 3:
                    Console.WriteLine("Harvest Medicine");
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

        public static Tree SelectTree(List<Tree> Garden)
        {
			Console.WriteLine($"There are {Garden.Count} tree in the garden, select tree you want to harvest:");
			int index = Validate.InputInterger() -1;
			return Garden[index];
        }
    }
}
 