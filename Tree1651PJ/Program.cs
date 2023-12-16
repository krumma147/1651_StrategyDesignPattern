using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Tree1651PJ;
using TreeClassLibrary.Product;
using TreeManagerConsoleApp.Menu;

namespace TreeManagerConsoleApp
{
    class Program
	{
        public static List<Tree> Garden = new List<Tree>();
        public static List<IProduct> Products = new List<IProduct>();

        static void Main(string[] args)
		{
			// Display the number of command line arguments.
			MainMenu.MenuOption(Garden);
		}

	}
}
