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
            string format = "{0,-10}{1,-10}{2,-20}{3,-10}";
            string format2 = "{0,-10}{1,-10}{2,-20}{3,-10:C}";

            listBox_Items.Items.Clear();
            listBox_Items.Items.Add(String.Format(format, "ID", "Name", "Number Left", "Cost"));

            Item temp = new Item();
            for (int x = 0; x < company.NumberOfItems; x++)
            {
                temp = company.GetItemInfo(x);
                listBox_Items.Items.Add(String.Format(format2,temp.ID, temp.Name, temp.Count, temp.Cost));
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
