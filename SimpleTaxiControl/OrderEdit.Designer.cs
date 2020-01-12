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
            this.cancelBtn.Location = new System.Drawing.Point(163, 334);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(109, 38);
            this.cancelBtn.TabIndex = 11;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(12, 334);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(145, 38);
            this.saveBtn.TabIndex = 10;
            this.saveBtn.Text = "Сохранить изменения";
            this.saveBtn.UseVisualStyleBackColor = true;
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
            this.groupBox3.Location = new System.Drawing.Point(12, 171);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(397, 157);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Дополнительно";
            // 
            // ExpectedTimePicker
            // 
            this.ExpectedTimePicker.Location = new System.Drawing.Point(174, 44);
            this.ExpectedTimePicker.Name = "ExpectedTimePicker";
            this.ExpectedTimePicker.Size = new System.Drawing.Size(56, 20);
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
            this.label7.Location = new System.Drawing.Point(11, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Ожидаемое время прибытия:";
            // 
            // commentTextBox
            // 
            this.commentTextBox.Location = new System.Drawing.Point(6, 85);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(385, 66);
            this.commentTextBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Комментарий:";
            // 
            // preOrderDateTimePicker
            // 
            this.preOrderDateTimePicker.Enabled = false;
            this.preOrderDateTimePicker.Location = new System.Drawing.Point(164, 16);
            this.preOrderDateTimePicker.Name = "preOrderDateTimePicker";
            this.preOrderDateTimePicker.Size = new System.Drawing.Size(227, 20);
            this.preOrderDateTimePicker.TabIndex = 1;
            // 
            // preOrderCheckBox
            // 
            this.preOrderCheckBox.AutoSize = true;
            this.preOrderCheckBox.Location = new System.Drawing.Point(6, 19);
            this.preOrderCheckBox.Name = "preOrderCheckBox";
            this.preOrderCheckBox.Size = new System.Drawing.Size(152, 17);
            this.preOrderCheckBox.TabIndex = 0;
            this.preOrderCheckBox.Text = "Предварительный заказ";
            this.preOrderCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NumberToTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.AddressToTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 67);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Куда";
            // 
            // NumberToTextBox
            // 
            this.NumberToTextBox.Location = new System.Drawing.Point(256, 19);
            this.NumberToTextBox.Name = "NumberToTextBox";
            this.NumberToTextBox.Size = new System.Drawing.Size(100, 20);
            this.NumberToTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Номер дома:";
            // 
            // AddressToTextBox
            // 
            this.AddressToTextBox.Location = new System.Drawing.Point(71, 19);
            this.AddressToTextBox.Name = "AddressToTextBox";
            this.AddressToTextBox.Size = new System.Drawing.Size(100, 20);
            this.AddressToTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Адрес:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NumberFromTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.AddressFromTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 67);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Откуда";
            // 
            // NumberFromTextBox
            // 
            this.NumberFromTextBox.Location = new System.Drawing.Point(256, 19);
            this.NumberFromTextBox.Name = "NumberFromTextBox";
            this.NumberFromTextBox.Size = new System.Drawing.Size(100, 20);
            this.NumberFromTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Номер дома:";
            // 
            // AddressFromTextBox
            // 
            this.AddressFromTextBox.Location = new System.Drawing.Point(71, 19);
            this.AddressFromTextBox.Name = "AddressFromTextBox";
            this.AddressFromTextBox.Size = new System.Drawing.Size(100, 20);
            this.AddressFromTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Адрес:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Заказ №";
            // 
            // OrderEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 381);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "OrderEdit";
            this.Text = "OrderEdit";
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