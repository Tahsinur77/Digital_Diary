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
            MessageBox.Show("Account created sucessfully...");
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void termCondition_CheckedChanged(object sender, EventArgs e)
        {
            if(termCondition.Checked == true)
            {
                submitButton.Enabled = true;
            }
        }
    }
}
