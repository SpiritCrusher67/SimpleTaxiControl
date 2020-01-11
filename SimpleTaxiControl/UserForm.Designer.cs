namespace SimpleTaxiControl
{
    partial class UserForm
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
            this.userNameLabel = new System.Windows.Forms.Label();
            this.callsGrBox = new System.Windows.Forms.GroupBox();
            this.takeСallBtn = new System.Windows.Forms.Button();
            this.incomingCallsListBox = new System.Windows.Forms.ListBox();
            this.freeOrdersGrBox = new System.Windows.Forms.GroupBox();
            this.freeOrdersListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.acceptedOrdersGrBox = new System.Windows.Forms.GroupBox();
            this.acceptedOrdersListView = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.executingOrdersGrBox = new System.Windows.Forms.GroupBox();
            this.executingOrdersListView = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.driversGrBox = new System.Windows.Forms.GroupBox();
            this.driversListView = new System.Windows.Forms.ListView();
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.callsGrBox.SuspendLayout();
            this.freeOrdersGrBox.SuspendLayout();
            this.acceptedOrdersGrBox.SuspendLayout();
            this.executingOrdersGrBox.SuspendLayout();
            this.driversGrBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(12, 9);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(35, 13);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "label1";
            // 
            // callsGrBox
            // 
            this.callsGrBox.Controls.Add(this.takeСallBtn);
            this.callsGrBox.Controls.Add(this.incomingCallsListBox);
            this.callsGrBox.Location = new System.Drawing.Point(12, 25);
            this.callsGrBox.Name = "callsGrBox";
            this.callsGrBox.Size = new System.Drawing.Size(146, 158);
            this.callsGrBox.TabIndex = 1;
            this.callsGrBox.TabStop = false;
            this.callsGrBox.Text = "Входящие звонки";
            // 
            // takeСallBtn
            // 
            this.takeСallBtn.Location = new System.Drawing.Point(6, 120);
            this.takeСallBtn.Name = "takeСallBtn";
            this.takeСallBtn.Size = new System.Drawing.Size(130, 32);
            this.takeСallBtn.TabIndex = 1;
            this.takeСallBtn.Text = "Принять звонок";
            this.takeСallBtn.UseVisualStyleBackColor = true;
            this.takeСallBtn.Click += new System.EventHandler(this.takeСallBtn_Click);
            // 
            // incomingCallsListBox
            // 
            this.incomingCallsListBox.FormattingEnabled = true;
            this.incomingCallsListBox.Items.AddRange(new object[] {
            "8(800)555-35-35",
            "8(900)555-35-35"});
            this.incomingCallsListBox.Location = new System.Drawing.Point(6, 19);
            this.incomingCallsListBox.Name = "incomingCallsListBox";
            this.incomingCallsListBox.Size = new System.Drawing.Size(130, 95);
            this.incomingCallsListBox.TabIndex = 0;
            // 
            // freeOrdersGrBox
            // 
            this.freeOrdersGrBox.Controls.Add(this.freeOrdersListView);
            this.freeOrdersGrBox.Location = new System.Drawing.Point(164, 25);
            this.freeOrdersGrBox.Name = "freeOrdersGrBox";
            this.freeOrdersGrBox.Size = new System.Drawing.Size(284, 158);
            this.freeOrdersGrBox.TabIndex = 2;
            this.freeOrdersGrBox.TabStop = false;
            this.freeOrdersGrBox.Text = "Свободные заказы";
            // 
            // freeOrdersListView
            // 
            this.freeOrdersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.freeOrdersListView.Location = new System.Drawing.Point(6, 19);
            this.freeOrdersListView.Name = "freeOrdersListView";
            this.freeOrdersListView.Size = new System.Drawing.Size(272, 133);
            this.freeOrdersListView.TabIndex = 0;
            this.freeOrdersListView.UseCompatibleStateImageBehavior = false;
            this.freeOrdersListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Откуда";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Куда";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Цена";
            // 
            // acceptedOrdersGrBox
            // 
            this.acceptedOrdersGrBox.Controls.Add(this.acceptedOrdersListView);
            this.acceptedOrdersGrBox.Location = new System.Drawing.Point(454, 25);
            this.acceptedOrdersGrBox.Name = "acceptedOrdersGrBox";
            this.acceptedOrdersGrBox.Size = new System.Drawing.Size(284, 158);
            this.acceptedOrdersGrBox.TabIndex = 3;
            this.acceptedOrdersGrBox.TabStop = false;
            this.acceptedOrdersGrBox.Text = "Принятые заказы";
            // 
            // acceptedOrdersListView
            // 
            this.acceptedOrdersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.acceptedOrdersListView.Location = new System.Drawing.Point(6, 19);
            this.acceptedOrdersListView.Name = "acceptedOrdersListView";
            this.acceptedOrdersListView.Size = new System.Drawing.Size(272, 133);
            this.acceptedOrdersListView.TabIndex = 0;
            this.acceptedOrdersListView.UseCompatibleStateImageBehavior = false;
            this.acceptedOrdersListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Откуда";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Куда";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Цена";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Водитель";
            // 
            // executingOrdersGrBox
            // 
            this.executingOrdersGrBox.Controls.Add(this.executingOrdersListView);
            this.executingOrdersGrBox.Location = new System.Drawing.Point(744, 25);
            this.executingOrdersGrBox.Name = "executingOrdersGrBox";
            this.executingOrdersGrBox.Size = new System.Drawing.Size(284, 158);
            this.executingOrdersGrBox.TabIndex = 4;
            this.executingOrdersGrBox.TabStop = false;
            this.executingOrdersGrBox.Text = "Выполняемые заказы";
            // 
            // executingOrdersListView
            // 
            this.executingOrdersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.executingOrdersListView.Location = new System.Drawing.Point(6, 19);
            this.executingOrdersListView.Name = "executingOrdersListView";
            this.executingOrdersListView.Size = new System.Drawing.Size(272, 133);
            this.executingOrdersListView.TabIndex = 0;
            this.executingOrdersListView.UseCompatibleStateImageBehavior = false;
            this.executingOrdersListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Откуда";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Куда";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Цена";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Водитель";
            // 
            // driversGrBox
            // 
            this.driversGrBox.Controls.Add(this.driversListView);
            this.driversGrBox.Location = new System.Drawing.Point(12, 189);
            this.driversGrBox.Name = "driversGrBox";
            this.driversGrBox.Size = new System.Drawing.Size(289, 158);
            this.driversGrBox.TabIndex = 5;
            this.driversGrBox.TabStop = false;
            this.driversGrBox.Text = "Водители";
            // 
            // driversListView
            // 
            this.driversListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18});
            this.driversListView.Location = new System.Drawing.Point(6, 19);
            this.driversListView.Name = "driversListView";
            this.driversListView.Size = new System.Drawing.Size(277, 133);
            this.driversListView.TabIndex = 0;
            this.driversListView.UseCompatibleStateImageBehavior = false;
            this.driversListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Id";
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Статус";
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Модель";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.driversGrBox);
            this.Controls.Add(this.executingOrdersGrBox);
            this.Controls.Add(this.acceptedOrdersGrBox);
            this.Controls.Add(this.freeOrdersGrBox);
            this.Controls.Add(this.callsGrBox);
            this.Controls.Add(this.userNameLabel);
            this.Name = "UserForm";
            this.Text = "Форма пользователя";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.callsGrBox.ResumeLayout(false);
            this.freeOrdersGrBox.ResumeLayout(false);
            this.acceptedOrdersGrBox.ResumeLayout(false);
            this.executingOrdersGrBox.ResumeLayout(false);
            this.driversGrBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.GroupBox callsGrBox;
        private System.Windows.Forms.Button takeСallBtn;
        private System.Windows.Forms.ListBox incomingCallsListBox;
        private System.Windows.Forms.GroupBox freeOrdersGrBox;
        private System.Windows.Forms.ListView freeOrdersListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox acceptedOrdersGrBox;
        private System.Windows.Forms.ListView acceptedOrdersListView;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.GroupBox executingOrdersGrBox;
        private System.Windows.Forms.ListView executingOrdersListView;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.GroupBox driversGrBox;
        private System.Windows.Forms.ListView driversListView;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
    }
}