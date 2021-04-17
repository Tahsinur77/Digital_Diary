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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "") MessageBox.Show("Name field can not be empty");
            else if (usernameTextBox.Text == "") MessageBox.Show("Username field can not be empty");
            else if (passwordTextBox.Text == "") MessageBox.Show("Password field can not be empty");
            else if (confirmTextBox.Text == "") MessageBox.Show("Confirm password field can not be empty");
            else if (emailTextBox.Text == "") MessageBox.Show("Email field can not be empty");
            else if (dateTimePicker1.Text == "") MessageBox.Show("Date field can not be empty");
            else if (bloodGroupcomboBox.Text == "") MessageBox.Show("Blood Group field can not be empty");
            else if (passwordTextBox.Text != confirmTextBox.Text) MessageBox.Show("Password and Confirm Password not match");
            else if (maleButton.Checked == false && femaleButton.Checked == false) MessageBox.Show("Select gender Field");
            else
            {
                bool check = true;
                if (usernameTextBox.Text != "")
                {
                    string username = usernameTextBox.Text;

                    for (int i = 0; i < username.Length; i++)
                    {
                        if (username[i] == ' ') { check = false; break; }
                    }

                }
                if (check == false) MessageBox.Show("There is no space in Username");
                else
                {
                    
                    RegistrationServices checkingUserName = new RegistrationServices();
                    bool checking = checkingUserName.CheckingUserName(UserNameTextBox);
                    if (checking)
                    {
                        MessageBox.Show("User Name Already Taken...Try Another user name");
                    }
                    else
                    {
                        string gender = "";
                        if (maleButton.Checked == true) gender = "Male";
                        else gender = "Female";
                        RegistrationServices registrationServices = new RegistrationServices();
                        registrationServices.Add(NameTextBox, UserNameTextBox, PasswordTextBox, EmailTextBox, gender, DateOfBirth, BloodGroup);
                        MessageBox.Show("Account created sucessfully...");
                        Login login = new Login();
                        this.Hide();
                        login.Show();
                    }
                }
            }
        }

        private void termCondition_CheckedChanged(object sender, EventArgs e)
        {
            if(termCondition.Checked == true)
            {
                submitButton.Enabled = true;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
    }
}
