using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tree1651PJ;

namespace TreeManagerConsoleApp.Menu
{
    public class MainMenu
    {
        public static void MenuOption(Farmer farmer, List<Tree> Garden)
        {
            int option = -1;
            do
            {
                PrintMainMenu(farmer);
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

        public static void TreeStatusOption(List<Tree> Garden)
        {
            int option;

            //Console.WriteLine("Tree status option!");
            foreach (Tree tree in Garden)
            {
                Console.WriteLine(tree.GetTreeStatus());
            }
        }

        public static void ClearConsole()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0); /*FIXME: Con trỏ chuột chưa về trên cùng*/
        }
    }
}
