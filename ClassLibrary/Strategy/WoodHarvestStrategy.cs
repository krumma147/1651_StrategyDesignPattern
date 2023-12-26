using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeClassLibrary;
using TreeClassLibrary.Products;

namespace TreeClassLibrary.Strategy
{
    public class WoodHarvestStrategy : IHarvestStrategy
    {
		public List<Product> Harvest(Tree tree, double amount)
		{
			double remain = tree.Weight - amount;
			if (remain < 0)
			{
				Console.WriteLine($"Tree not have enough products to harvest {amount} kilograms of woods, please grow the tree before harvesting.");
				return new List<Product>();
			}

			tree.Weight = remain;
			tree.HealthStatus = tree.UpdateTreeStatus();

			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine($"Harvested {amount} kilograms of woods, tree has {tree.Weight} kilograms left.");
			tree.GetTreeStatus();

			List<Product> harvestedProducts = new List<Product>();
			for (int i = 0; i < amount; i++)
			{
				harvestedProducts.Add(new Wood("Brown", "Red Oak"));
			}

			Console.ResetColor();
			return harvestedProducts;
		}

	}
}
