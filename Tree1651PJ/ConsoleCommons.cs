using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TreeManagerConsoleApp
{
    public static class ConsoleCommons
    {
        //check name
        private static bool IsValidName(string name)
        {
            return Regex.IsMatch(name, "^[a-zA-Z ]+$", RegexOptions.IgnoreCase);
        }

        //input name
        public static string InputName()
        {
            string name; // nullable string
            while (true)
            {
                var input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input))
                {
                    name = input;
                    if (IsValidName(name))
                    {
                        break;
                    }
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid name! Please enter a name with letters only (a-z).");
                Console.ResetColor();
            };
            return name;
        }

        //input number
        public static int InputInteger()
        {
            bool isValidInput = false;
            int option = 0;
            do
            {
                try
                {
                    if (int.TryParse(Console.ReadLine(), out option))
                    {
                        if (option < 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Please enter a non-negative number.");
                            Console.ResetColor();
                        }
                        else
                        {
                            isValidInput = true;
                        }
                    }
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input, please enter a valid number.");
                    Console.ResetColor();
                }
            } while (!isValidInput);

            return option;
        }

        //input number
        public static double InputDouble()
        {
            bool isValidInput = false;
            double number = 0;
            do
            {
                try
                {
                    if (double.TryParse(Console.ReadLine(), out number))
                    {
                        if (number < 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Please enter a non-negative number.");
                            Console.ResetColor();
                        }
                        else
                        {
                            isValidInput = true;
                        }
                    }
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input, please enter a valid number.");
                    Console.ResetColor();
                }
            } while (!isValidInput);

            return number;
        }

        public static void ClearConsole()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0); /*FIXME: Con trỏ chuột chưa về trên cùng*/
        }
       
    }
}