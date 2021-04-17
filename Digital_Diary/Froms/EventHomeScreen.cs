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
    public partial class EventHomeScreen : Form
    {
        private string userName;
        public EventHomeScreen()
        {
            InitializeComponent();
        }
        public void LoginUserName(string userName)
        {
            this.userName = userName;
        }
        public string UserName
        {
            get { return this.userName; }
        }
        private void Event_Home_Screen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void creatNewEventButton_Click(object sender, EventArgs e)
        {
            EventCreation eventCreation = new EventCreation();
            this.Hide();
            eventCreation.LoginUserName2(UserName);
            eventCreation.Show();
        }

        private void savedEventButton_Click(object sender, EventArgs e)
        {
            AllEvents allevents = new AllEvents();
            this.Hide();
            allevents.Show();
        }
    }
}
