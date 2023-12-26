using TreeClassLibrary.Products;
using TreeClassLibrary;

namespace TreeClassLibrary.Strategy
{
    public interface IHarvestStrategy
    {
        List<Product> Harvest(Tree tree, double amount);
    }
}
