using Digital_Diary.Codes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Diary
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void creatNewAccountButton_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            this.Hide();
            registration.Show();
        }

        

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click_1(object sender, EventArgs e)
        {
            RegistrationServices registration = new RegistrationServices();
            int x = registration.Search(UserName, Password);
            if (x == 1)
            {
                EventHomeScreen event1 = new EventHomeScreen();
                this.Hide();
                event1.Show();
            }
            else
            {
                MessageBox.Show("Username And Password not currect.Try again");
                userNameTextBox.Text = "";
                passwordTextBox.Text = "";
            }
        }
    }
}
