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
        string updatePicture = "";
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
            User user1 = new User();
            RegistrationServices checkingUserName = new RegistrationServices();
            user1 = checkingUserName.CheckingUserName(userName);
            
            EventHomeScreen eventHomeScreen = new EventHomeScreen();
            this.Hide();
            eventHomeScreen.LoginUserName(userName);
            eventHomeScreen.LastModi(user1.LastModification);
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
            
            EventsServices events = new EventsServices();
            if (events.AllEventsName(userName).Count > 0)
            {
                EventsServices events1 = new EventsServices();
                allEventsComboBox.DataSource = events1.AllEventsName(userName);
                //MessageBox.Show(""+events.AllEventsName(userName).Count);
            }
            else
            {
                MessageBox.Show("There is no Event....");
            }

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

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "Are you sure to Delete the Event?";
            string title = "Sure to Delete!!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult ans = MessageBox.Show(message, title, buttons);
            if (ans == DialogResult.Yes)
            {
                EventsServices eventsServices = new EventsServices();
                int result = eventsServices.DeletingEvent(ComboBoxText);
                if (result > 0)
                {
                    panel1.Controls.Clear();
                    storyLabel.Visible = false;
                    dateLabel.Visible = false;
                    importanceLabel.Visible = false;
                    MessageBox.Show("Event Delete Sucessfully...");
                    EventHomeScreen eventHomeScreen = new EventHomeScreen();
                    eventHomeScreen.lastLabel.Text = DateTime.Now.ToString();
                    eventHomeScreen.lastLabel.Visible = true;

                    User user = new User();
                    user.UserName = this.userName;
                    user.LastModification = DateTime.Now.ToString();
                    EventsServices eventsServices1 = new EventsServices();
                    eventsServices1.UpdateTime(user);

                    User user1 = new User();
                    RegistrationServices checkingUserName = new RegistrationServices();
                    user1 = checkingUserName.CheckingUserName(userName);
                    eventHomeScreen.LastModi(user1.LastModification);


                }
                else
                {
                    MessageBox.Show("Error...");
                }
                
            }
            else
            {
                //this.Close();
                // Do something  
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files(*.jpg; *.jpeg; *.png; .bmp)|.jpg; *.jpeg; *.png; *.bmp";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                updatePicture = openFile.FileName; 
            }

            
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            EventsServices eventsServices = new EventsServices();
            foreach (string pic in eventsServices.AllEventPictures(ComboBoxText))
            {
                pictures.Add(pic);
            }
            int x = Convert.ToInt32(cngTextBox.Text);
            string previousPicture = pictures[x - 1];
            EventsServices eventsServices1 = new EventsServices();
            int ans = eventsServices1.UpdatePicture(updatePicture, previousPicture);

            if (ans > 0)
            {
                panel1.Controls.Clear();
                storyLabel.Visible = false;
                dateLabel.Visible = false;
                importanceLabel.Visible = false;
                MessageBox.Show("Change Sucessfully...");

            }
            else
            {
                MessageBox.Show("Error....");
            }
        }
    }
}
