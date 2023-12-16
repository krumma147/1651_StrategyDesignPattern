using TreeClassLibrary.Products;

namespace TreeClassLibrary.Strategy
{
    public interface IHarvestStrategy
    {
        IEnumerable<Product> Harvest(Tree tree, int amount);
    }
}
