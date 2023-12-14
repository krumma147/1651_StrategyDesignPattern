using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1651
{
    enum healthStatus
    {
        Good, LackFertilize, LackWater
    }
    internal class Tree
    {
        private int fruits;
        private int leafs;
        private string name;
        private double height;
        private healthStatus healthStatus;

        protected int Fruits { get=>fruits; set=>value = fruits; }
        protected int Leafs {  get=>leafs; set=>value = leafs; }
        protected string Name { get => name; set => value = name; }
        protected double Height { get => height; set => value = height; }
        public healthStatus HealthStatus { get => healthStatus; set =>value = healthStatus; }


        public Tree()
        {
            
        }

        public Tree(int fruits, int leafs, string name, double height, healthStatus healthStatus)
        {
            Fruits = fruits;
            Leafs = leafs;
            Name = name;
            Height = height;
            HealthStatus = healthStatus;
        }

        public IHarvestStrategy Harvest() => Harvest();

        public void Grow()
        {
            // Implement growth logic
        }

        public void Fertilizing()
        {
            // bón phan logic
        }

        public void AbsorbCO2()
        {
            //logic
        }

        public void Watering()
        {
            //logic
        }

    }
}
