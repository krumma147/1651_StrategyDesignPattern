using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tree1651PJ;
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
        private int leafs;
        private string name;
        private double height;
		private HealthStatus healthStatus;

        protected int Fruits { get=>fruits; set=> fruits = value; }
        protected int Leafs {  get=>leafs; set=>leafs = value; }
        protected string Name { get => name; set =>name = value; }
        protected double Height { get => height; set => height = value; }
        public HealthStatus HealthStatus { get => healthStatus; set => healthStatus = value; }


        public Tree()
        {
			Fruits = 5;
			Leafs = 10;
			Name = "Indochina Dragonplum Tree";
			Height = 2;
			HealthStatus = HealthStatus.Good;
		}

        public Tree(int fruits, int leafs, string name, double height, HealthStatus healthStatus)
        {
            Fruits = fruits;
            Leafs = leafs;
            Name = name;
            Height = height;
            HealthStatus = healthStatus;
        }

        //private static void CountTime()
        //{
        //    int secondsPassed = 0;
        //    while (secondsPassed < 30)
        //    {
        //        Thread.Sleep(1000); // Đợi 1 giây
        //        secondsPassed++;
        //        Console.WriteLine($"Has passed: {secondsPassed} days");
        //    }
        //    Console.WriteLine("After a month: ");
        //}

        public IHarvestStrategy Harvest() => Harvest();

        public void Fertilizing()
        {
            Console.WriteLine("Added Fertilize to tree!");
            //Utility.CountTime();
            this.fruits += 3;
            this.leafs += 2;
            this.Height += 1;
        }

        public void AbsorbCO2()
        {
            //CountTime();
            this.leafs += 3;
			this.Height += 1;
		}

        public void Watering()
        {
            //CountTime();
            this.Height += 2;
		}

        public string GetTreeStatus()
        {
            return $"Tree {Name} have {Fruits} fruits, {Leafs} leafs, {Height} meters tall and have {HealthStatus} status";
        }

    }
}
