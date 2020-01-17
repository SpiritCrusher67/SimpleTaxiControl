namespace SimpleTaxiControl
{
    partial class OrderEdit
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
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ExpectedTimePicker = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.preOrderDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.preOrderCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NumberToTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddressToTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NumberFromTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddressFromTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpectedTimePicker)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.AllowDrop = true;
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(64)))));
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelBtn.ForeColor = System.Drawing.Color.Black;
            this.cancelBtn.Location = new System.Drawing.Point(397, 294);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(163, 56);
            this.cancelBtn.TabIndex = 11;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(64)))));
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.ForeColor = System.Drawing.Color.Black;
            this.saveBtn.Location = new System.Drawing.Point(397, 230);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(163, 56);
            this.saveBtn.TabIndex = 10;
            this.saveBtn.Text = "Сохранить изменения";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
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
            this.groupBox3.Location = new System.Drawing.Point(13, 138);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(381, 212);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Дополнительно";
            // 
            // ExpectedTimePicker
            // 
            this.ExpectedTimePicker.Location = new System.Drawing.Point(223, 58);
            this.ExpectedTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.ExpectedTimePicker.Name = "ExpectedTimePicker";
            this.ExpectedTimePicker.Size = new System.Drawing.Size(153, 26);
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
            this.label7.Location = new System.Drawing.Point(8, 60);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 19);
            this.label7.TabIndex = 4;
            this.label7.Text = "Ожидаемое время прибытия:";
            // 
            // commentTextBox
            // 
            this.commentTextBox.Location = new System.Drawing.Point(5, 112);
            this.commentTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(371, 95);
            this.commentTextBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 89);
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
            this.preOrderDateTimePicker.Location = new System.Drawing.Point(220, 24);
            this.preOrderDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.preOrderDateTimePicker.Name = "preOrderDateTimePicker";
            this.preOrderDateTimePicker.Size = new System.Drawing.Size(156, 26);
            this.preOrderDateTimePicker.TabIndex = 1;
            // 
            // preOrderCheckBox
            // 
            this.preOrderCheckBox.AutoSize = true;
            this.preOrderCheckBox.Location = new System.Drawing.Point(23, 27);
            this.preOrderCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.preOrderCheckBox.Name = "preOrderCheckBox";
            this.preOrderCheckBox.Size = new System.Drawing.Size(189, 23);
            this.preOrderCheckBox.TabIndex = 0;
            this.preOrderCheckBox.Text = "Предварительный заказ";
            this.preOrderCheckBox.UseVisualStyleBackColor = true;
            this.preOrderCheckBox.CheckedChanged += new System.EventHandler(this.preOrderCheckBox_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NumberToTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.AddressToTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(115)))));
            this.groupBox2.Location = new System.Drawing.Point(293, 32);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(267, 98);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Куда";
            // 
            // NumberToTextBox
            // 
            this.NumberToTextBox.Location = new System.Drawing.Point(104, 58);
            this.NumberToTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NumberToTextBox.Name = "NumberToTextBox";
            this.NumberToTextBox.Size = new System.Drawing.Size(46, 26);
            this.NumberToTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Номер дома:";
            // 
            // AddressToTextBox
            // 
            this.AddressToTextBox.Location = new System.Drawing.Point(104, 20);
            this.AddressToTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.AddressToTextBox.Name = "AddressToTextBox";
            this.AddressToTextBox.Size = new System.Drawing.Size(148, 26);
            this.AddressToTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Адрес:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NumberFromTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.AddressFromTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(115)))));
            this.groupBox1.Location = new System.Drawing.Point(13, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(272, 98);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Откуда";
            // 
            // NumberFromTextBox
            // 
            this.NumberFromTextBox.Location = new System.Drawing.Point(109, 54);
            this.NumberFromTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NumberFromTextBox.Name = "NumberFromTextBox";
            this.NumberFromTextBox.Size = new System.Drawing.Size(46, 26);
            this.NumberFromTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Номер дома:";
            // 
            // AddressFromTextBox
            // 
            this.AddressFromTextBox.Location = new System.Drawing.Point(109, 20);
            this.AddressFromTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.AddressFromTextBox.Name = "AddressFromTextBox";
            this.AddressFromTextBox.Size = new System.Drawing.Size(148, 26);
            this.AddressFromTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Адрес:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Заказ №";
            // 
            // OrderEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(570, 361);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(115)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrderEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование заказа";
            this.Load += new System.EventHandler(this.OrderEdit_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpectedTimePicker)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown ExpectedTimePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker preOrderDateTimePicker;
        private System.Windows.Forms.CheckBox preOrderCheckBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox NumberToTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AddressToTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox NumberFromTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AddressFromTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}