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
            this.components = new System.ComponentModel.Container();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.callsGrBox = new System.Windows.Forms.GroupBox();
            this.takeСallBtn = new System.Windows.Forms.Button();
            this.incomingCallsListBox = new System.Windows.Forms.ListBox();
            this.freeOrdersGrBox = new System.Windows.Forms.GroupBox();
            this.freeOrdersListView = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.acceptedOrdersGrBox = new System.Windows.Forms.GroupBox();
            this.acceptedOrdersListView = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.executingOrdersGrBox = new System.Windows.Forms.GroupBox();
            this.executingOrdersListView = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.driversGrBox = new System.Windows.Forms.GroupBox();
            this.driversListView = new System.Windows.Forms.ListView();
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mainMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.callsGrBox.SuspendLayout();
            this.freeOrdersGrBox.SuspendLayout();
            this.acceptedOrdersGrBox.SuspendLayout();
            this.executingOrdersGrBox.SuspendLayout();
            this.driversGrBox.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(115)))));
            this.userNameLabel.Location = new System.Drawing.Point(13, 9);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(104, 19);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "Пользователь:";
            // 
            // callsGrBox
            // 
            this.callsGrBox.Controls.Add(this.takeСallBtn);
            this.callsGrBox.Controls.Add(this.incomingCallsListBox);
            this.callsGrBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(115)))));
            this.callsGrBox.Location = new System.Drawing.Point(13, 37);
            this.callsGrBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.callsGrBox.Name = "callsGrBox";
            this.callsGrBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.callsGrBox.Size = new System.Drawing.Size(219, 300);
            this.callsGrBox.TabIndex = 1;
            this.callsGrBox.TabStop = false;
            this.callsGrBox.Text = "Входящие звонки";
            // 
            // takeСallBtn
            // 
            this.takeСallBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(64)))));
            this.takeСallBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.takeСallBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.takeСallBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.takeСallBtn.ForeColor = System.Drawing.Color.Black;
            this.takeСallBtn.Location = new System.Drawing.Point(8, 245);
            this.takeСallBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.takeСallBtn.Name = "takeСallBtn";
            this.takeСallBtn.Size = new System.Drawing.Size(203, 47);
            this.takeСallBtn.TabIndex = 1;
            this.takeСallBtn.Text = "Принять звонок";
            this.takeСallBtn.UseVisualStyleBackColor = false;
            this.takeСallBtn.Click += new System.EventHandler(this.takeСallBtn_Click);
            // 
            // incomingCallsListBox
            // 
            this.incomingCallsListBox.BackColor = System.Drawing.Color.White;
            this.incomingCallsListBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.incomingCallsListBox.ForeColor = System.Drawing.Color.Black;
            this.incomingCallsListBox.FormattingEnabled = true;
            this.incomingCallsListBox.ItemHeight = 21;
            this.incomingCallsListBox.Items.AddRange(new object[] {
            "8(800)555-35-35",
            "8(900)555-35-35"});
            this.incomingCallsListBox.Location = new System.Drawing.Point(9, 28);
            this.incomingCallsListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.incomingCallsListBox.Name = "incomingCallsListBox";
            this.incomingCallsListBox.Size = new System.Drawing.Size(202, 214);
            this.incomingCallsListBox.TabIndex = 0;
            // 
            // freeOrdersGrBox
            // 
            this.freeOrdersGrBox.Controls.Add(this.freeOrdersListView);
            this.freeOrdersGrBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(115)))));
            this.freeOrdersGrBox.Location = new System.Drawing.Point(240, 37);
            this.freeOrdersGrBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.freeOrdersGrBox.Name = "freeOrdersGrBox";
            this.freeOrdersGrBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.freeOrdersGrBox.Size = new System.Drawing.Size(364, 300);
            this.freeOrdersGrBox.TabIndex = 2;
            this.freeOrdersGrBox.TabStop = false;
            this.freeOrdersGrBox.Text = "Свободные заказы";
            // 
            // freeOrdersListView
            // 
            this.freeOrdersListView.BackColor = System.Drawing.Color.White;
            this.freeOrdersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader2});
            this.freeOrdersListView.FullRowSelect = true;
            this.freeOrdersListView.Location = new System.Drawing.Point(9, 28);
            this.freeOrdersListView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.freeOrdersListView.Name = "freeOrdersListView";
            this.freeOrdersListView.Size = new System.Drawing.Size(346, 264);
            this.freeOrdersListView.TabIndex = 0;
            this.freeOrdersListView.UseCompatibleStateImageBehavior = false;
            this.freeOrdersListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Id";
            this.columnHeader3.Width = 63;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Откуда";
            this.columnHeader1.Width = 121;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Куда";
            this.columnHeader2.Width = 155;
            // 
            // acceptedOrdersGrBox
            // 
            this.acceptedOrdersGrBox.Controls.Add(this.acceptedOrdersListView);
            this.acceptedOrdersGrBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(115)))));
            this.acceptedOrdersGrBox.Location = new System.Drawing.Point(612, 37);
            this.acceptedOrdersGrBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.acceptedOrdersGrBox.Name = "acceptedOrdersGrBox";
            this.acceptedOrdersGrBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.acceptedOrdersGrBox.Size = new System.Drawing.Size(483, 300);
            this.acceptedOrdersGrBox.TabIndex = 3;
            this.acceptedOrdersGrBox.TabStop = false;
            this.acceptedOrdersGrBox.Text = "Принятые заказы";
            // 
            // acceptedOrdersListView
            // 
            this.acceptedOrdersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader7});
            this.acceptedOrdersListView.FullRowSelect = true;
            this.acceptedOrdersListView.Location = new System.Drawing.Point(9, 28);
            this.acceptedOrdersListView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.acceptedOrdersListView.Name = "acceptedOrdersListView";
            this.acceptedOrdersListView.Size = new System.Drawing.Size(466, 264);
            this.acceptedOrdersListView.TabIndex = 0;
            this.acceptedOrdersListView.UseCompatibleStateImageBehavior = false;
            this.acceptedOrdersListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Id";
            this.columnHeader6.Width = 46;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Откуда";
            this.columnHeader4.Width = 160;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Куда";
            this.columnHeader5.Width = 159;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Водитель";
            this.columnHeader7.Width = 94;
            // 
            // executingOrdersGrBox
            // 
            this.executingOrdersGrBox.Controls.Add(this.executingOrdersListView);
            this.executingOrdersGrBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(115)))));
            this.executingOrdersGrBox.Location = new System.Drawing.Point(488, 345);
            this.executingOrdersGrBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.executingOrdersGrBox.Name = "executingOrdersGrBox";
            this.executingOrdersGrBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.executingOrdersGrBox.Size = new System.Drawing.Size(607, 310);
            this.executingOrdersGrBox.TabIndex = 4;
            this.executingOrdersGrBox.TabStop = false;
            this.executingOrdersGrBox.Text = "Выполняемые заказы";
            // 
            // executingOrdersListView
            // 
            this.executingOrdersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader11});
            this.executingOrdersListView.FullRowSelect = true;
            this.executingOrdersListView.Location = new System.Drawing.Point(9, 28);
            this.executingOrdersListView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.executingOrdersListView.Name = "executingOrdersListView";
            this.executingOrdersListView.Size = new System.Drawing.Size(590, 274);
            this.executingOrdersListView.TabIndex = 0;
            this.executingOrdersListView.UseCompatibleStateImageBehavior = false;
            this.executingOrdersListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Id";
            this.columnHeader10.Width = 76;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Откуда";
            this.columnHeader8.Width = 187;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Куда";
            this.columnHeader9.Width = 200;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Водитель";
            this.columnHeader11.Width = 119;
            // 
            // driversGrBox
            // 
            this.driversGrBox.Controls.Add(this.driversListView);
            this.driversGrBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(115)))));
            this.driversGrBox.Location = new System.Drawing.Point(17, 345);
            this.driversGrBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.driversGrBox.Name = "driversGrBox";
            this.driversGrBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.driversGrBox.Size = new System.Drawing.Size(467, 310);
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
            this.driversListView.FullRowSelect = true;
            this.driversListView.Location = new System.Drawing.Point(9, 28);
            this.driversListView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.driversListView.Name = "driversListView";
            this.driversListView.Size = new System.Drawing.Size(450, 274);
            this.driversListView.TabIndex = 0;
            this.driversListView.UseCompatibleStateImageBehavior = false;
            this.driversListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Id";
            this.columnHeader16.Width = 96;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Статус";
            this.columnHeader17.Width = 167;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Модель";
            this.columnHeader18.Width = 182;
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRefresh});
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(129, 26);
            // 
            // menuRefresh
            // 
            this.menuRefresh.Name = "menuRefresh";
            this.menuRefresh.Size = new System.Drawing.Size(128, 22);
            this.menuRefresh.Text = "Обновить";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1104, 671);
            this.ContextMenuStrip = this.mainMenu;
            this.Controls.Add(this.acceptedOrdersGrBox);
            this.Controls.Add(this.freeOrdersGrBox);
            this.Controls.Add(this.executingOrdersGrBox);
            this.Controls.Add(this.driversGrBox);
            this.Controls.Add(this.callsGrBox);
            this.Controls.Add(this.userNameLabel);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1120, 710);
            this.MinimumSize = new System.Drawing.Size(1120, 710);
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню пользователя";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.callsGrBox.ResumeLayout(false);
            this.freeOrdersGrBox.ResumeLayout(false);
            this.acceptedOrdersGrBox.ResumeLayout(false);
            this.executingOrdersGrBox.ResumeLayout(false);
            this.driversGrBox.ResumeLayout(false);
            this.mainMenu.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox acceptedOrdersGrBox;
        private System.Windows.Forms.ListView acceptedOrdersListView;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.GroupBox executingOrdersGrBox;
        private System.Windows.Forms.ListView executingOrdersListView;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.GroupBox driversGrBox;
        private System.Windows.Forms.ListView driversListView;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ContextMenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem menuRefresh;
    }
}