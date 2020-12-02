﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class Item
    {
        private double cost;
        private int count;
        private string name;

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        public Item()
        {
            name = "";
            count = 0;
            cost = 0;
        }
        public Item(string nam, int cou, double cos)
        {
            name = nam;
            count = cou;
            cost = cos;
            
        }

        public Item Copy ()
        {
            Item copy = new Item();
            copy.Name = Name;
            copy.Count = Count;
            copy.Cost = Cost;

            return copy;
 
        }
    }
}