namespace SimpleTaxiControl
{
    partial class AdminForm
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
            this.callsGrBox = new System.Windows.Forms.GroupBox();
            this.callsListView = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userCombobox = new System.Windows.Forms.ComboBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.callsSearchBtn = new System.Windows.Forms.Button();
            this.dataCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.orderDateCheckBox = new System.Windows.Forms.CheckBox();
            this.orderSearchBtn = new System.Windows.Forms.Button();
            this.orderDate = new System.Windows.Forms.DateTimePicker();
            this.orderStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.orderCallId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.orderId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ordersListView = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderDriverId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.callsGrBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // callsGrBox
            // 
            this.callsGrBox.Controls.Add(this.dataCheckBox);
            this.callsGrBox.Controls.Add(this.callsSearchBtn);
            this.callsGrBox.Controls.Add(this.datePicker);
            this.callsGrBox.Controls.Add(this.userCombobox);
            this.callsGrBox.Controls.Add(this.label3);
            this.callsGrBox.Controls.Add(this.numberTextBox);
            this.callsGrBox.Controls.Add(this.label2);
            this.callsGrBox.Controls.Add(this.idTextBox);
            this.callsGrBox.Controls.Add(this.label1);
            this.callsGrBox.Controls.Add(this.callsListView);
            this.callsGrBox.Location = new System.Drawing.Point(12, 12);
            this.callsGrBox.Name = "callsGrBox";
            this.callsGrBox.Size = new System.Drawing.Size(506, 210);
            this.callsGrBox.TabIndex = 4;
            this.callsGrBox.TabStop = false;
            this.callsGrBox.Text = "Звонки";
            // 
            // callsListView
            // 
            this.callsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.callsListView.FullRowSelect = true;
            this.callsListView.Location = new System.Drawing.Point(6, 71);
            this.callsListView.Name = "callsListView";
            this.callsListView.Size = new System.Drawing.Size(492, 133);
            this.callsListView.TabIndex = 0;
            this.callsListView.UseCompatibleStateImageBehavior = false;
            this.callsListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Id";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Номер";
            this.columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Пользователь";
            this.columnHeader2.Width = 170;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Дата";
            this.columnHeader3.Width = 118;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(31, 13);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(55, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(146, 13);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(87, 20);
            this.numberTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Номер:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Пользователь:";
            // 
            // userCombobox
            // 
            this.userCombobox.FormattingEnabled = true;
            this.userCombobox.Location = new System.Drawing.Point(328, 13);
            this.userCombobox.Name = "userCombobox";
            this.userCombobox.Size = new System.Drawing.Size(121, 21);
            this.userCombobox.TabIndex = 8;
            // 
            // datePicker
            // 
            this.datePicker.CustomFormat = "dd.MM.yyyy";
            this.datePicker.Enabled = false;
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(67, 45);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(90, 20);
            this.datePicker.TabIndex = 10;
            // 
            // callsSearchBtn
            // 
            this.callsSearchBtn.Location = new System.Drawing.Point(163, 42);
            this.callsSearchBtn.Name = "callsSearchBtn";
            this.callsSearchBtn.Size = new System.Drawing.Size(87, 23);
            this.callsSearchBtn.TabIndex = 11;
            this.callsSearchBtn.Text = "Поиск";
            this.callsSearchBtn.UseVisualStyleBackColor = true;
            this.callsSearchBtn.Click += new System.EventHandler(this.callsSearchBtn_Click);
            // 
            // dataCheckBox
            // 
            this.dataCheckBox.AutoSize = true;
            this.dataCheckBox.Location = new System.Drawing.Point(6, 46);
            this.dataCheckBox.Name = "dataCheckBox";
            this.dataCheckBox.Size = new System.Drawing.Size(55, 17);
            this.dataCheckBox.TabIndex = 12;
            this.dataCheckBox.Text = "Дата:";
            this.dataCheckBox.UseVisualStyleBackColor = true;
            this.dataCheckBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataCheckBox_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.orderDriverId);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.orderDateCheckBox);
            this.groupBox1.Controls.Add(this.orderSearchBtn);
            this.groupBox1.Controls.Add(this.orderDate);
            this.groupBox1.Controls.Add(this.orderStatus);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.orderCallId);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.orderId);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ordersListView);
            this.groupBox1.Location = new System.Drawing.Point(524, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 210);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Заказы";
            // 
            // orderDateCheckBox
            // 
            this.orderDateCheckBox.AutoSize = true;
            this.orderDateCheckBox.Location = new System.Drawing.Point(6, 46);
            this.orderDateCheckBox.Name = "orderDateCheckBox";
            this.orderDateCheckBox.Size = new System.Drawing.Size(55, 17);
            this.orderDateCheckBox.TabIndex = 12;
            this.orderDateCheckBox.Text = "Дата:";
            this.orderDateCheckBox.UseVisualStyleBackColor = true;
            this.orderDateCheckBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.orderDateCheckBox_MouseClick);
            // 
            // orderSearchBtn
            // 
            this.orderSearchBtn.Location = new System.Drawing.Point(163, 42);
            this.orderSearchBtn.Name = "orderSearchBtn";
            this.orderSearchBtn.Size = new System.Drawing.Size(87, 23);
            this.orderSearchBtn.TabIndex = 11;
            this.orderSearchBtn.Text = "Поиск";
            this.orderSearchBtn.UseVisualStyleBackColor = true;
            this.orderSearchBtn.Click += new System.EventHandler(this.orderSearchBtn_Click);
            // 
            // orderDate
            // 
            this.orderDate.CustomFormat = "dd.MM.yyyy";
            this.orderDate.Enabled = false;
            this.orderDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.orderDate.Location = new System.Drawing.Point(67, 45);
            this.orderDate.Name = "orderDate";
            this.orderDate.Size = new System.Drawing.Size(90, 20);
            this.orderDate.TabIndex = 10;
            // 
            // orderStatus
            // 
            this.orderStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orderStatus.FormattingEnabled = true;
            this.orderStatus.Items.AddRange(new object[] {
            "Все",
            "Свободен",
            "Принят",
            "Выполняется",
            "Выполнен"});
            this.orderStatus.Location = new System.Drawing.Point(471, 13);
            this.orderStatus.Name = "orderStatus";
            this.orderStatus.Size = new System.Drawing.Size(121, 21);
            this.orderStatus.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Статус:";
            // 
            // orderCallId
            // 
            this.orderCallId.Location = new System.Drawing.Point(163, 13);
            this.orderCallId.Name = "orderCallId";
            this.orderCallId.Size = new System.Drawing.Size(87, 20);
            this.orderCallId.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Id звонка:";
            // 
            // orderId
            // 
            this.orderId.Location = new System.Drawing.Point(31, 13);
            this.orderId.Name = "orderId";
            this.orderId.Size = new System.Drawing.Size(55, 20);
            this.orderId.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Id:";
            // 
            // ordersListView
            // 
            this.ordersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15});
            this.ordersListView.FullRowSelect = true;
            this.ordersListView.Location = new System.Drawing.Point(6, 71);
            this.ordersListView.Name = "ordersListView";
            this.ordersListView.Size = new System.Drawing.Size(603, 133);
            this.ordersListView.TabIndex = 0;
            this.ordersListView.UseCompatibleStateImageBehavior = false;
            this.ordersListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Id";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Откуда";
            this.columnHeader9.Width = 84;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Куда";
            this.columnHeader10.Width = 89;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Дата";
            this.columnHeader11.Width = 86;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Статус";
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Id звонка";
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Комментарий";
            this.columnHeader14.Width = 87;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Id водителя";
            this.columnHeader15.Width = 72;
            // 
            // orderDriverId
            // 
            this.orderDriverId.Location = new System.Drawing.Point(328, 13);
            this.orderDriverId.Name = "orderDriverId";
            this.orderDriverId.Size = new System.Drawing.Size(87, 20);
            this.orderDriverId.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(253, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Id водителя:";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.callsGrBox);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.callsGrBox.ResumeLayout(false);
            this.callsGrBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox callsGrBox;
        private System.Windows.Forms.ListView callsListView;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.ComboBox userCombobox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button callsSearchBtn;
        private System.Windows.Forms.CheckBox dataCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox orderDateCheckBox;
        private System.Windows.Forms.Button orderSearchBtn;
        private System.Windows.Forms.DateTimePicker orderDate;
        private System.Windows.Forms.ComboBox orderStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox orderCallId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox orderId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView ordersListView;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox orderDriverId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
    }
}