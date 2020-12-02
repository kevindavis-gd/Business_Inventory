using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPswdUserControl
{
    public partial class LoginPswdUserControl : UserControl
    {
        string login;
        string password;

        public string Login
        {
            get { return login; }
        }
        public string Password
        {
            get { return password; }
        }

        public LoginPswdUserControl()
        {
            InitializeComponent();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            try
            {
                login = textBox_Login.Text;
                password = textBox_Password.Text;
                //call mthe delegate method
                OnLoginButtonClick(EventArgs.Empty);
            }
            catch (FormatException)
            {
                MessageBox.Show("Incorrect Format");
            }
        }
        //public event
        public event EventHandler LoginButtonClicked;
        //delegate method to invoke public event
        protected virtual void OnLoginButtonClick(EventArgs e)
        {
            LoginButtonClicked?.Invoke(this, e);
        }
    }
}
