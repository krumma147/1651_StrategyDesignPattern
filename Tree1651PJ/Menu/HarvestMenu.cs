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
            double amount = 0.0f;
            switch (option)
            {
                case 0:
                    break;
                case 1:
                    tree.SetHarvestStrategy(new FruitHarvestStrategy());
					Console.WriteLine("Amount of fruit want to harvest?");
					amount = Validate.InputDouble();
                    if(Validate.ValidateHarvestAmount(Convert.ToDouble(tree.Fruits), amount)) {
                        tree.Harvest(amount);
                    }
					//tree.Harvest(amount);
					break;
                case 2:
                    tree.SetHarvestStrategy(new WoodHarvestStrategy());
					Console.WriteLine("Amount of wood want to harvest?");
                    if (Validate.ValidateHarvestAmount(tree.Height, amount))
                    {
                        tree.Harvest(amount);
                    }
                    //tree.Harvest(amount);
					break;
                case 3:
					tree.SetHarvestStrategy(new MedicineHarvestStrategy());
					Console.WriteLine("Amount of medicine want to harvest?");
                    if (Validate.ValidateHarvestAmount(tree.Leafs, amount))
                    {
                        tree.Harvest(amount);
                    }
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
 