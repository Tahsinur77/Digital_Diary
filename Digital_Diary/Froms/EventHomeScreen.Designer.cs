
namespace Digital_Diary
{
    partial class EventHomeScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.creatNewEventButton = new System.Windows.Forms.Button();
            this.savedEventButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.lastModificationLabel = new System.Windows.Forms.Label();
            this.lastLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // creatNewEventButton
            // 
            this.creatNewEventButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.creatNewEventButton.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creatNewEventButton.Location = new System.Drawing.Point(158, 138);
            this.creatNewEventButton.Name = "creatNewEventButton";
            this.creatNewEventButton.Size = new System.Drawing.Size(140, 133);
            this.creatNewEventButton.TabIndex = 0;
            this.creatNewEventButton.Text = "Creant New Event";
            this.creatNewEventButton.UseVisualStyleBackColor = false;
            this.creatNewEventButton.Click += new System.EventHandler(this.creatNewEventButton_Click);
            // 
            // savedEventButton
            // 
            this.savedEventButton.BackColor = System.Drawing.Color.Fuchsia;
            this.savedEventButton.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savedEventButton.Location = new System.Drawing.Point(341, 138);
            this.savedEventButton.Name = "savedEventButton";
            this.savedEventButton.Size = new System.Drawing.Size(140, 133);
            this.savedEventButton.TabIndex = 1;
            this.savedEventButton.Text = "Saved Event";
            this.savedEventButton.UseVisualStyleBackColor = false;
            this.savedEventButton.Click += new System.EventHandler(this.savedEventButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.logOutButton.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.Location = new System.Drawing.Point(662, 427);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(88, 36);
            this.logOutButton.TabIndex = 2;
            this.logOutButton.Text = "Logout";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // lastModificationLabel
            // 
            this.lastModificationLabel.AutoSize = true;
            this.lastModificationLabel.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastModificationLabel.Location = new System.Drawing.Point(24, 63);
            this.lastModificationLabel.Name = "lastModificationLabel";
            this.lastModificationLabel.Size = new System.Drawing.Size(130, 23);
            this.lastModificationLabel.TabIndex = 3;
            this.lastModificationLabel.Text = "Last Modification ";
            // 
            // lastLabel
            // 
            this.lastLabel.AutoSize = true;
            this.lastLabel.Location = new System.Drawing.Point(82, 86);
            this.lastLabel.Name = "lastLabel";
            this.lastLabel.Size = new System.Drawing.Size(177, 34);
            this.lastLabel.TabIndex = 4;
            this.lastLabel.Text = "lastmodification";
            this.lastLabel.Click += new System.EventHandler(this.lastLabel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.creatNewEventButton);
            this.groupBox1.Controls.Add(this.lastLabel);
            this.groupBox1.Controls.Add(this.savedEventButton);
            this.groupBox1.Controls.Add(this.lastModificationLabel);
            this.groupBox1.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(67, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 338);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Event";
            // 
            // EventHomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(780, 497);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.logOutButton);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Name = "EventHomeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event_Home_Screen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Event_Home_Screen_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button creatNewEventButton;
        private System.Windows.Forms.Button savedEventButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Label lastModificationLabel;
        public System.Windows.Forms.Label lastLabel;
        private System.Windows.Forms.GroupBox groupBox1;

        public string LastLabel { set { this.lastLabel.Text = value; } }


    }
}