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

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventoryView child = new InventoryView();
            child.MdiParent = this;
            child.Show();
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventoryView activeStore = (InventoryView)this.ActiveMdiChild;
            //activeStore.

        }
    }
}
