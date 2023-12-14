using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1651
{
    internal class Farmer
    {
        public bool Gender { get; set; }
        public string Name { get; set; }
        public List<Tree> Garden { get; set; }
        public List<IProduct> Products { get; set; }

        public void PlantTree(Tree tree)
        {
            // trong cay logic
        }
    }
}
