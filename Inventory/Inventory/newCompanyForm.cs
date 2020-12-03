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
    public partial class newCompanyForm : Form
    {

        private string name;
        private string owner;
        private bool blank;


        public bool GetBlank
        {
            get { return blank; }
        }
        public string GetName
        {
            get { return name; }
            set { name = value; }
        }

        public string GetOwner
        {
            get { return owner; }
            set { owner = value; }
        }


        public newCompanyForm()
        {
            InitializeComponent();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            if(textBox_name.Text == "" || textBox_owner.Text == "")
            {
                MessageBox.Show("Fields Cannot be Blank");
                blank = true;
            }
            else
            {
                name = textBox_name.Text;
                owner = textBox_owner.Text;
            }
        }
    }
}
