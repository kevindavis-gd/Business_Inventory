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
    public partial class UpdateForm : Form
    {
        private string name;
        private int count;
        private double cost;
        private bool blank;

        public bool Getblank
        {
            get { return blank; }
        }
        public string GetName
        {
            get { return name; }
            set { name = value; }
        }

        public int GetCount
        {
            get { return count; }
            set { count = value; }
        }

        public double GetCost
        {
            get { return cost; }
            set { cost = value; }
        }

        public UpdateForm()
        {
            InitializeComponent();
        }
        ////////////////////////////////////////////////////////////////////////////////////////// Form Main
        // Name: Form_Main
        // Arguments : None
        //
        // Description :
        // when the button is clicked it takes the information from the testbox and places it 
        // into a variable. if any field is empty it displays a messagebox.
        // 
        //////////////////////////////////////////////////////////////////////////////////////////
        private void button_OK_Click(object sender, EventArgs e)
        {
            if(textBox_ItemName.Text == "" || textBox_ItemCount.Text== "" || textBox_ItemCost.Text =="")
            {
                MessageBox.Show("Field Cannot be Left Blank", "Error");
                blank = true;
            }
            else
            {
                name = textBox_ItemName.Text;
                count = int.Parse(textBox_ItemCount.Text);
                cost = double.Parse(textBox_ItemCost.Text);
            }
        }
    }
}
