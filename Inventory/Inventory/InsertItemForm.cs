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
    public partial class Form_InsertItem : Form
    {
        private string name;
        private int count;
        private double cost;

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

        public Form_InsertItem()
        {
            InitializeComponent();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
                name = textBox_ItemName.Text;
                count = int.Parse(textBox_ItemCount.Text);
                cost = double.Parse(textBox_ItemCost.Text);
        }
    }
}
