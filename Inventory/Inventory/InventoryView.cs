using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    
    public partial class InventoryView : Form
    {
        int previousIndex = 1;

        BusinessEntity company = new BusinessEntity();

        public InventoryView()
        {
            InitializeComponent();
        }
        private void InventoryView_Load(object sender, EventArgs e)
        {
            //company.ImportFromFile();
            
            //LoadList();
        }
        public void ImportFromFile()
        {
            company.ImportFromFile();
            LoadList();
        }
        public void ImportFromSerializedFile()
        {
            company.ImportFromSearilizedFile();
            LoadList();
        }
        public void FillCompanyDetails()
        {
            label_CompanyName.Text = company.NameOfBusiness;
            this.Name = company.NameOfBusiness;
            this.Text = company.NameOfBusiness;
        }
        public void NewCompany()
        {
            

            newCompanyForm newComp = new newCompanyForm();
            try
            {
                if (newComp.ShowDialog(this) == DialogResult.OK && newComp.GetBlank == false)
                {
                    company.NameOfBusiness = newComp.GetName;
                    company.NameOfOwner = newComp.GetOwner;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Incorrect Format, Please Try again");
            }
            newComp.Dispose();
        }
        public void SaveText()
        {
            company.OutputToFile();
        }
        public void SaveTexterialized()
        {
            company.SerializedOutputToFile();
        }
        public void Insert()
        {
            Form_InsertItem insert = new Form_InsertItem();
            try
            {
                if (insert.ShowDialog(this) == DialogResult.OK)
                {
                    company.AddNewItem(insert.GetID, insert.GetName, insert.GetCount, insert.GetCost);
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

            listBox_Items.Items.Clear();
            int columnWidth = 12;
            int headingWidth = 15;

            listBox_Items.Items.Add(
               $" {" ID".PadRight(headingWidth)} \t" +
               $" {"Name".PadRight(headingWidth)} \t" +
               $" {"Count".PadRight(headingWidth)} \t" +
               $" {"Cost".PadRight(headingWidth)} \t");

            Item temp = new Item();
            for (int x = 0; x < company.NumberOfItems - 1; x++)
            {
                temp = company.GetItemInfo(x);
                listBox_Items.Items.Add(
                   $" {temp.ID.PadRight(columnWidth)} \t" +
                   $" {temp.Name.PadRight(columnWidth)} \t" +
                   $" {temp.Count.ToString().PadRight(columnWidth)} \t" +
                   $" {"$"+ temp.Cost.ToString().PadRight(columnWidth)} \t");
            }
        }

        private void listBox_Items_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBox_Items.SelectedIndex == 0)
            {
                listBox_Items.SelectedIndex = previousIndex;
            }
            else
            {
                previousIndex = listBox_Items.SelectedIndex;
            }
        }


        public void Delete()
        {
            String str = listBox_Items.SelectedItem.ToString().Substring(0, 4);
            company.DeleteItem(str);
            LoadList();
        }

        public void ItemUpdate()
        {
            UpdateForm insert = new UpdateForm();
            try
            {
                if (insert.ShowDialog(this) == DialogResult.OK && insert.Getblank == false)
                {
                    company.Update(listBox_Items.SelectedItem.ToString().Substring(0, 4), insert.GetName, insert.GetCount, insert.GetCost);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Incorrect Format, Please Try again");
            }
            insert.Dispose();
            LoadList();
        }

       
    }

}
