using ConsoleTables;
using TreeClassLibrary;
using TreeClassLibrary.Products;

namespace TreeManagerConsoleApp.Menu
{
    
    public class MainMenu
    {
        private List<Tree> _trees;
        private List<Product> _products;
        private readonly GrowthMenu _growthMenu;
        private readonly PlantMenu _plantMenu;
        private readonly HarvestMenu _harvestMenu;

        public MainMenu()
        {
            _trees = new List<Tree>();
            _products = new List<Product>();
            _growthMenu = new GrowthMenu();
            _plantMenu = new PlantMenu();
            _harvestMenu = new HarvestMenu();
        }
        public void MainProgram()
        {
            var option = -1;
            do
            {
                PrintMainMenu();
                Console.WriteLine("Select your option here:");
                //validate option
                try
                {
                    option = ConsoleCommons.InputInteger();
                    MainMenuSelect(option);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input, please enter a valid number.");
                    //continue is redundant;
                }
            } while (option != 0);
        }

        private void MainMenuSelect(int option)
        {
            switch (option)
            {
                case 0:
                    Console.WriteLine("Exit the program");
                    return;
                case 1:
                    _trees.AddRange(_plantMenu.PlantOption(_trees));
                    break;
                case 2:
                    var tree = SelectTree();
                    if (tree != null)
                    {
                        _growthMenu.GrowthOption(tree);
                    }

                    break;
                case 3:
                    var harvestedTree = SelectTree();
                    if (harvestedTree != null)
                    {
                        _harvestMenu.Harvest(harvestedTree);
                    }
                   
                    break;
                case 4:
                    TreeStatusOption();
                    break;
                case 5:
                    ConsoleCommons.ClearConsole();
                    break;
                default:
                    Console.WriteLine("Other!");
                    break;
            }
        }

        private void PrintMainMenu()
        {
			Console.WriteLine("|-----------------------------------------------------------------------------------------------|");
			Console.WriteLine("|				*______* Tree Management Menu *______*				|");
			Console.WriteLine("|-----------------------------------------------------------------------------------------------|");

			var table = new ConsoleTable("Option", "Description");

			table.AddRow("1", "Plant Tree");
			table.AddRow("2", "Growth Tree");
			table.AddRow("3", "Harvest Tree");
			table.AddRow("4", "Tree Status");
			table.AddRow("5", "Clear Console");
			table.AddRow("0", "Exit");

			table.Write(Format.Alternative);
		}

        private void TreeStatusOption()
        {
            if(_trees.Count <= 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("There are no tree in the garden!");
                Console.ResetColor();
                return;
            }
			Console.BackgroundColor = ConsoleColor.DarkGreen;
			Console.WriteLine("\n|------------------------------------------------------|");
			Console.WriteLine("|				*______* All Tree Status *______*				|");
			Console.WriteLine("|------------------------------------------------------|");
			var table = new ConsoleTable("No.", "Tree Name", "Number of Fruits", "Number of Leafs", "Tree Height (meters)", "Health Status");
			for (var i = 0; i< _trees.Count; i++)
            {
				table.AddRow(i+1 ,_trees[i].Name, _trees[i].Fruits, _trees[i].Leafs, _trees[i].Weight, _trees[i].HealthStatus);
			}
			table.Write(Format.Alternative);
            
            Console.ResetColor();
			Console.WriteLine();
		}
        
        private Tree? SelectTree() // Nullable
        {
            try
            {
                if (_trees.Count <= 0)
                {
                    Console.WriteLine($"There are {_trees.Count} tree in the garden, plant some tree first");
                    return null;
                }

                Console.WriteLine($"There are {_trees.Count} tree in the garden, select tree you want to harvest:");
                var index = ConsoleCommons.InputInteger();
                return _trees[index - 1];
            }
            catch (Exception)
            {
                Console.WriteLine($"The index you've entered is out of tree indexes range");
            }

            return null;
        }
    }
}
