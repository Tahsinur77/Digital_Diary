using Digital_Diary.Access_to_Database.Entities;
using Digital_Diary.Codes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Diary
{
    public partial class AllEvents : Form
    {
        private string userName;
        List<string> pictures = new List<string>();
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
            eventHomeScreen.LoginUserName(userName);
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

        private void viewButton_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            EventsServices eventsServices = new EventsServices();
            int x = 20;
            int y = 20;
            int maxHight = -1;
            foreach (string pic in eventsServices.AllEventPictures(ComboBoxText))
            {
                PictureBox picture = new PictureBox();
                Size size = picture.Size;
                size.Height = 150;
                size.Width = 150;
                picture.Size = size;
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                picture.Image = Image.FromFile(pic);
                picture.Location = new Point(x, y);
                x += picture.Width + 10;
                maxHight = Math.Max(picture.Height, maxHight);
                if(x > this.ClientSize.Width - 100)
                {
                    x = 20;
                    y += maxHight + 10;
                }
                this.panel1.Controls.Add(picture);
            }
            /*
             int i = 0;
             //while (true)
             //{
             string ok = pictures[i];
             //string path = System.IO.Path.Combine(ok);
             //MessageBox.Show("" + ok);
             //string filename = Path.GetFileName(ok);
             //pictureBox1 =filename;
             PictureBox pb = new PictureBox();
             Image loadedImage = Image.FromFile(ok);
             pb.Width = loadedImage.Width;
             pb.Image = loadedImage;
             //pictureBox1.Image = loadedImage;
             //i++;
             // }*/
            storyLabel.Visible = true;
            dateLabel.Visible = true;
            importanceLabel.Visible = true;
            Events events = new Events();
            EventsServices eventsServices1 = new EventsServices();
            events = eventsServices1.GetingStory(ComboBoxText);
            storyLabel.Text = events.EventStory;
            dateLabel.Text = events.EventDate;
            importanceLabel.Text = events.Importance;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
