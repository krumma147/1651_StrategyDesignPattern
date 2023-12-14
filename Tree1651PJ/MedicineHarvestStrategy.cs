using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1651
{
    internal class MedicineHarvestStrategy : IHarvestStrategy
    {
        public IProduct Harvest() => new Medicine();
    }
}
