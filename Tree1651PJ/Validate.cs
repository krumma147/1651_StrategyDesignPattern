using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TreeManagerConsoleApp
{
	public class Validate
	{
		//check name
		private static bool IsValidName(string name)
		{
			return Regex.IsMatch(name, "^[a-zA-Z ]+$", RegexOptions.IgnoreCase);
		}

		//input name
		public static string InputName()
		{
			string name;
			do
			{
				name = Console.ReadLine();
				if (!IsValidName(name))
				{
					Console.WriteLine("Invalid name! Please enter a name with letters only (a-z).");
				}
			} while (!IsValidName(name));

			return name;
		}

		//input number
		public static int InputInterger()
		{
			bool isValidInput = false;
			int option = 0;
			do
			{
				try
				{
					option = int.Parse(Console.ReadLine());
					if (option < 0)
					{
						Console.WriteLine("Please enter a non-negative number.");
					}
					else
					{
						isValidInput = true;
					}
				}
				catch (FormatException)
				{
					Console.WriteLine("Invalid input, please enter a valid number.");
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
					number = double.Parse(Console.ReadLine());
					if (number < 0)
					{
						Console.WriteLine("Please enter a non-negative number.");
					}
					else
					{
						isValidInput = true;
					}
				}
				catch (FormatException)
				{
					Console.WriteLine("Invalid input, please enter a valid number.");
				}
			} while (!isValidInput);

			return number;
		}

		public static bool InputGender()
		{
			string gender = "";
			bool result;
			do
			{
				Console.WriteLine("Input farmer gender (M/F): ");
				gender = Console.ReadLine();
				if (gender.ToLower() == "m" || gender.ToLower() == "male")
					result = true;
				else
					result = false;
			} while (gender.ToLower() != "m" && gender.ToLower() != "f" && gender.ToLower() != "male" && gender.ToLower() != "female");
			return result;
		}
	}
}
