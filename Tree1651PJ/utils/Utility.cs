using TreeClassLibrary;
using TreeClassLibrary.Products;
using TreeManagerConsoleApp.Menu;

namespace TreeManagerConsoleApp.utils
{
    public class Utility
    {
        public static void CountTime()
        {
            int secondsPassed = 0;
            while (secondsPassed < 30)
            {
                Thread.Sleep(1000); // Đợi 1 giây
                secondsPassed++;
                Console.WriteLine($"Has passed: {secondsPassed} days");
            }
            Console.WriteLine("After a month: ");
        }

    }
}
