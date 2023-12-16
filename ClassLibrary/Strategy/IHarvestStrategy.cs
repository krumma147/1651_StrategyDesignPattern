using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tree1651PJ;
using TreeClassLibrary.Product;

namespace TreeClassLibrary.Strategy
{
    public interface IHarvestStrategy
    {
        IProduct Harvest(Tree tree, double amount);
    }
}
