using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeClassLibrary.Product;

namespace TreeClassLibrary.Strategy
{
    public class FruitHarvestStrategy : IHarvestStrategy
    {
        public IProduct Harvest() => new Fruit();

    }
}
