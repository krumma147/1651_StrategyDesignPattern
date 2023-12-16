using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tree1651PJ;
using TreeClassLibrary.Product;
using TreeClassLibrary.Strategy;
//using TreeManagerConsoleAp;

namespace Tree1651PJ
{
    public enum HealthStatus
    {
        Good = 1, 
        LackFertilize = 2, 
        LackWater = 3,
		LackCo2 = 4,
		Bad = 5
    } // Adding bad status
    public class Tree
    {
        private int fruits;
        private double leafs;
        private string name;
        private double height;
		private HealthStatus healthStatus;
		protected IHarvestStrategy harvestStrategy;

		public int Fruits { get=>fruits; set=> fruits = value; }
        public double Leafs {  get=>leafs; set=>leafs = value; }
		public string Name { get => name; private set =>name = value; }
		public double Height { get => height; set => height = value; }
        public HealthStatus HealthStatus { get => healthStatus; set => healthStatus = value; }

		public void SetHarvestStrategy(IHarvestStrategy strategy)
		{
			harvestStrategy = strategy;
		}

		public Tree()
        {
			Fruits = 5;
			Leafs = 10;
			Name = "Indochina Dragonplum Tree";
			Height = 5;
			HealthStatus = HealthStatus.Good;
		}

        public Tree(int fruits, double leafs, string name, double height, HealthStatus healthStatus)
        {
            Fruits = fruits;
            Leafs = leafs;
            Name = name;
            Height = height;
            HealthStatus = healthStatus;
        }


        //set sau 1 thang
        private static void CountTime()
        {
            int secondsPassed = 0;
            while (secondsPassed < 5)
            {
                Thread.Sleep(1000); // Đợi 1 giây
                secondsPassed++;
                Console.WriteLine($"Has passed: {secondsPassed} months");
            }
            Console.WriteLine("After a month: ");
        }

        public void Fertilizing()
        {
            CountTime();
			Fruits += 3;
			Leafs += 4;
			Height += 2;
			HealthStatus = UpdateTreeStatus();
			Console.WriteLine(GetTreeStatus());

		}

        public void AbsorbCO2()
        {
            CountTime();
			Leafs += 2;
			Height += 1;
			HealthStatus = UpdateTreeStatus();
			Console.WriteLine(GetTreeStatus());
		}

        public void Watering()
        {
            CountTime();
			Height += 2;
			if (Height >= 10)
			{
				Console.WriteLine("Tree reach maximun height");
                Height = 10;
			}
			healthStatus = UpdateTreeStatus();
			Console.WriteLine(GetTreeStatus());
		}

        public string GetTreeStatus()
        {
            return $"Tree {Name} have {Fruits} fruits, {Leafs} leafs, {Height} meters tall and have {HealthStatus} status";
        }

		public void Harvest(double amount)
		{
			IProduct product = harvestStrategy.Harvest(this, amount);
			Console.WriteLine($"Harvested: {product.GetType().Name}");
		}

        public HealthStatus UpdateTreeStatus()
        {
            HealthStatus output = HealthStatus.Good;

            if (fruits <= 2 && leafs <= 3 && height <= 1)
            {
                output = HealthStatus.Bad;
            } else if (fruits < 3)
            {
				output = HealthStatus.LackFertilize;
			} else if (leafs < 5)
            {
                output = HealthStatus.LackCo2;
            }
            else if (height < 3)
            {
                output = HealthStatus.LackWater;
            }
            return output;

		}
	}
}
