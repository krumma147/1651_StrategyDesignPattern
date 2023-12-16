using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tree1651PJ;
using TreeClassLibrary.Product;

namespace TreeClassLibrary.Strategy
{
	public class FruitHarvestStrategy : IHarvestStrategy
    {
		public IProduct Harvest(Tree tree, double amount)
		{
			int remain = tree.Fruits - (int)amount;
			if (remain < 0)
			{
				Console.WriteLine($"Tree not have enough of fruits to harvest {amount} gram of fruits, please grow tree before harvest.");
				return null;
			}
			tree.Fruits = remain;
			tree.HealthStatus = tree.UpdateTreeStatus();
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine($"Harvested {amount} of fruits, tree have {tree.Fruits} of fruits left.");
            Console.WriteLine(tree.GetTreeStatus());
			Console.ResetColor();
            return new Fruit((int)amount);
		}

		//Validate amount of fruits want to harvest


	}
}
