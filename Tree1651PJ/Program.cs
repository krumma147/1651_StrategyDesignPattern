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
			MainMenu.MenuOption(Garden);
		}
	}
}
