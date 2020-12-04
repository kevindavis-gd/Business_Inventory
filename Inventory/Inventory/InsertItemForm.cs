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
using System.Windows.Forms;

namespace Inventory
{
    public partial class Form_InsertItem : Form
    {
        private string name;
        private int count;
        private double cost;
        private string id;
        private bool blank;

        public bool GetBlank
        {
            get { return blank; }
        }
        public string GetID
        {
            get { return id; }
        }
        public string GetName
        {
            get { return name; }
        }
        public int GetCount
        {
            get { return count; }
        }
        public double GetCost
        {
            get { return cost; }
        }

        public Form_InsertItem()
        {
            InitializeComponent();
        }
        ////////////////////////////////////////////////////////////////////////////////////////// OK Button Click
        // Name: button_ok_Click
        // Arguments : object sender, EventArgs e
        //
        // Description :
        // this method takes all the data from the texbox abd places it into variables
        // it also checks for empty textboxes and shows a messagebox.
        //
        //////////////////////////////////////////////////////////////////////////////////////////
        private void button_ok_Click(object sender, EventArgs e)
        {
            if (textBox_ItemID.Text == "" || textBox_ItemName.Text == "" || textBox_ItemCount.Text == "" || textBox_ItemCost.Text == "")
            {
                // throw new System.ArgumentException("Fields Cannot Be Empty");
                MessageBox.Show("Fields Cannot be Blank","Error");
                blank = true;
            }
            else
            {
                if (textBox_ItemID.Text.Length != 4)
                {
                    MessageBox.Show("ID Should be 4 Characters", "Error");
                    blank = true;
                }
                else
                {
                    id = textBox_ItemID.Text.Substring(0, 4);
                    name = textBox_ItemName.Text;
                    count = int.Parse(textBox_ItemCount.Text);
                    cost = double.Parse(textBox_ItemCost.Text);
                }
            }
        }
    }
}
