
namespace Digital_Diary
{
    partial class AllEvents
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
            this.backButton = new System.Windows.Forms.Button();
            this.allEventsComboBox = new System.Windows.Forms.ComboBox();
            this.showEventListButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(454, 465);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(84, 29);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // allEventsComboBox
            // 
            this.allEventsComboBox.FormattingEnabled = true;
            this.allEventsComboBox.Location = new System.Drawing.Point(34, 88);
            this.allEventsComboBox.Name = "allEventsComboBox";
            this.allEventsComboBox.Size = new System.Drawing.Size(168, 24);
            this.allEventsComboBox.TabIndex = 1;
            this.allEventsComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // showEventListButton
            // 
            this.showEventListButton.Location = new System.Drawing.Point(34, 35);
            this.showEventListButton.Name = "showEventListButton";
            this.showEventListButton.Size = new System.Drawing.Size(115, 35);
            this.showEventListButton.TabIndex = 2;
            this.showEventListButton.Text = "Show Event List";
            this.showEventListButton.UseVisualStyleBackColor = true;
            this.showEventListButton.Click += new System.EventHandler(this.showEventListButton_Click);
            // 
            // AllEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 519);
            this.Controls.Add(this.showEventListButton);
            this.Controls.Add(this.allEventsComboBox);
            this.Controls.Add(this.backButton);
            this.Name = "AllEvents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AllEvents";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AllEvent_FormClosing);
            this.Load += new System.EventHandler(this.AllEvents_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ComboBox allEventsComboBox;
        private System.Windows.Forms.Button showEventListButton;
    }
}