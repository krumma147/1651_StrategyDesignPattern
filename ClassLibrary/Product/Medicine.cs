using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeClassLibrary.Product
{
    internal class Medicine : IProduct
    {
        private string usage;
        private string medicineType;
        public string Usage { get => usage; set => value = usage; }
        public string MedicineType { get => medicineType; set => value = medicineType; }

        public Medicine()
        {

        }
        public void MakeProduct()
        {
            //  product making logic
        }
        public void Use()
        {
            throw new NotImplementedException();
        }
    }
}
