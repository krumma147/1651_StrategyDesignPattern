using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree1651PJ
{
    public class FruitHarvestStrategy : IHarvestStrategy
    {
        public IProduct Harvest() => new Fruit();

    }
}
