using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeClassLibrary.Products;
//using Tree1651PJ;
using TreeClassLibrary.Strategy;

namespace TreeClassLibrary.Strategy
{
    public class MedicineHarvestStrategy : IHarvestStrategy
    {
		public List<Product> Harvest(Tree tree, double amount)
		{
			double remain = tree.Leafs - amount;
			if (remain < 0)
			{
				Console.WriteLine($"Tree does not have enough leafs to harvest {amount} grams, please grow the tree before harvesting.");
				return new List<Product>();
			}

			tree.Leafs = remain;
			tree.HealthStatus = tree.UpdateTreeStatus();

			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine($"Harvested {amount} grams of leafs, tree has {tree.Leafs} grams of leafs left.");
			Console.WriteLine(tree.GetTreeStatus());

			// More logic to create products here
			List<Product> harvestedProducts = new List<Product>();
			for (int i = 0; i < amount; i++)
			{
				harvestedProducts.Add(new Medicine());
			}

			Console.ResetColor();
			return harvestedProducts;
		}

		//Validate amount of leaf want to harvest
	}
}
