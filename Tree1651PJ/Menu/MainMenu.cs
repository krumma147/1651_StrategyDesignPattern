using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTables;
using Tree1651PJ;

namespace TreeManagerConsoleApp.Menu
{
    public class MainMenu
    {
        public static void MenuOption(List<Tree> Garden)
        {
            int option = -1;
            do
            {
                PrintMainMenu();
                Console.WriteLine("Select your option here:");
                //validate option
                try
                {
                    option = Validate.InputInterger();
                    MainMenuSelect(option, Garden);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input, please enter a valid number.");
                    continue;
                }
            } while (option != 0);
        }
        public static void MainMenuSelect(int option, List<Tree> Garden)
        {
            switch (option)
            {
                case 0:
                    Console.WriteLine("Exit the program");
                    return;
                case 1:
                    PlantMenu.PlantOption(Garden);
                    break;
                case 2:
                    GrowthMenu.GrowthOption(Garden);
                    break;
                case 3:
                    HarvestMenu.Menu(Garden);
                    break;
                case 4:
                    TreeStatusOption(Garden);
                    break;
                case 5:
                    ClearConsole();
                    break;
                default:
                    Console.WriteLine("Other!");
                    break;
            }
        }

        public static void PrintMainMenu()
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

        public static void TreeStatusOption(List<Tree> Garden)
        {
            if(Garden.Count <= 0)
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
			for (int i = 0; i< Garden.Count; i++)
            {
				table.AddRow(i+1 ,Garden[i].Name, Garden[i].Fruits, Garden[i].Leafs, Garden[i].Height, Garden[i].HealthStatus);
			}
			table.Write(Format.Alternative);
            
            Console.ResetColor();
			Console.WriteLine();
		}

        public static void ClearConsole()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0); /*FIXME: Con trỏ chuột chưa về trên cùng*/
        }
    }
}
