using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tree1651PJ;
using TreeClassLibrary.Product;

namespace TreeClassLibrary.Strategy
{
    public class MedicineHarvestStrategy : IHarvestStrategy
    {
		public IProduct Harvest(Tree tree, double amount)
		{
			double remain = tree.Leafs - amount;
			if (remain < 0)
			{
				Console.WriteLine($"Tree not have enough of leafs to harvest {amount} gram of leafs, please grow tree before harvest.");
				return null;
			}
			if (remain == 0)
			{
				Console.WriteLine($"Harvested all amount, do you want to proceed? (Y/N)");
				// Validate amount and turn tree condition to bad if harvest all
				return null;
			}

			tree.Leafs = remain;
			if (tree.Leafs <= 2)
			{
				tree.HealthStatus = HealthStatus.Bad;
			}
			Console.WriteLine($"Harvested {amount} killogram of woods, tree have {tree.Height} killogram left.");
			Console.WriteLine(tree.GetTreeStatus());
			return new Medicine(amount);
		}

		//Validate amount of leaf want to harvest
	}
}
