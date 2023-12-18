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
			base.Use();
			//logic use Fruit or others
		}

		public void MakeGift()
        {
            // login quà
        }

        public void Consume()
        {
            //logic tieu thu
        }

    }
}
