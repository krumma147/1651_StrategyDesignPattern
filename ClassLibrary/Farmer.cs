using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree1651PJ
{
    public class Farmer
    {
        public bool Gender { get; set; }
        public string Name { get; set; }
        public List<Tree> Garden { get; set; }
        public List<IProduct> Products { get; set; }

        public Farmer()
        {
			Garden = new List<Tree>();
			Products = new List<IProduct>();
		}

        public Farmer(bool gender, string name)
        {
			Gender = true;
			Name = "Farmer";
			Garden = new List<Tree>();
			Products = new List<IProduct>();
		}

		public void PlantTree(Tree tree)
        {
            // trong cay logic
        }
    }
}
