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
    public partial class AllEvents : Form
    {
        public AllEvents()
        {
            InitializeComponent();
        }

        private void AllEvent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            EventHomeScreen eventHomeScreen = new EventHomeScreen();
            this.Hide();
            eventHomeScreen.Show();
        }


        private void AllEvents_Load(object sender, EventArgs e)
        {

        }
    }
}
