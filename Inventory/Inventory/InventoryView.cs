﻿using System;
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
        BusinessEntity hardware = new BusinessEntity();

        public InventoryView()
        {
            InitializeComponent();
        }

        private void InventoryView_Load(object sender, EventArgs e)
        {
            hardware.ImportFromFile();
            label_CompanyName.Text = hardware.NameOfBusiness;
            LoadList();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hardware.OutputToFile();
        }

        private void InsertItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_InsertItem insert = new Form_InsertItem();
            try
            {
                
                if (insert.ShowDialog(this) == DialogResult.OK)
                {
                    hardware.AddNewItem(insert.GetID, insert.GetName, insert.GetCount, insert.GetCost);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Incorrect Format, Please Try again");
            }
            insert.Dispose();
            LoadList();
        }

        private void LoadList()
        {
            string format = "{0,-10}{1,-10}{2,-20}{3,-10}";
            string format2 = "{0,-10}{1,-10}{2,-20}{3,-10:C}";

            listBox_Items.Items.Clear();
            listBox_Items.Items.Add(String.Format(format, "ID", "Name", "Number Left", "Cost"));

            Item temp = new Item();
            for (int x = 0; x < hardware.NumberOfItems; x++)
            {
                temp = hardware.GetItemInfo(x);
                listBox_Items.Items.Add(String.Format(format2,temp.ID, temp.Name, temp.Count, temp.Cost));
            }
        }
    }
}
