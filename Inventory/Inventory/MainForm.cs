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
    public partial class MainForm : Form
    {
        string MethodOfOpen;
        ////////////////////////////////////////////////////////////////////////////////////////// Form Main
        // Name: MainForm
        // Arguments : None
        //
        // Description :
        // 
        //////////////////////////////////////////////////////////////////////////////////////////
        public MainForm()
        {
            InitializeComponent();
        }
        ////////////////////////////////////////////////////////////////////////////////////////// Form Load
        // Name: MainForm_Load
        // Arguments : object sender, EventArgs e
        //
        // Description :
        // 
        //////////////////////////////////////////////////////////////////////////////////////////
        private void MainForm_Load(object sender, EventArgs e)
        {   //hide menu
            MainMenuStrip.Hide();
        }
        ////////////////////////////////////////////////////////////////////////////////////////// Password User Control Click
        // Name: loginPswdUserControl1_LoginButtonClicked
        // Arguments : object sender, EventArgs e
        //
        // Description :
        // when the login button is clicked it checks if the username and password is correct
        // then it hides the custom login user control and shows the menu strip
        // 
        //////////////////////////////////////////////////////////////////////////////////////////
        private void loginPswdUserControl1_LoginButtonClicked(object sender, EventArgs e)
        {
            //if username and password is admin then grant access
            if (loginPswdUserControl1.Login == "admin" && loginPswdUserControl1.Password == "admin")
            {
                MainMenuStrip.Show();
                loginPswdUserControl1.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Username Or Password", "Incorrect");
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////// Open Plain Text
        // Name: openPlainTextToolStripMenuItem_Click
        // Arguments : object sender, EventArgs e
        //
        // Description :
        // when the menu strip item is clicked it sets the string to "Plain" the calls Open()
        // 
        //////////////////////////////////////////////////////////////////////////////////////////
        private void openPlainTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MethodOfOpen = "Plain";
            Open();
        }

        ////////////////////////////////////////////////////////////////////////////////////////// Open Serialized Text
        // Name: openSerializedToolStripMenuItem_Click
        // Arguments : object sender, EventArgs e
        //
        // Description :
        // when the menu strip item is clicked it sets the string to "Plain" the calls Open()
        //
        //////////////////////////////////////////////////////////////////////////////////////////
        private void openSerializedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MethodOfOpen = "Serialized";
            Open();
        }
        ////////////////////////////////////////////////////////////////////////////////////////// Create New Business
        // Name: newToolStripMenuItem_Click
        // Arguments : object sender, EventArgs e
        //
        // Description :
        // when the menu strip item is clicked it sets the string to "Plain" the calls Open()
        // 
        //////////////////////////////////////////////////////////////////////////////////////////
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MethodOfOpen = "New";
            Open();
        }
        ////////////////////////////////////////////////////////////////////////////////////////// Open
        // Name: Open
        // Arguments :
        //
        // Description :
        // when theis called it creates a new child form object then sets
        // this form as the parent, then shows the file. It will call either import from text file,
        // import from serialized file, or NewCOmpany then fill in company information then resets
        // MethodofOpen string
        // 
        //////////////////////////////////////////////////////////////////////////////////////////
        private void Open()
        {
            InventoryView child = new InventoryView();
            //set this form as the child's parent
            child.MdiParent = this;
            //display the child
            child.Show();
            if (MethodOfOpen == "New")
                child.NewCompany();
            else if (MethodOfOpen == "Serialized")
                child.ImportFromSerializedFile();
            else if (MethodOfOpen == "Plain")
                child.ImportFromFile();
            //call the child's fillCompanyDetails method
            child.FillCompanyDetails();
            MethodOfOpen = "";
        }

        ////////////////////////////////////////////////////////////////////////////////////////// Save As Text
        // Name: saveAsTextToolStripMenuItem_Click
        // Arguments : object sender, EventArgs e
        //
        // Description :
        // when clicked this method calls the SaveText method of the active child form
        //
        //////////////////////////////////////////////////////////////////////////////////////////
        private void saveAsTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventoryView activeStore = (InventoryView)this.ActiveMdiChild;
            activeStore.SaveText();
        }
        ////////////////////////////////////////////////////////////////////////////////////////// Save Serialized Click
        // Name: saveSerializedToolStripMenuItem_Click
        // Arguments : object sender, EventArgs e
        //
        // Description :
        // when clicked this method calls the SaveTexterialized method of the active child form
        // 
        //////////////////////////////////////////////////////////////////////////////////////////
        private void saveSerializedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventoryView activeStore = (InventoryView)this.ActiveMdiChild;
            activeStore.SaveTexterialized();
        }
        ////////////////////////////////////////////////////////////////////////////////////////// Exit Program
        // Name: exitToolStripMenuItem_Click
        // Arguments : object sender, EventArgs e
        //
        // Description :
        // when clicked it exits the program
        // 
        //////////////////////////////////////////////////////////////////////////////////////////
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        ////////////////////////////////////////////////////////////////////////////////////////// Insert Item Click
        // Name: insertToolStripMenuItem_Click
        // Arguments : object sender, EventArgs e
        //
        // Description :
        // when clicked this method calls the insert method of the active child form
        // 
        //////////////////////////////////////////////////////////////////////////////////////////
        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventoryView activeStore = (InventoryView)this.ActiveMdiChild;
            activeStore.Insert();
        }
        ////////////////////////////////////////////////////////////////////////////////////////// Update Item
        // Name: updateToolStripMenuItem_Click
        // Arguments : object sender, EventArgs e
        //
        // Description :
        // when clicked this method calls the ItemUpdate method of the active child form
        // 
        //////////////////////////////////////////////////////////////////////////////////////////
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventoryView activeStore = (InventoryView)this.ActiveMdiChild;
            activeStore.ItemUpdate();
        }
        ////////////////////////////////////////////////////////////////////////////////////////// Delete Item
        // Name: deleteToolStripMenuItem_Click
        // Arguments : object sender, EventArgs e
        //
        // Description :
        // when clicked this method calls the Delete method of the active child form
        // 
        //////////////////////////////////////////////////////////////////////////////////////////
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventoryView activeStore = (InventoryView)this.ActiveMdiChild;
            activeStore.Delete();
        }
        ////////////////////////////////////////////////////////////////////////////////////////// About Info
        // Name: infoToolStripMenuItem_Click
        // Arguments : object sender, EventArgs e
        //
        // Description :
        // Shows a message box with information about the program
        // 
        //////////////////////////////////////////////////////////////////////////////////////////
        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
               " This Program keeps an inventory of the items within multiple stores, \n" +
               " how many of each item are currently in stock, and the cost of each. \n" +
               " It also allows the user to Insert, Update, Deletem and Display items",
               "About This Program");
        }
    }
}
