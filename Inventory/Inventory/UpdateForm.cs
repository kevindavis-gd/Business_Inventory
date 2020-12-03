using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void button_OK_Click(object sender, EventArgs e)
        {
            if(textBox_ItemName.Text == "" || textBox_ItemCount.Text== "" || textBox_ItemCost.Text =="")
            {
                MessageBox.Show("Field Cannot be Left Blank");
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
