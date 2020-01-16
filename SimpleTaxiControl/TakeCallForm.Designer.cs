namespace SimpleTaxiControl
{
    partial class TakeCallForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NumberFromTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddressFromTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NumberToTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddressToTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ExpectedTimePicker = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.preOrderDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.preOrderCheckBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.acceptOrderBtn = new System.Windows.Forms.Button();
            this.rejectOrderBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpectedTimePicker)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NumberFromTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.AddressFromTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(115)))));
            this.groupBox1.Location = new System.Drawing.Point(13, 37);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(404, 61);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Откуда";
            // 
            // NumberFromTextBox
            // 
            this.NumberFromTextBox.Location = new System.Drawing.Point(348, 20);
            this.NumberFromTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NumberFromTextBox.Name = "NumberFromTextBox";
            this.NumberFromTextBox.Size = new System.Drawing.Size(50, 26);
            this.NumberFromTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Номер дома:";
            // 
            // AddressFromTextBox
            // 
            this.AddressFromTextBox.Location = new System.Drawing.Point(69, 20);
            this.AddressFromTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddressFromTextBox.Name = "AddressFromTextBox";
            this.AddressFromTextBox.Size = new System.Drawing.Size(170, 26);
            this.AddressFromTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Адрес:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NumberToTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.AddressToTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(115)))));
            this.groupBox2.Location = new System.Drawing.Point(13, 106);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(404, 61);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Куда";
            // 
            // NumberToTextBox
            // 
            this.NumberToTextBox.Location = new System.Drawing.Point(348, 20);
            this.NumberToTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NumberToTextBox.Name = "NumberToTextBox";
            this.NumberToTextBox.Size = new System.Drawing.Size(50, 26);
            this.NumberToTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Номер дома:";
            // 
            // AddressToTextBox
            // 
            this.AddressToTextBox.Location = new System.Drawing.Point(69, 20);
            this.AddressToTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddressToTextBox.Name = "AddressToTextBox";
            this.AddressToTextBox.Size = new System.Drawing.Size(170, 26);
            this.AddressToTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Адрес:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ExpectedTimePicker);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.commentTextBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.preOrderDateTimePicker);
            this.groupBox3.Controls.Add(this.preOrderCheckBox);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(115)))));
            this.groupBox3.Location = new System.Drawing.Point(13, 175);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(404, 212);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Дополнительно";
            // 
            // ExpectedTimePicker
            // 
            this.ExpectedTimePicker.Location = new System.Drawing.Point(223, 59);
            this.ExpectedTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExpectedTimePicker.Name = "ExpectedTimePicker";
            this.ExpectedTimePicker.Size = new System.Drawing.Size(171, 26);
            this.ExpectedTimePicker.TabIndex = 5;
            this.ExpectedTimePicker.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 61);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 19);
            this.label7.TabIndex = 4;
            this.label7.Text = "Ожидаемое время прибытия:";
            // 
            // commentTextBox
            // 
            this.commentTextBox.Location = new System.Drawing.Point(8, 107);
            this.commentTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(386, 95);
            this.commentTextBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 84);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Комментарий:";
            // 
            // preOrderDateTimePicker
            // 
            this.preOrderDateTimePicker.CustomFormat = "dd.MM.yyyy HH:mm";
            this.preOrderDateTimePicker.Enabled = false;
            this.preOrderDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.preOrderDateTimePicker.Location = new System.Drawing.Point(223, 25);
            this.preOrderDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.preOrderDateTimePicker.Name = "preOrderDateTimePicker";
            this.preOrderDateTimePicker.Size = new System.Drawing.Size(171, 26);
            this.preOrderDateTimePicker.TabIndex = 1;
            // 
            // preOrderCheckBox
            // 
            this.preOrderCheckBox.AutoSize = true;
            this.preOrderCheckBox.Location = new System.Drawing.Point(8, 27);
            this.preOrderCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.preOrderCheckBox.Name = "preOrderCheckBox";
            this.preOrderCheckBox.Size = new System.Drawing.Size(192, 23);
            this.preOrderCheckBox.TabIndex = 0;
            this.preOrderCheckBox.Text = "Предварительный заказ:";
            this.preOrderCheckBox.UseVisualStyleBackColor = true;
            this.preOrderCheckBox.CheckedChanged += new System.EventHandler(this.preOrderCheckBox_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Номер телефона: ";
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(143, 9);
            this.numberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(119, 19);
            this.numberLabel.TabIndex = 4;
            this.numberLabel.Text = "8(800)222-22-22";
            // 
            // acceptOrderBtn
            // 
            this.acceptOrderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(64)))));
            this.acceptOrderBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.acceptOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptOrderBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.acceptOrderBtn.ForeColor = System.Drawing.Color.Black;
            this.acceptOrderBtn.Location = new System.Drawing.Point(13, 395);
            this.acceptOrderBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.acceptOrderBtn.Name = "acceptOrderBtn";
            this.acceptOrderBtn.Size = new System.Drawing.Size(200, 56);
            this.acceptOrderBtn.TabIndex = 5;
            this.acceptOrderBtn.Text = "Принять заказ";
            this.acceptOrderBtn.UseVisualStyleBackColor = false;
            this.acceptOrderBtn.Click += new System.EventHandler(this.acceptOrderBtn_Click);
            // 
            // rejectOrderBtn
            // 
            this.rejectOrderBtn.AllowDrop = true;
            this.rejectOrderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(64)))));
            this.rejectOrderBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rejectOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rejectOrderBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rejectOrderBtn.ForeColor = System.Drawing.Color.Black;
            this.rejectOrderBtn.Location = new System.Drawing.Point(221, 395);
            this.rejectOrderBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rejectOrderBtn.Name = "rejectOrderBtn";
            this.rejectOrderBtn.Size = new System.Drawing.Size(200, 56);
            this.rejectOrderBtn.TabIndex = 6;
            this.rejectOrderBtn.Text = "Отклонить заказ";
            this.rejectOrderBtn.UseVisualStyleBackColor = false;
            this.rejectOrderBtn.Click += new System.EventHandler(this.rejectOrderBtn_Click);
            // 
            // TakeCallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(427, 462);
            this.Controls.Add(this.rejectOrderBtn);
            this.Controls.Add(this.acceptOrderBtn);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(115)))));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TakeCallForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню принятия заказа";
            this.Load += new System.EventHandler(this.TakeCallForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpectedTimePicker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox NumberFromTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AddressFromTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox NumberToTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AddressToTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker preOrderDateTimePicker;
        private System.Windows.Forms.CheckBox preOrderCheckBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Button acceptOrderBtn;
        private System.Windows.Forms.Button rejectOrderBtn;
        private System.Windows.Forms.NumericUpDown ExpectedTimePicker;
        private System.Windows.Forms.Label label7;
    }
}