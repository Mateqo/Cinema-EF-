namespace MateuszBartkowiakHomework4
{
    partial class Ticket
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
            this.labelSelectTicket = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.checkBoxVip = new System.Windows.Forms.CheckBox();
            this.comboBoxTypeOfTicket = new System.Windows.Forms.ComboBox();
            this.labelMoney = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelPLN = new System.Windows.Forms.Label();
            this.pictureBoxPevious = new System.Windows.Forms.PictureBox();
            this.pictureBoxNext = new System.Windows.Forms.PictureBox();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.dateTimerPicker = new System.Windows.Forms.DateTimePicker();
            this.labelTime = new System.Windows.Forms.Label();
            this.pictureBoxInfo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSelectTicket
            // 
            this.labelSelectTicket.AutoSize = true;
            this.labelSelectTicket.BackColor = System.Drawing.Color.Transparent;
            this.labelSelectTicket.Font = new System.Drawing.Font("Modern No. 20", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectTicket.Location = new System.Drawing.Point(250, 9);
            this.labelSelectTicket.Name = "labelSelectTicket";
            this.labelSelectTicket.Size = new System.Drawing.Size(303, 50);
            this.labelSelectTicket.TabIndex = 0;
            this.labelSelectTicket.Text = "Select a ticket";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(67, 128);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(96, 30);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name :";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.BackColor = System.Drawing.Color.Transparent;
            this.labelSurname.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSurname.Location = new System.Drawing.Point(27, 176);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(136, 30);
            this.labelSurname.TabIndex = 2;
            this.labelSurname.Text = "Surname :";
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.PeachPuff;
            this.textBoxName.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(174, 128);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(110, 30);
            this.textBoxName.TabIndex = 3;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.BackColor = System.Drawing.Color.PeachPuff;
            this.textBoxSurname.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSurname.Location = new System.Drawing.Point(174, 176);
            this.textBoxSurname.Multiline = true;
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(110, 29);
            this.textBoxSurname.TabIndex = 4;
            // 
            // checkBoxVip
            // 
            this.checkBoxVip.AutoSize = true;
            this.checkBoxVip.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxVip.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxVip.Location = new System.Drawing.Point(27, 308);
            this.checkBoxVip.Name = "checkBoxVip";
            this.checkBoxVip.Size = new System.Drawing.Size(302, 34);
            this.checkBoxVip.TabIndex = 5;
            this.checkBoxVip.Text = "Vip (Polsat Passport)";
            this.checkBoxVip.UseVisualStyleBackColor = false;
            // 
            // comboBoxTypeOfTicket
            // 
            this.comboBoxTypeOfTicket.BackColor = System.Drawing.Color.PeachPuff;
            this.comboBoxTypeOfTicket.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTypeOfTicket.FormattingEnabled = true;
            this.comboBoxTypeOfTicket.Items.AddRange(new object[] {
            "Normal",
            "Student"});
            this.comboBoxTypeOfTicket.Location = new System.Drawing.Point(27, 248);
            this.comboBoxTypeOfTicket.Name = "comboBoxTypeOfTicket";
            this.comboBoxTypeOfTicket.Size = new System.Drawing.Size(110, 33);
            this.comboBoxTypeOfTicket.TabIndex = 6;
            this.comboBoxTypeOfTicket.Text = "Normal";
            this.comboBoxTypeOfTicket.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTypeOfTicket_SelectedIndexChanged);
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.BackColor = System.Drawing.Color.Transparent;
            this.labelMoney.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMoney.Location = new System.Drawing.Point(153, 248);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(93, 30);
            this.labelMoney.TabIndex = 7;
            this.labelMoney.Text = "Price :";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.BackColor = System.Drawing.Color.Transparent;
            this.labelPrice.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(252, 248);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(41, 30);
            this.labelPrice.TabIndex = 8;
            this.labelPrice.Text = "30";
            // 
            // labelPLN
            // 
            this.labelPLN.AutoSize = true;
            this.labelPLN.BackColor = System.Drawing.Color.Transparent;
            this.labelPLN.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPLN.Location = new System.Drawing.Point(295, 248);
            this.labelPLN.Name = "labelPLN";
            this.labelPLN.Size = new System.Drawing.Size(72, 30);
            this.labelPLN.TabIndex = 9;
            this.labelPLN.Text = "PLN";
            // 
            // pictureBoxPevious
            // 
            this.pictureBoxPevious.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPevious.BackgroundImage = global::MateuszBartkowiakHomework4.Properties.Resources.previous;
            this.pictureBoxPevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxPevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPevious.Location = new System.Drawing.Point(12, 372);
            this.pictureBoxPevious.Name = "pictureBoxPevious";
            this.pictureBoxPevious.Size = new System.Drawing.Size(70, 66);
            this.pictureBoxPevious.TabIndex = 10;
            this.pictureBoxPevious.TabStop = false;
            this.pictureBoxPevious.Click += new System.EventHandler(this.PictureBoxPevious_Click);
            // 
            // pictureBoxNext
            // 
            this.pictureBoxNext.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxNext.BackgroundImage = global::MateuszBartkowiakHomework4.Properties.Resources.next;
            this.pictureBoxNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxNext.Location = new System.Drawing.Point(718, 372);
            this.pictureBoxNext.Name = "pictureBoxNext";
            this.pictureBoxNext.Size = new System.Drawing.Size(70, 66);
            this.pictureBoxNext.TabIndex = 11;
            this.pictureBoxNext.TabStop = false;
            this.pictureBoxNext.Click += new System.EventHandler(this.PictureBoxNext_Click);
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxExit.BackgroundImage = global::MateuszBartkowiakHomework4.Properties.Resources.exit;
            this.pictureBoxExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxExit.Location = new System.Drawing.Point(718, 12);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(70, 66);
            this.pictureBoxExit.TabIndex = 12;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.PictureBoxExit_Click);
            // 
            // dateTimerPicker
            // 
            this.dateTimerPicker.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimerPicker.CalendarMonthBackground = System.Drawing.Color.LightSkyBlue;
            this.dateTimerPicker.CalendarTitleBackColor = System.Drawing.Color.DarkRed;
            this.dateTimerPicker.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimerPicker.CalendarTrailingForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dateTimerPicker.CustomFormat = " dddd dd-MMM-yyyy  HH:mm";
            this.dateTimerPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimerPicker.Location = new System.Drawing.Point(387, 128);
            this.dateTimerPicker.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimerPicker.Name = "dateTimerPicker";
            this.dateTimerPicker.ShowUpDown = true;
            this.dateTimerPicker.Size = new System.Drawing.Size(302, 22);
            this.dateTimerPicker.TabIndex = 21;
            this.dateTimerPicker.Value = new System.DateTime(2019, 12, 7, 14, 0, 0, 0);
            this.dateTimerPicker.ValueChanged += new System.EventHandler(this.DateTimerPicker_ValueChanged);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.Transparent;
            this.labelTime.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(382, 181);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(23, 30);
            this.labelTime.TabIndex = 22;
            this.labelTime.Text = "-";
            // 
            // pictureBoxInfo
            // 
            this.pictureBoxInfo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxInfo.BackgroundImage = global::MateuszBartkowiakHomework4.Properties.Resources.user;
            this.pictureBoxInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxInfo.Location = new System.Drawing.Point(642, 12);
            this.pictureBoxInfo.Name = "pictureBoxInfo";
            this.pictureBoxInfo.Size = new System.Drawing.Size(70, 66);
            this.pictureBoxInfo.TabIndex = 24;
            this.pictureBoxInfo.TabStop = false;
            this.pictureBoxInfo.Click += new System.EventHandler(this.PictureBoxInfo_Click);
            // 
            // Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MateuszBartkowiakHomework4.Properties.Resources.backGroundTicket;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxInfo);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.dateTimerPicker);
            this.Controls.Add(this.pictureBoxExit);
            this.Controls.Add(this.pictureBoxNext);
            this.Controls.Add(this.pictureBoxPevious);
            this.Controls.Add(this.labelPLN);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelMoney);
            this.Controls.Add(this.comboBoxTypeOfTicket);
            this.Controls.Add(this.checkBoxVip);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelSelectTicket);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ticket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPevious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSelectTicket;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.CheckBox checkBoxVip;
        private System.Windows.Forms.ComboBox comboBoxTypeOfTicket;
        private System.Windows.Forms.Label labelMoney;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelPLN;
        private System.Windows.Forms.PictureBox pictureBoxPevious;
        private System.Windows.Forms.PictureBox pictureBoxNext;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.DateTimePicker dateTimerPicker;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.PictureBox pictureBoxInfo;
    }
}