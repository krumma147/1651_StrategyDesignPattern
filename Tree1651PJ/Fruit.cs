﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1651
{
    internal class Fruit : IProduct
    {
        private string taste;
        private int amount;
        public string Taste { get => taste; set => value = taste; }
        public int Amount { get => amount; set=>value = amount; }

        public Fruit()
        {
            
        }
        public void Use()
        {
            //logic
        }

        public void MakeGift()
        {
            // login quà
        }

        public void Consume()
        {
            //logic tieu thu
        }

    }
}