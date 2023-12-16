using TreeClassLibrary.Products;

namespace TreeClassLibrary.Strategy
{
	public class FruitHarvestStrategy : IHarvestStrategy
    {
		public IEnumerable<Product> Harvest(Tree tree, int amount)
		{
			int remain = tree.Fruits - amount;
			if (remain < 0)
			{
				Console.WriteLine($"Tree not have enough of fruits to harvest {amount} gram of fruits, please grow tree before harvest.");
				return new List<Product>();
			}
			tree.Fruits = remain;
			tree.HealthStatus = tree.GetTreeHealthStatus();
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine($"Harvested {amount} of fruits, tree have {tree.Fruits} of fruits left.");
            Console.WriteLine(tree.GetTreeStatus());
            // More logic create product here
			Console.ResetColor();
            return Enumerable.Range(1,amount ).Select(i => new Fruit("sweet"));
		}

		//Validate amount of fruits want to harvest


	}
}
