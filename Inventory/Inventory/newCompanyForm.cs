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
    public partial class newCompanyForm : Form
    {
        private string name;
        private string owner;
        private bool blank;

        public bool GetBlank
        {
            get { return blank; }
        }
        public string GetName
        {
            get { return name; }
            set { name = value; }
        }
        public string GetOwner
        {
            get { return owner; }
            set { owner = value; }
        }
        public newCompanyForm()
        {
            InitializeComponent();
        }
        ////////////////////////////////////////////////////////////////////////////////////////// Form Main
        // Name: button_ok_Click
        // Arguments : object sender, EventArgs e
        //
        // Description :
        // when the button is clicked it stores the values of the textbox into variables,
        // if texboxes are empty it displays a messagebox
        //
        //////////////////////////////////////////////////////////////////////////////////////////
        private void button_ok_Click(object sender, EventArgs e)
        {
            if(textBox_name.Text == "" || textBox_owner.Text == "")
            {
                MessageBox.Show("Fields Cannot be Blank", "Error");
                blank = true;
            }
            else
            {
                name = textBox_name.Text;
                owner = textBox_owner.Text;
            }
        }
    }
}
