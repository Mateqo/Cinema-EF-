namespace MateuszBartkowiakHomework4
{
    partial class Result
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Result));
            this.labelOrders = new System.Windows.Forms.Label();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonFiltr = new System.Windows.Forms.Button();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.pictureBoxInfo = new System.Windows.Forms.PictureBox();
            this.dataGridViewClient = new System.Windows.Forms.DataGridView();
            this.buttonFiltrClient = new System.Windows.Forms.Button();
            this.labelClients = new System.Windows.Forms.Label();
            this.buttonChangeName = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonChangeSurname = new System.Windows.Forms.Button();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.buttonConfirmName = new System.Windows.Forms.Button();
            this.buttonConfirmSurname = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).BeginInit();
            this.SuspendLayout();
            // 
            // labelOrders
            // 
            this.labelOrders.AutoSize = true;
            this.labelOrders.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelOrders.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrders.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelOrders.Location = new System.Drawing.Point(77, 12);
            this.labelOrders.Name = "labelOrders";
            this.labelOrders.Size = new System.Drawing.Size(194, 62);
            this.labelOrders.TabIndex = 0;
            this.labelOrders.Text = "Orders";
            this.labelOrders.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Location = new System.Drawing.Point(12, 89);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.ReadOnly = true;
            this.dataGridViewOrder.RowTemplate.Height = 24;
            this.dataGridViewOrder.Size = new System.Drawing.Size(358, 219);
            this.dataGridViewOrder.TabIndex = 1;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Bisque;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(207, 316);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(163, 65);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Delete my order";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // buttonFiltr
            // 
            this.buttonFiltr.BackColor = System.Drawing.Color.Bisque;
            this.buttonFiltr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFiltr.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFiltr.Location = new System.Drawing.Point(12, 316);
            this.buttonFiltr.Name = "buttonFiltr";
            this.buttonFiltr.Size = new System.Drawing.Size(158, 65);
            this.buttonFiltr.TabIndex = 8;
            this.buttonFiltr.Text = "Show my order";
            this.buttonFiltr.UseVisualStyleBackColor = false;
            this.buttonFiltr.Click += new System.EventHandler(this.ButtonFiltr_Click);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.AutoSize = true;
            this.buttonConfirm.BackColor = System.Drawing.Color.Bisque;
            this.buttonConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConfirm.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirm.Location = new System.Drawing.Point(679, 382);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(109, 59);
            this.buttonConfirm.TabIndex = 9;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = false;
            this.buttonConfirm.Click += new System.EventHandler(this.ButtonConfirm_Click);
            // 
            // pictureBoxInfo
            // 
            this.pictureBoxInfo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxInfo.BackgroundImage = global::MateuszBartkowiakHomework4.Properties.Resources.user;
            this.pictureBoxInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxInfo.Location = new System.Drawing.Point(721, 12);
            this.pictureBoxInfo.Name = "pictureBoxInfo";
            this.pictureBoxInfo.Size = new System.Drawing.Size(67, 62);
            this.pictureBoxInfo.TabIndex = 58;
            this.pictureBoxInfo.TabStop = false;
            this.pictureBoxInfo.Click += new System.EventHandler(this.PictureBoxInfo_Click);
            // 
            // dataGridViewClient
            // 
            this.dataGridViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClient.Location = new System.Drawing.Point(376, 89);
            this.dataGridViewClient.Name = "dataGridViewClient";
            this.dataGridViewClient.ReadOnly = true;
            this.dataGridViewClient.RowTemplate.Height = 24;
            this.dataGridViewClient.Size = new System.Drawing.Size(379, 129);
            this.dataGridViewClient.TabIndex = 59;
            // 
            // buttonFiltrClient
            // 
            this.buttonFiltrClient.BackColor = System.Drawing.Color.Bisque;
            this.buttonFiltrClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFiltrClient.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFiltrClient.Location = new System.Drawing.Point(376, 224);
            this.buttonFiltrClient.Name = "buttonFiltrClient";
            this.buttonFiltrClient.Size = new System.Drawing.Size(109, 70);
            this.buttonFiltrClient.TabIndex = 60;
            this.buttonFiltrClient.Text = "Show my data";
            this.buttonFiltrClient.UseVisualStyleBackColor = false;
            this.buttonFiltrClient.Click += new System.EventHandler(this.ButtonFiltrClient_Click);
            // 
            // labelClients
            // 
            this.labelClients.AutoSize = true;
            this.labelClients.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelClients.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClients.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelClients.Location = new System.Drawing.Point(463, 12);
            this.labelClients.Name = "labelClients";
            this.labelClients.Size = new System.Drawing.Size(201, 62);
            this.labelClients.TabIndex = 61;
            this.labelClients.Text = "Clients";
            this.labelClients.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonChangeName
            // 
            this.buttonChangeName.BackColor = System.Drawing.Color.Bisque;
            this.buttonChangeName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChangeName.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangeName.Location = new System.Drawing.Point(491, 224);
            this.buttonChangeName.Name = "buttonChangeName";
            this.buttonChangeName.Size = new System.Drawing.Size(123, 70);
            this.buttonChangeName.TabIndex = 62;
            this.buttonChangeName.Text = "Change my name";
            this.buttonChangeName.UseVisualStyleBackColor = false;
            this.buttonChangeName.Click += new System.EventHandler(this.ButtonChangeName_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.PeachPuff;
            this.textBoxName.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(491, 300);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(123, 32);
            this.textBoxName.TabIndex = 63;
            this.textBoxName.Visible = false;
            // 
            // buttonChangeSurname
            // 
            this.buttonChangeSurname.BackColor = System.Drawing.Color.Bisque;
            this.buttonChangeSurname.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChangeSurname.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangeSurname.Location = new System.Drawing.Point(620, 224);
            this.buttonChangeSurname.Name = "buttonChangeSurname";
            this.buttonChangeSurname.Size = new System.Drawing.Size(135, 70);
            this.buttonChangeSurname.TabIndex = 64;
            this.buttonChangeSurname.Text = "Change my surname";
            this.buttonChangeSurname.UseVisualStyleBackColor = false;
            this.buttonChangeSurname.Click += new System.EventHandler(this.ButtonChangeSurname_Click);
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.BackColor = System.Drawing.Color.PeachPuff;
            this.textBoxSurname.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSurname.Location = new System.Drawing.Point(620, 300);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(135, 32);
            this.textBoxSurname.TabIndex = 65;
            this.textBoxSurname.Visible = false;
            // 
            // buttonConfirmName
            // 
            this.buttonConfirmName.AutoSize = true;
            this.buttonConfirmName.BackColor = System.Drawing.Color.Bisque;
            this.buttonConfirmName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConfirmName.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmName.Location = new System.Drawing.Point(491, 338);
            this.buttonConfirmName.Name = "buttonConfirmName";
            this.buttonConfirmName.Size = new System.Drawing.Size(123, 38);
            this.buttonConfirmName.TabIndex = 66;
            this.buttonConfirmName.Text = "Confirm";
            this.buttonConfirmName.UseVisualStyleBackColor = false;
            this.buttonConfirmName.Visible = false;
            this.buttonConfirmName.Click += new System.EventHandler(this.ButtonConfirmName_Click);
            // 
            // buttonConfirmSurname
            // 
            this.buttonConfirmSurname.AutoSize = true;
            this.buttonConfirmSurname.BackColor = System.Drawing.Color.Bisque;
            this.buttonConfirmSurname.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConfirmSurname.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmSurname.Location = new System.Drawing.Point(620, 338);
            this.buttonConfirmSurname.Name = "buttonConfirmSurname";
            this.buttonConfirmSurname.Size = new System.Drawing.Size(135, 38);
            this.buttonConfirmSurname.TabIndex = 67;
            this.buttonConfirmSurname.Text = "Confirm";
            this.buttonConfirmSurname.UseVisualStyleBackColor = false;
            this.buttonConfirmSurname.Visible = false;
            this.buttonConfirmSurname.Click += new System.EventHandler(this.ButtonConfirmSurname_Click);
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonConfirmSurname);
            this.Controls.Add(this.buttonConfirmName);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.buttonChangeSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonChangeName);
            this.Controls.Add(this.labelClients);
            this.Controls.Add(this.buttonFiltrClient);
            this.Controls.Add(this.dataGridViewClient);
            this.Controls.Add(this.pictureBoxInfo);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.buttonFiltr);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.dataGridViewOrder);
            this.Controls.Add(this.labelOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Result";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Result";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOrders;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonFiltr;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.PictureBox pictureBoxInfo;
        private System.Windows.Forms.DataGridView dataGridViewClient;
        private System.Windows.Forms.Button buttonFiltrClient;
        private System.Windows.Forms.Label labelClients;
        private System.Windows.Forms.Button buttonChangeName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonChangeSurname;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Button buttonConfirmName;
        private System.Windows.Forms.Button buttonConfirmSurname;
    }
}