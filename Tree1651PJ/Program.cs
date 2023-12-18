using TreeClassLibrary;
using TreeClassLibrary.Products;
using TreeManagerConsoleApp.Menu;

namespace TreeManagerConsoleApp
{
    class Program
	{
        public static List<Tree> Garden = new List<Tree>();

        static void Main(string[] args)
		{
			// Display the number of command line arguments.
			MainMenu.MenuOption(Garden);
		}

	}
}
