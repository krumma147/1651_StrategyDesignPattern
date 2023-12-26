using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeClassLibrary.Products
{
    public class Fruit : Product
    {
		public string Taste { get; set; }

		public Fruit() {
			Taste = "Sweet";
		}

		public Fruit(string taste) : base()
		{
			Taste = taste;
		}
		public override void Use()
		{
            Console.WriteLine("Using fruit:");
			Consume();
			MakeGift();

        }

		public void MakeGift()
        {
			Console.WriteLine("Using fruits to make gift...");
		}

        public void Consume()
        {
            Console.WriteLine("Consuming fruits...");
        }

    }
}
