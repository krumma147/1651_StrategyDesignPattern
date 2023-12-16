using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tree1651PJ;


namespace TreeManagerConsoleApp.Menu
{
    public class GrowthMenu
    {
        public static void GrowthOption(List<Tree> Garden)
        {
            Tree tree = HarvestMenu.SelectTree(Garden);
			if (tree == null) return;
			int option;
            do
            {
                PrintMenu();
                Console.WriteLine("Select growth tree option:");
                option = Validate.InputInterger();
                GrowthSelect(option, tree);
            } while (option != 0);
        }

        public static void GrowthSelect(int option, Tree tree)
        {
            switch (option)
            {
                case 0:
                    return;
                case 1:
                    tree.Watering();
                    Console.WriteLine("Watering"); // Watering Function
                    break;
                case 2:
                    tree.Fertilizing();
                    Console.WriteLine("Fertilizing"); // Fertilizing Function
                    break;
                case 3:
                    tree.AbsorbCO2();
                    Console.WriteLine("Providing CO2"); // Provide CO2 Function
                    break;
            }
        }

        public static void PrintMenu()
        {
			Console.WriteLine("|-----------------------------------------------------------------------------------------------|");
			Console.WriteLine("|				*______* Growth Tree Option Menu *______*				|");
			Console.WriteLine("|-----------------------------------------------------------------------------------------------|");

			var table = new ConsoleTable("Option", "Description");

			table.AddRow("1", "Water the plant");
			table.AddRow("2", "Fertilize the plant");
			table.AddRow("3", "Provide CO2");
			table.AddRow("0", "Return to main menu");

			table.Write(Format.Alternative);
		}
    }
}
