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
    public partial class AllEvents : Form
    {
        private string userName;
        public AllEvents()
        {
            InitializeComponent();
            
        }
        public void LoginUser(string userName)
        {
            this.userName = userName;
        }
        public string UserName
        {
            get { return this.userName; }
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void showEventListButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(userName);
            EventsServices events = new EventsServices();
            allEventsComboBox.DataSource = events.AllEventsName(userName);

        }
    }
}
