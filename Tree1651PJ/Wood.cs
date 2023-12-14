using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1651
{
    internal class Wood : IProduct
    {
        private string hardness;
        private string color;
        public string Hardness { get => hardness; set => value = hardness; }
        public string Color { get => color; set => value = color; }
        public Wood()
        {
            
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
