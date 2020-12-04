using System;
using System.Windows.Forms;

namespace Inventory
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {   //hide menu
            MainMenuStrip.Hide();
        }

        private void loginPswdUserControl1_LoginButtonClicked(object sender, EventArgs e)
        {
            if (loginPswdUserControl1.Login == "admin" && loginPswdUserControl1.Password == "admin")
            {
                MainMenuStrip.Show();
                loginPswdUserControl1.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Username Or Password");
            }
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventoryView activeStore = (InventoryView)this.ActiveMdiChild;
            activeStore.Insert();
        }

        private void saveAsTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventoryView activeStore = (InventoryView)this.ActiveMdiChild;
            activeStore.SaveText();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventoryView activeStore = (InventoryView)this.ActiveMdiChild;
            activeStore.Delete();
        }

        private void openPlainTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventoryView child = new InventoryView();
            child.MdiParent = this;
            child.Show();
            child.ImportFromFile();
            child.FillCompanyDetails();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventoryView child = new InventoryView();
            child.MdiParent = this;
            child.Show();
            child.NewCompany();
            child.FillCompanyDetails();
        }
        /*
                private void NewChild()
                {
                    InventoryView child = new InventoryView();
                    child.MdiParent = this;
                    child.Show();
                    child.ImportFromFile();
                    child.FillCompanyDetails();


                }
        */

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventoryView activeStore = (InventoryView)this.ActiveMdiChild;
            activeStore.ItemUpdate();
        }

        private void saveSerializedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventoryView activeStore = (InventoryView)this.ActiveMdiChild;
            activeStore.SaveTexterialized();
        }

        private void openSerializedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventoryView child = new InventoryView();
            child.MdiParent = this;
            child.Show();
            child.ImportFromSerializedFile();
            child.FillCompanyDetails();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

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
