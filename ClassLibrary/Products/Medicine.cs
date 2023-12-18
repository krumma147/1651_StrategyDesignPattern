using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeClassLibrary.Products
{
    public class Medicine : Product
    {
		public string Usage { get; set; }
		public string MedicineType { get; set; }
		public Medicine()
		{
			MedicineType = string.Empty;
			Usage = string.Empty;
		}

        public Medicine(string medicineType)
        {
            MedicineType = medicineType;
        }

        public Medicine(string medicineType, string usage)
		{
			this.MedicineType = medicineType;
			Usage = usage;
		}

		public void MakeProduct()
        {
            //  product making logic
        }
        public void Use()
        {
			base.Use();
		}
    }
}
