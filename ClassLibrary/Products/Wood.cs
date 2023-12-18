using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeClassLibrary.Products
{
    public class Wood : Product
    {
        private string hardness;
        private string color;
        public string Hardness { get => hardness; set => value = hardness; }
        public string Color { get => color; set => value = color; }
        public double amount;
        public Wood()
        {
            Hardness = "Tough";
            Color = "Dark Brown";

		}


		public Wood(double amount)
		{
            this.amount = amount;
		}

        public Wood(string hardness, string color)
        {
            Hardness = hardness;
            Color = color;

        }

        public void MakeFurniture()
        {
            // furniture making logic
        }

        public void Burn()
        {
            // logic burn
        }

        public void Use()
        {
            throw new NotImplementedException();
        }
    }
}
