using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeClassLibrary.Products;

namespace TreeClassLibrary.Strategy
{
    public class WoodHarvestStrategy : IHarvestStrategy
    {
	    //
	    // For more wood product information, refer https://www.arborday.org/trees/righttreeandplace/size.cfm
	    //
		public IEnumerable<Product> Harvest(Tree tree, int amount)
		{
			
			var remain = tree.Weight - amount;
			if (remain < 0)
			{
				Console.WriteLine($"Tree not high enough to harvest {amount} of woods, please grow tree before harvest."); // TO DO: Need update message
				return new List<Product>();
			}
			
			
			
			tree.Weight = remain;
			tree.HealthStatus = tree.GetTreeHealthStatus();
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine($"Harvested {amount} kilogram of woods, tree have {tree.Weight} kilogram left.");// TO DO: Need update message
			tree.GetTreeStatus();
			// More logic create product here
			Console.ResetColor();
			return Enumerable.Range(1, amount).Select(i => new Wood("Brown", "Red Oak"));
		}
    }
}
