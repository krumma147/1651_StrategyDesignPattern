using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeClassLibrary.Products
{
    public class Wood : Product
    {
        private string _hardness;
        private string _color;

        public string Hardness
        {
            get => _hardness;
            set =>  _hardness = value; // field = value NOT value = field ???????
        }

        public string Color
        {
            get => _color;
            set => _color = value;
        }
        
        public Wood(string color)
        {
            _hardness = string.Empty;
            _color = string.Empty;
        }

		public Wood(string color, string hardness)
        {
            _color = color;
            _hardness = hardness;
        }

		public void MakeFurniture()
        {
            // furniture making logic
        }

        public void Burn()
        {
            // logic burn
        }

        public override void Use()
        {
            throw new NotImplementedException();
        }
    }
}
