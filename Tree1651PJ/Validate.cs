﻿using System;
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
				if (!string.IsNullOrEmpty(name))
				{
					if (IsValidName(name))
					{
						break;
					}
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid name! Please enter a name with letters only (a-z).");
                Console.ResetColor();
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
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please enter a non-negative number.");
                        Console.ResetColor();
                    }
					else
					{
						isValidInput = true;
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
					number = double.Parse(Console.ReadLine());
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
				catch (FormatException)
				{
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input, please enter a valid number.");
                    Console.ResetColor();
                }
			} while (!isValidInput);

			return number;
		}

		public static bool ValidateHarvestAmount(double treeResources, double harvestAmount)
		{
			if (harvestAmount == treeResources)
			{
				Console.WriteLine($"Harvested all resources, do you want to proceed? (Y/N)");
				string confirm = Console.ReadLine();
				if (confirm.ToLower() == "yes" || confirm.ToLower() == "y") return true;
				else if (confirm.ToLower() == "no" || confirm.ToLower() == "n") return false;
			}
			else if (harvestAmount > treeResources)
			{
				Console.ForegroundColor = ConsoleColor.DarkYellow;
				Console.WriteLine($"Can't harvest over {treeResources} resources!");
				Console.ResetColor();
				return false;
			}
			return true;
		}
	}
}
