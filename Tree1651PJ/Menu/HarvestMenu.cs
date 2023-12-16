using ConsoleTables;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeClassLibrary;
using TreeClassLibrary.Products;
using TreeClassLibrary.Strategy;
using TreeManagerConsoleApp.utils;

namespace TreeManagerConsoleApp.Menu
{
    public class HarvestMenu
    {
        private IHarvestStrategy _harvestStrategy;

        public HarvestMenu()
        {
            _harvestStrategy = new WoodHarvestStrategy();
        }

        public IEnumerable<Product> Harvest(Tree tree)
        {
            int option;
            var products = new List<Product>();
            do
            {
                PrintMenu();
                Console.WriteLine("Select harvest tree option:");
                option = ConsoleCommons.InputInteger();
                products.AddRange(Harvest(option, tree));
            } while (option != 0);

            return products;
        }

        private IEnumerable<Product> HarvestWithAmount(Tree tree, int amount)
        {
            var products = _harvestStrategy.Harvest(tree, amount).ToList();
            if (products.Any())
            {
                Console.WriteLine($"Harvested: {products[0].GetType().Name} with amount {amount}");
            }

            return products;
        }

        private IEnumerable<Product> Harvest(int option, Tree tree)
        {
            int amount;
            switch (option)
            {
                case 1:
                    _harvestStrategy = new FruitHarvestStrategy();
                    Console.WriteLine("Amount of fruit want to harvest?");
                    amount = ConsoleCommons.InputInteger();
                    if (ValidateHarvestAmount(Convert.ToDouble(tree.Fruits), amount))
                    {
                        return HarvestWithAmount(tree, amount);
                    }

                    //tree.Harvest(amount);
                    break;
                case 2:
                    _harvestStrategy = new WoodHarvestStrategy();
                    Console.WriteLine("Amount of wood want to harvest?");
                    amount = ConsoleCommons.InputInteger();
                    if (ValidateHarvestAmount(tree.Weight, amount))
                    {
                        return HarvestWithAmount(tree, amount);
                    }

                    break;
                case 3:
                    _harvestStrategy = new MedicineHarvestStrategy();
                    Console.WriteLine("Amount of medicine want to harvest?");
                    amount = ConsoleCommons.InputInteger();
                    if (ValidateHarvestAmount(tree.Leafs, amount))
                    {
                        return HarvestWithAmount(tree, amount);
                    }

                    break;
            }

            return new List<Product>();
        }

        private void PrintMenu()
        {
            Console.WriteLine(
                "|-----------------------------------------------------------------------------------------------|");
            Console.WriteLine("|				*______* Harvest Tree Option Menu *______*				|");
            Console.WriteLine(
                "|-----------------------------------------------------------------------------------------------|");

            var table = new ConsoleTable("Option", "Description");

            table.AddRow("1", "Harvest Fruit");
            table.AddRow("2", "Harvest Wood");
            table.AddRow("3", "Harvest Medicine Leaf");
            table.AddRow("0", "Return to main menu");

            table.Write(Format.Alternative);
        }

        private bool ValidateHarvestAmount(double treeResources, double harvestAmount)
        {
            if (Math.Abs(harvestAmount - treeResources) < Constant.TOLERANCE) // comparing 2 floats should use epsilon
            {
                Console.WriteLine($"Harvested all resources, do you want to proceed? (Y/N)");
                var confirm = Console.ReadLine();
                if (!string.IsNullOrEmpty(confirm))
                {
                    if (confirm.ToLower() != "yes" && confirm.ToLower() != "y")
                    {
                        if (confirm.ToLower() == "no" || confirm.ToLower() == "n")
                            return false;
                    }
                    else
                        return true;
                }
            }
            else if (harvestAmount > treeResources)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"Can't harvest over {treeResources} resources!");
                Console.ResetColor();
                return false;
            }

            return true;
        }
    }
}