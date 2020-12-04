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
        ////////////////////////////////////////////////////////////////////////////////////////// Login Button Click
        // Name: button_Login_Click
        // Arguments : object sender, EventArgs e
        //
        // Description :
        // when the button is clicked it saved the textbox data to vatiables 
        // then calls  OnLoginButtonClick
        //////////////////////////////////////////////////////////////////////////////////////////
        private void button_Login_Click(object sender, EventArgs e)
        {
            try
            {
                login = textBox_Login.Text;
                password = textBox_Password.Text;
                //call the delegate method
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
