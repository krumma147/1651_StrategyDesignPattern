using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public IHarvestStrategy Harvest() => Harvest();

        public void Fertilizing()
        {
            Console.WriteLine("Added Fertilize to tree!");
            this.fruits += 3;
            this.leafs += 2;
            this.Height += 1;
        }

        public void AbsorbCO2()
        {
			this.leafs += 3;
			this.Height += 1;
		}

        public void Watering()
        {
			this.Height += 2;
		}

        public string GetTreeStatus()
        {
            return $"Tree {Name} have {Fruits} fruits, {Leafs} leafs, {Height} meters tall and have status of {HealthStatus}";
        }

    }
}
