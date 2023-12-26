using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeClassLibrary.Products;
using TreeClassLibrary.Strategy;

namespace TreeClassLibrary
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
        private double weight;
        private HealthStatus healthStatus;


        public int Fruits { get => fruits; set => fruits = value; }
        public double Leafs { get => leafs; set => leafs = value; }
        public string Name { get => name; private set => name = value; }
        public double Weight { get => weight; set => weight = value; }
        public HealthStatus HealthStatus { get => healthStatus; set => healthStatus = value; }

        public Tree()
        {
            Fruits = 5;
            Leafs = 10;
            Name = "Indochina Dragonplum Tree";
            Weight = 5;
            HealthStatus = HealthStatus.Good;
        }

        public Tree(int fruits, double leafs, string name, double height, HealthStatus healthStatus)
        {
            Fruits = fruits;
            Leafs = leafs;
            Name = name;
            Weight = height;
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
            Weight += 2;
			HealthStatus = UpdateTreeStatus();
            Console.WriteLine(GetTreeStatus());

        }

        public void AbsorbCO2()
        {
            CountTime();
            Leafs += 5;
            Weight += 2;
			HealthStatus = UpdateTreeStatus();
            Console.WriteLine(GetTreeStatus());
        }

        public void Watering()
        {
            CountTime();
            Weight += 5;
            if (Weight >= 30)
            {
                Console.WriteLine("Tree reach maximun weight of wood");
                Weight = 30;
            }
            healthStatus = UpdateTreeStatus();
            Console.WriteLine(GetTreeStatus());
        }

        public string GetTreeStatus()
        {
            return $"Tree {Name} have {Fruits} fruits, {Leafs} leafs, {Weight} kilograms of wood and is in the status {HealthStatus}";
        }

        public HealthStatus UpdateTreeStatus()
        {
            return (Fruits <= 2 && Leafs <= 3 && weight <= 1) ? HealthStatus.Bad
                : (Fruits < 3) ? HealthStatus.LackFertilize
                : (Leafs < 5) ? HealthStatus.LackCo2
                : (weight < 3) ? HealthStatus.LackWater
                : HealthStatus.Good;
        }
    }
}
