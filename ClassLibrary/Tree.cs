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
        Bad = 4
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
			Height = 2;
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
            while (secondsPassed < 15)
            {
                Thread.Sleep(1000); // Đợi 1 giây
                secondsPassed++;
                Console.WriteLine($"Has passed: {secondsPassed} days");
            }
            Console.WriteLine("After a month: ");
        }

        public void Fertilizing()
        {
            CountTime();
            this.fruits += 3;
            this.leafs += 2;
            this.Height += 1;
            if( this.healthStatus == HealthStatus.LackFertilize)
            {
                this.healthStatus = HealthStatus.Good;
            }
            Console.WriteLine(GetTreeStatus());

		}

        public void AbsorbCO2()
        {
            CountTime();
            this.leafs += 3;
			this.Height += 1;
			Console.WriteLine(GetTreeStatus());
		}

        public void Watering()
        {
            CountTime();
            this.Height += 2;
			if (this.healthStatus == HealthStatus.LackWater)
			{
				this.healthStatus = HealthStatus.Good;
			}
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

	}
}
