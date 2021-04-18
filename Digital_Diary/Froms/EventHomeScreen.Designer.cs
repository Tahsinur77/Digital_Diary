
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
            this.SuspendLayout();
            // 
            // creatNewEventButton
            // 
            this.creatNewEventButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creatNewEventButton.Location = new System.Drawing.Point(83, 138);
            this.creatNewEventButton.Name = "creatNewEventButton";
            this.creatNewEventButton.Size = new System.Drawing.Size(140, 133);
            this.creatNewEventButton.TabIndex = 0;
            this.creatNewEventButton.Text = "Creant New Event";
            this.creatNewEventButton.UseVisualStyleBackColor = true;
            this.creatNewEventButton.Click += new System.EventHandler(this.creatNewEventButton_Click);
            // 
            // savedEventButton
            // 
            this.savedEventButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savedEventButton.Location = new System.Drawing.Point(272, 138);
            this.savedEventButton.Name = "savedEventButton";
            this.savedEventButton.Size = new System.Drawing.Size(140, 133);
            this.savedEventButton.TabIndex = 1;
            this.savedEventButton.Text = "Saved Event";
            this.savedEventButton.UseVisualStyleBackColor = true;
            this.savedEventButton.Click += new System.EventHandler(this.savedEventButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(333, 404);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(88, 36);
            this.logOutButton.TabIndex = 2;
            this.logOutButton.Text = "Logout";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // lastModificationLabel
            // 
            this.lastModificationLabel.AutoSize = true;
            this.lastModificationLabel.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastModificationLabel.Location = new System.Drawing.Point(79, 77);
            this.lastModificationLabel.Name = "lastModificationLabel";
            this.lastModificationLabel.Size = new System.Drawing.Size(130, 23);
            this.lastModificationLabel.TabIndex = 3;
            this.lastModificationLabel.Text = "Last Modification ";
            // 
            // lastLabel
            // 
            this.lastLabel.AutoSize = true;
            this.lastLabel.Location = new System.Drawing.Point(226, 77);
            this.lastLabel.Name = "lastLabel";
            this.lastLabel.Size = new System.Drawing.Size(105, 17);
            this.lastLabel.TabIndex = 4;
            this.lastLabel.Text = "lastmodification";
            this.lastLabel.Visible = false;
            // 
            // EventHomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 469);
            this.Controls.Add(this.lastLabel);
            this.Controls.Add(this.lastModificationLabel);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.savedEventButton);
            this.Controls.Add(this.creatNewEventButton);
            this.Name = "EventHomeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event_Home_Screen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Event_Home_Screen_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button creatNewEventButton;
        private System.Windows.Forms.Button savedEventButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Label lastModificationLabel;
        public System.Windows.Forms.Label lastLabel;


    }
}