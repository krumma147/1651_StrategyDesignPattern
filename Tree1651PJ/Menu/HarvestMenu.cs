using ConsoleTables;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using TreeClassLibrary;
using TreeClassLibrary.Products;
using TreeClassLibrary.Strategy;

namespace TreeManagerConsoleApp.Menu
{
    public class HarvestMenu
    {
		private static IHarvestStrategy _harvestStrategy;

		public HarvestMenu()
		{
			_harvestStrategy = new WoodHarvestStrategy();
		}

		public static void Menu(List<Tree> Garden, List<Product> Products)
        {
            Tree tree = SelectTree(Garden);
			if (tree == null) return;

			int option;
			do
            {
                PrintMenu();
                Console.WriteLine("Select harvest tree option:");
                option = Validate.InputInterger();
                Select(option, tree, Products);
            } while (option != 0);
        }

        public static void Select(int option, Tree tree, List<Product> Products)
        {
            double amount;
            switch (option)
            {
                case 0:
                    return;
                case 1:
					_harvestStrategy = new FruitHarvestStrategy();
					Console.WriteLine("Amount of fruit want to harvest?");
					amount = Validate.InputDouble();
                    if(Validate.ValidateHarvestAmount(Convert.ToDouble(tree.Fruits), amount)) {
						List<Product> harvested = _harvestStrategy.Harvest(tree, amount);
						Products.AddRange(harvested);
					}
					break;
                case 2:
					_harvestStrategy = new WoodHarvestStrategy();
					Console.WriteLine("Amount of wood want to harvest?"); 
					amount = Validate.InputDouble();
					if (Validate.ValidateHarvestAmount(tree.Weight, amount))
                    {
						List<Product> harvested = _harvestStrategy.Harvest(tree, amount);
						Products.AddRange(harvested);
					}
					break;
                case 3:
					_harvestStrategy = new MedicineHarvestStrategy();
					Console.WriteLine("Amount of medicine want to harvest?");
					amount = Validate.InputDouble();
					if (Validate.ValidateHarvestAmount(tree.Leafs, amount))
                    {
						List<Product> harvested = _harvestStrategy.Harvest(tree, amount);
						Products.AddRange(harvested);
					}
                    break;
            }
        }

        public static void PrintMenu()
        {
			Console.WriteLine("|-----------------------------------------------------------------------------------------------|");
			Console.WriteLine("|				*______* Harvest Tree Option Menu *______*				|");
			Console.WriteLine("|-----------------------------------------------------------------------------------------------|");

			var table = new ConsoleTable("Option", "Description");

			table.AddRow("1", "Harvest Fruit");
			table.AddRow("2", "Harvest Wood");
			table.AddRow("3", "Harvest Medicine Leaf");
			table.AddRow("0", "Return to main menu");

			table.Write(Format.Alternative);
		}

        public static Tree SelectTree(List<Tree> Garden)
        {
            if(Garden.Count <= 0)
            {
				Console.WriteLine($"There are {Garden.Count} tree in the garden, plant some tree first");
                return null;
			}
			Console.WriteLine($"There are {Garden.Count} tree in the garden, select tree you want to harvest:");
			int index = Validate.InputInterger();
			return Garden[index-1];
        }

	}
}
 