

//using TreeManagerConsoleAp;

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
        private const int MATURE_TREE_HEIGHT = 10;
        private const string MATURE_TREE = "This tree is full-grown";
        private int _height;

        public int Fruits { get; set; }
        public int Leafs { get; set; }
        public int Weight { get; set; }

        public string Name { get; }

        private bool IsMature => _height >= MATURE_TREE_HEIGHT;

        public HealthStatus HealthStatus { get; set; }
        
        public Tree(string name = "Indochina Dragon-plum Tree")
        {
            _height = 0;
            Name = name;
            Fruits = 0;
            Leafs = 10;
            Weight = 1;
            HealthStatus = HealthStatus.Good;
        }

        // public Tree(int fruits, int leafs, string name, double height, HealthStatus healthStatus,
        //     IHarvestStrategy harvestStrategy)
        // {
        //     
        //     _name = name;
        //     Fruits = fruits;
        //     Leafs = leafs;
        //     Height = height;
        //     HealthStatus = healthStatus;
        //     _harvestStrategy = harvestStrategy;
        // }


        //set sau 1 thang
        private static void CountTime()
        {
            int secondsPassed = 0;
            while (secondsPassed < 5)
            {
                Thread.Sleep(1000); 
                secondsPassed++;
                Console.WriteLine($"Has passed: {secondsPassed} months");
            }

            Console.WriteLine("After a month: ");
        }

        public string Fertilizing()
        {
            // CountTime();
            if (!IsMature)
            {
                _height++;
                Fruits += 3;
                Leafs += 4;
                Weight += 2;
                HealthStatus = GetTreeHealthStatus();
                return GetTreeStatus();
            }

            return MATURE_TREE;
        }

        public void AbsorbCO2()
        {
            _height++;
            Leafs += 2;
            Weight += 1;
            HealthStatus = GetTreeHealthStatus();
            Console.WriteLine(GetTreeStatus());
        }

        public void Watering()
        {
            CountTime();
            Weight += 2;
            if (Weight >= 10)
            {
                Console.WriteLine("Tree reached maximum height");
                Weight = 10;
            }

            HealthStatus = GetTreeHealthStatus();
            Console.WriteLine(GetTreeStatus());
        }

        public string GetTreeStatus()
        {
            return $"Tree {Name} have {Fruits} fruits, {Leafs} leafs, {Weight} meters tall and is in the status {HealthStatus}";
        }

       

        public HealthStatus GetTreeHealthStatus()
        {
            return (Fruits <= 2 && Leafs <= 3 && Weight <= 1) ? HealthStatus.Bad
                : (Fruits < 3) ? HealthStatus.LackFertilize
                : (Leafs < 5) ? HealthStatus.LackCo2
                : (Weight < 3) ? HealthStatus.LackWater
                : HealthStatus.Good;
        }
    }
}