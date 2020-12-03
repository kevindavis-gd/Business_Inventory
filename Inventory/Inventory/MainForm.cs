using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
