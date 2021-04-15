
namespace Digital_Diary
{
    partial class EventCreation
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
            this.eventGroupBox = new System.Windows.Forms.GroupBox();
            this.eventLabel = new System.Windows.Forms.Label();
            this.eventNameTextBox = new System.Windows.Forms.TextBox();
            this.storyTextBox = new System.Windows.Forms.TextBox();
            this.storyLabel = new System.Windows.Forms.Label();
            this.browserButton = new System.Windows.Forms.Button();
            this.selectPicLabel = new System.Windows.Forms.Label();
            this.selectDateLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.importanceGroupBox = new System.Windows.Forms.GroupBox();
            this.highRadioButton = new System.Windows.Forms.RadioButton();
            this.moderateRadioButton = new System.Windows.Forms.RadioButton();
            this.lowRadioButton = new System.Windows.Forms.RadioButton();
            this.addButton = new System.Windows.Forms.Button();
            this.eventGroupBox.SuspendLayout();
            this.importanceGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // eventGroupBox
            // 
            this.eventGroupBox.Controls.Add(this.addButton);
            this.eventGroupBox.Controls.Add(this.importanceGroupBox);
            this.eventGroupBox.Controls.Add(this.dateTimePicker1);
            this.eventGroupBox.Controls.Add(this.selectDateLabel);
            this.eventGroupBox.Controls.Add(this.selectPicLabel);
            this.eventGroupBox.Controls.Add(this.browserButton);
            this.eventGroupBox.Controls.Add(this.storyTextBox);
            this.eventGroupBox.Controls.Add(this.storyLabel);
            this.eventGroupBox.Controls.Add(this.eventNameTextBox);
            this.eventGroupBox.Controls.Add(this.eventLabel);
            this.eventGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventGroupBox.Location = new System.Drawing.Point(34, 25);
            this.eventGroupBox.Name = "eventGroupBox";
            this.eventGroupBox.Size = new System.Drawing.Size(687, 506);
            this.eventGroupBox.TabIndex = 0;
            this.eventGroupBox.TabStop = false;
            this.eventGroupBox.Text = "Event";
            // 
            // eventLabel
            // 
            this.eventLabel.AutoSize = true;
            this.eventLabel.Location = new System.Drawing.Point(45, 64);
            this.eventLabel.Name = "eventLabel";
            this.eventLabel.Size = new System.Drawing.Size(144, 29);
            this.eventLabel.TabIndex = 0;
            this.eventLabel.Text = "Event Name";
            // 
            // eventNameTextBox
            // 
            this.eventNameTextBox.Location = new System.Drawing.Point(208, 64);
            this.eventNameTextBox.Name = "eventNameTextBox";
            this.eventNameTextBox.Size = new System.Drawing.Size(143, 34);
            this.eventNameTextBox.TabIndex = 1;
            // 
            // storyTextBox
            // 
            this.storyTextBox.Location = new System.Drawing.Point(141, 119);
            this.storyTextBox.Multiline = true;
            this.storyTextBox.Name = "storyTextBox";
            this.storyTextBox.Size = new System.Drawing.Size(249, 108);
            this.storyTextBox.TabIndex = 3;
            // 
            // storyLabel
            // 
            this.storyLabel.AutoSize = true;
            this.storyLabel.Location = new System.Drawing.Point(57, 122);
            this.storyLabel.Name = "storyLabel";
            this.storyLabel.Size = new System.Drawing.Size(68, 29);
            this.storyLabel.TabIndex = 2;
            this.storyLabel.Text = "Story";
            // 
            // browserButton
            // 
            this.browserButton.Location = new System.Drawing.Point(208, 246);
            this.browserButton.Name = "browserButton";
            this.browserButton.Size = new System.Drawing.Size(113, 33);
            this.browserButton.TabIndex = 4;
            this.browserButton.Text = "Browser";
            this.browserButton.UseVisualStyleBackColor = true;
            // 
            // selectPicLabel
            // 
            this.selectPicLabel.AutoSize = true;
            this.selectPicLabel.Location = new System.Drawing.Point(27, 248);
            this.selectPicLabel.Name = "selectPicLabel";
            this.selectPicLabel.Size = new System.Drawing.Size(162, 29);
            this.selectPicLabel.TabIndex = 5;
            this.selectPicLabel.Text = "Select Picture";
            // 
            // selectDateLabel
            // 
            this.selectDateLabel.AutoSize = true;
            this.selectDateLabel.Location = new System.Drawing.Point(406, 64);
            this.selectDateLabel.Name = "selectDateLabel";
            this.selectDateLabel.Size = new System.Drawing.Size(203, 29);
            this.selectDateLabel.TabIndex = 6;
            this.selectDateLabel.Text = "Select Event Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(411, 96);
            this.dateTimePicker1.MaxDate = new System.DateTime(2021, 4, 14, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(247, 22);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.Value = new System.DateTime(2021, 4, 14, 0, 0, 0, 0);
            // 
            // importanceGroupBox
            // 
            this.importanceGroupBox.Controls.Add(this.lowRadioButton);
            this.importanceGroupBox.Controls.Add(this.moderateRadioButton);
            this.importanceGroupBox.Controls.Add(this.highRadioButton);
            this.importanceGroupBox.Location = new System.Drawing.Point(411, 175);
            this.importanceGroupBox.Name = "importanceGroupBox";
            this.importanceGroupBox.Size = new System.Drawing.Size(185, 129);
            this.importanceGroupBox.TabIndex = 8;
            this.importanceGroupBox.TabStop = false;
            this.importanceGroupBox.Text = "Importance";
            // 
            // highRadioButton
            // 
            this.highRadioButton.AutoSize = true;
            this.highRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highRadioButton.Location = new System.Drawing.Point(30, 33);
            this.highRadioButton.Name = "highRadioButton";
            this.highRadioButton.Size = new System.Drawing.Size(65, 24);
            this.highRadioButton.TabIndex = 0;
            this.highRadioButton.TabStop = true;
            this.highRadioButton.Text = "High";
            this.highRadioButton.UseVisualStyleBackColor = true;
            // 
            // moderateRadioButton
            // 
            this.moderateRadioButton.AutoSize = true;
            this.moderateRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moderateRadioButton.Location = new System.Drawing.Point(30, 63);
            this.moderateRadioButton.Name = "moderateRadioButton";
            this.moderateRadioButton.Size = new System.Drawing.Size(100, 24);
            this.moderateRadioButton.TabIndex = 1;
            this.moderateRadioButton.TabStop = true;
            this.moderateRadioButton.Text = "Moderate";
            this.moderateRadioButton.UseVisualStyleBackColor = true;
            // 
            // lowRadioButton
            // 
            this.lowRadioButton.AutoSize = true;
            this.lowRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowRadioButton.Location = new System.Drawing.Point(30, 93);
            this.lowRadioButton.Name = "lowRadioButton";
            this.lowRadioButton.Size = new System.Drawing.Size(61, 24);
            this.lowRadioButton.TabIndex = 2;
            this.lowRadioButton.TabStop = true;
            this.lowRadioButton.Text = "Low";
            this.lowRadioButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(544, 436);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(101, 34);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // EventCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 557);
            this.Controls.Add(this.eventGroupBox);
            this.Name = "EventCreation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EventCreation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EventCreation_FormClosing);
            this.eventGroupBox.ResumeLayout(false);
            this.eventGroupBox.PerformLayout();
            this.importanceGroupBox.ResumeLayout(false);
            this.importanceGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox eventGroupBox;
        private System.Windows.Forms.TextBox storyTextBox;
        private System.Windows.Forms.Label storyLabel;
        private System.Windows.Forms.TextBox eventNameTextBox;
        private System.Windows.Forms.Label eventLabel;
        private System.Windows.Forms.Label selectPicLabel;
        private System.Windows.Forms.Button browserButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label selectDateLabel;
        private System.Windows.Forms.GroupBox importanceGroupBox;
        private System.Windows.Forms.RadioButton lowRadioButton;
        private System.Windows.Forms.RadioButton moderateRadioButton;
        private System.Windows.Forms.RadioButton highRadioButton;
        private System.Windows.Forms.Button addButton;
    }
}