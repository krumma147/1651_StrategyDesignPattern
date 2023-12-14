using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree1651PJ
{
    internal class MedicineHarvestStrategy : IHarvestStrategy
    {
        public IProduct Harvest() => new Medicine();
    }
}
