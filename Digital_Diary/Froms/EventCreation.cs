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
    public partial class EventCreation : Form
    {
        List<string> pictures = new List<string>();
        private string userName;
        public EventCreation()
        {
            InitializeComponent();
        }
        public void LoginUserName2(string userName)
        {
            this.userName = userName;
        }
        public string UserName2
        {
            get { return this.userName; }
        }


        private void EventCreation_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            EventsServices eventsServices = new EventsServices();
            bool check = eventsServices.CheckingEventName(EventName);

            if (check)
            {
                MessageBox.Show("Already Used this Event Name..");
            }
            else
            {
                string importance = "";
                if (HighRadioButton) importance = "High";
                else if (ModerateRadioButton) importance = "Moderate";
                else importance = "Low";

                //EventsServices eventsServices = new EventsServices();
                eventsServices.AddEvents(EventName, EventStory, EventDate, importance, UserName2);
                foreach (string pic in pictures)
                {
                    eventsServices.AddPictures(pic, EventName);
                }
                MessageBox.Show("Creat new events Successfully");
                EventHomeScreen eventHomeScreen = new EventHomeScreen();
                this.Hide();
                eventHomeScreen.Show();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            EventHomeScreen eventHome = new EventHomeScreen();
            this.Hide();
            eventHome.Show();
        }

        private void browserButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            openFileDialog.Multiselect = true;
            while(openFileDialog.ShowDialog() == DialogResult.OK){
               foreach(string a in openFileDialog.FileNames)
                {
                    pictures.Add(a);
                }
                bool check = false;
                string message = "Do you want to Add more picture?";
                string title = "choise";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    continue;
                }
                else
                {
                    check = true;
                }

                if (check) break;
            }
        }
    }
}
