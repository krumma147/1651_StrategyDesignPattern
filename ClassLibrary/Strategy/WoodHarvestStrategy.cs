using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tree1651PJ;
using TreeClassLibrary.Product;

namespace TreeClassLibrary.Strategy
{
    public class WoodHarvestStrategy : IHarvestStrategy
    {
		public IProduct Harvest(Tree tree, double amount)
		{
			double remain = tree.Height - amount;
			if (remain < 0)
			{
                Console.WriteLine($"Tree not high enough to harvest {amount} killogram of woods, please grow tree before harvest.");
				return null;
            }
			tree.Height = remain;
			if (tree.Height <= 2)
			{
				tree.HealthStatus = HealthStatus.LackWater;
			}
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine($"Harvested {amount} killogram of woods, tree have {tree.Height} killogram left.");
			tree.GetTreeStatus();
			Console.ResetColor();
			return new Wood(amount);
		}
	}
}
