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
        public string Hardness { get => hardness; set => hardness = value; }
        public string Color { get => color; set => color = value; }
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
            Console.WriteLine($"Using wood to make a {Hardness} chair with color of {Color}");
        }
        public void Burn()
        {
            Console.WriteLine("Using wood for campfire...");
        }
        public override void Use()
        {
            MakeFurniture();
		}
    }
}
