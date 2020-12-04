////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Name: Kevin Davis 
// Class : CMPS4143
// Assignment: Program 7
// Date: 12/04/2020
//
// Description :
// This Program keeps an inventory of the items within multiple stores,
// how many of each item are currently in stock, and the cost of each. 
// It also allows the user to Insert, Update, Deletem and Display items.
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
namespace Inventory
{
    [Serializable]
    class Item
    {
        private double cost;
        private int count;
        private string name;
        private string id;

        public string ID
        {
            get { return id; }
            set { id = value; }
        }
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
        ////////////////////////////////////////////////////////////////////////////////////////// Default Constructor
        // Name: Item
        // Arguments :
        //
        // Description :
        // 
        //////////////////////////////////////////////////////////////////////////////////////////
        public Item()
        {
            id = "";
            name = "";
            count = 0;
            cost = 0;
        }
        ////////////////////////////////////////////////////////////////////////////////////////// Parameterized Constructor
        // Name: Item
        // Arguments :
        //
        // Description :
        // 
        //////////////////////////////////////////////////////////////////////////////////////////
        public Item(string i,string nam, int cou, double cos)
        {
            id = i;
            name = nam;
            count = cou;
            cost = cos;
        }

        ////////////////////////////////////////////////////////////////////////////////////////// Copy
        // Name: Copy
        // Arguments :
        //
        // Description :
        // Copy itself to a new Item Object, then returns that object
        // 
        //////////////////////////////////////////////////////////////////////////////////////////
        public Item Copy ()
        {
            Item copy = new Item();
            copy.ID = ID;
            copy.Name = Name;
            copy.Count = Count;
            copy.Cost = Cost;
            return copy;
        }
    }
}
