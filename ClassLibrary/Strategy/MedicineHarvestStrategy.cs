using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeClassLibrary.Products;

namespace TreeClassLibrary.Strategy
{
    public class MedicineHarvestStrategy : IHarvestStrategy
    {
		public IEnumerable<Product> Harvest(Tree tree, int amount)
		{
			var remain = tree.Leafs - amount;
			if (remain < 0)
			{
				Console.WriteLine($"Tree not have enough of leafs to harvest {amount} gram of leafs, please grow tree before harvest.");
				return new List<Product>();
			}
			if (remain == 0)
			{
				Console.WriteLine($"Harvested all amount, do you want to proceed? (Y/N)");
				// Validate amount and turn tree condition to bad if harvest all
				return new List<Product>();
			}

			tree.Leafs = remain;
			tree.HealthStatus = tree.GetTreeHealthStatus();
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine($"Harvested {amount} of leafs, tree has {tree.Weight} leafs left.");
			Console.WriteLine(tree.GetTreeStatus());
			// More logic create product here
			Console.ResetColor();
			return Enumerable.Range(0, amount).Select(i => new Medicine()).ToList(); // refer https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.range
		}

		//Validate amount of leaf want to harvest
	}
}
