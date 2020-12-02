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
    public partial class InventoryView : Form
    {
        public InventoryView()
        {
            InitializeComponent();
        }

        private void InventoryView_Load(object sender, EventArgs e)
        {
            string format = "{0,-20}{1,20}{2,20}";
            string format2 = "{0,-20}{1,20}{2,20:C}";
            BusinessEntity hardware = new BusinessEntity();
            hardware.InputFromFile();

            label_CompanyName.Text = hardware.NameOfBusiness;
            listBox_Items.Items.Add(String.Format(format,"Name","Number Left","Cost"));

            Item temp = new Item();
            for (int x = 0; x < hardware.NumberOfItems; x++)
            {
                temp = hardware.GetItemInfo(x);
                listBox_Items.Items.Add(String.Format(format2, temp.Name, temp.Count, temp.Cost));
            }

            
        }
    }
}
