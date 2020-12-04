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

    public partial class InventoryView : Form
    {
        int previousIndex = 1;
        BusinessEntity company = new BusinessEntity();

        public InventoryView()
        {
            InitializeComponent();
        }

        ////////////////////////////////////////////////////////////////////////////////////////// Import From Text File
        // Name: ImportFromFile
        // Arguments : None
        //
        // Description :
        // this method calls the ImportFromFile method within the business entity
        // then calls LoadList()
        // 
        //////////////////////////////////////////////////////////////////////////////////////////
        public void ImportFromFile()
        {
            company.ImportFromFile();
            LoadList();
        }
        ////////////////////////////////////////////////////////////////////////////////////////// Import From Serialized File
        // Name: ImportFromSerializedFile
        // Arguments : None
        //
        // Description :
        // this method calls the ImportFromSerializedFile method within the business entity
        // then calls LoadList()
        // 
        //////////////////////////////////////////////////////////////////////////////////////////
        public void ImportFromSerializedFile()
        {
            company.ImportFromSearilizedFile();
            LoadList();
        }
        ////////////////////////////////////////////////////////////////////////////////////////// Save As Text
        // Name: SaveText
        // Arguments : None
        //
        // Description :
        // this method calls the OutputToFile method within the business entity
        // 
        //////////////////////////////////////////////////////////////////////////////////////////
        public void SaveText()
        {
            company.OutputToFile();
        }
        ////////////////////////////////////////////////////////////////////////////////////////// Save As Serialized Text
        // Name: SaveTexterialized
        // Arguments : None
        //
        // Description :
        // this method calls the  SerializedOutputToFile method within the business entity
        // 
        //////////////////////////////////////////////////////////////////////////////////////////
        public void SaveTexterialized()
        {
            company.SerializedOutputToFile();
        }

        ////////////////////////////////////////////////////////////////////////////////////////// Create New Company
        // Name: NewCompany
        // Arguments : None
        //
        // Description :
        // this method creates a new NewCompany form, displays it and processes the information from it
        // 
        //////////////////////////////////////////////////////////////////////////////////////////
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
                MessageBox.Show("Incorrect Format, Please Try again", "Error");
            }
            newComp.Dispose();
        }
        
        
        ////////////////////////////////////////////////////////////////////////////////////////// Load List
        // Name: LoadList
        // Arguments : None
        //
        // Description :
        // CLears the listbox, loads the headings, then loops through all the items in the store
        // and adds it to the listbox
        // 
        //////////////////////////////////////////////////////////////////////////////////////////
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
            for (int x = 0; x < company.NumberOfItems; x++)
            {
                temp = company.GetItemInfo(x);
                listBox_Items.Items.Add(
                   $" {temp.ID.PadRight(columnWidth)} \t" +
                   $" {temp.Name.PadRight(columnWidth)} \t" +
                   $" {temp.Count.ToString().PadRight(columnWidth)} \t" +
                   $" {"$" + temp.Cost.ToString().PadRight(columnWidth)} \t");
            }
            //prevents the heading from being automatically selected when the window opens
            listBox_Items.SelectedIndex = 1;
        }
        ////////////////////////////////////////////////////////////////////////////////////////// Fill Company Details
        // Name: FillCompanyDetails
        // Arguments : None
        //
        // Description :
        // Fills in the company details on the form
        // 
        //////////////////////////////////////////////////////////////////////////////////////////
        public void FillCompanyDetails()
        {
            label_CompanyName.Text = company.NameOfBusiness;
            this.Name = company.NameOfBusiness;
            this.Text = company.NameOfBusiness;
        }
        ////////////////////////////////////////////////////////////////////////////////////////// Prevent Heading Selection
        // Name: listBox_Items_SelectedIndexChanged
        // Arguments : object sender, EventArgs e
        //
        // Description :
        // if there is an index change, this method checks if the heading has been selected,
        // if the heading has been selected, it keeps it at your previous index
        // 
        //////////////////////////////////////////////////////////////////////////////////////////
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

        ////////////////////////////////////////////////////////////////////////////////////////// Delete
        // Name: Delete
        // Arguments : None
        //
        // Description :
        // Deletes the selected file using its ID
        //
        //////////////////////////////////////////////////////////////////////////////////////////
        public void Delete()
        {
            //remove all spaces from the text and only use the first 4 characters
            //which will be the ID #
            String ID = listBox_Items.SelectedItem.ToString().Replace(" ", "").Substring(0, 4);
            company.DeleteItem(ID);
            LoadList();
        }

        ////////////////////////////////////////////////////////////////////////////////////////// Update
        // Name: ItemUpdate
        // Arguments : None
        //
        // Description :
        // this method creates a new update form, displays it and processes the information from it.
        // it identifies the correct item using its ID
        //
        //////////////////////////////////////////////////////////////////////////////////////////
        public void ItemUpdate()
        {
            UpdateForm insert = new UpdateForm();
            try
            {
                //if there is no blank textbox
                if (insert.ShowDialog(this) == DialogResult.OK && insert.Getblank == false)
                {
                    //remove all spaces from the text and only use the first 4 characters
                    //which will be the ID #
                    string tempID = listBox_Items.SelectedItem.ToString().Replace(" ", "").Substring(0, 4);
                    company.Update(tempID, insert.GetName, insert.GetCount, insert.GetCost);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Incorrect Format, Please Try again");
            }
            insert.Dispose();
            LoadList();
        }
        ////////////////////////////////////////////////////////////////////////////////////////// Insert
        // Name: Insert
        // Arguments : None
        //
        // Description :
        // this method creates a new insert form, displays it and processes the data from that form
        // 
        //////////////////////////////////////////////////////////////////////////////////////////
        public void Insert()
        {
            Form_InsertItem insert = new Form_InsertItem();
            //if there is no blank textbox
            if (insert.ShowDialog(this) == DialogResult.OK && insert.GetBlank == false)
            {
                try
                {
                    company.AddNewItem(insert.GetID, insert.GetName, insert.GetCount, insert.GetCost);
                }
                catch (FormatException e)
                {
                    MessageBox.Show("Incorrect Format, Please Try again", "Error");
                }
                insert.Dispose();
                LoadList();
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////// Sorted
        // Name: checkBox_Sort_CheckedChanged
        // Arguments : None
        //
        // Description :
        // sort items in the listbox
        // 
        //////////////////////////////////////////////////////////////////////////////////////////
        private void checkBox_Sort_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Sort.Checked)
                listBox_Items.Sorted = true;
            else
                listBox_Items.Sorted = false;
        }
    }

}
