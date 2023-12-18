using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeClassLibrary.Products;

namespace TreeClassLibrary.Strategy
{
	public class FruitHarvestStrategy : IHarvestStrategy
    {
		public List<Product> Harvest(Tree tree, double amount)
		{
			int remain = tree.Fruits - (int) amount;
			if (remain < 0)
			{
				Console.WriteLine($"Tree does not have enough fruits to harvest {amount}, please grow the tree before harvesting.");
				return new List<Product>();
			}

			tree.Fruits = remain;
			tree.HealthStatus = tree.UpdateTreeStatus();

			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine($"Harvested {amount} fruits, tree has {tree.Fruits} fruits left.");
			Console.WriteLine(tree.GetTreeStatus());

			// More logic to create products here
			List<Product> harvestedProducts = new List<Product>();
			for (int i = 0; i < amount; i++)
			{
				harvestedProducts.Add(new Fruit("sweet"));
			}

			Console.ResetColor();
			return harvestedProducts;
		}

		//Validate amount of fruits want to harvest


	}
}
