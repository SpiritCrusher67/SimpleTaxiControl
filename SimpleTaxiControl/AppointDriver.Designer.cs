namespace SimpleTaxiControl
{
    partial class AppointDriver
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
            this.idLabel = new System.Windows.Forms.Label();
            this.fromLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.driverComboBox = new System.Windows.Forms.ComboBox();
            this.appointDriverBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(13, 9);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(63, 19);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "Заказ №";
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(13, 37);
            this.fromLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(30, 19);
            this.fromLabel.TabIndex = 1;
            this.fromLabel.Text = "Из ";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(13, 65);
            this.toLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(23, 19);
            this.toLabel.TabIndex = 2;
            this.toLabel.Text = "В ";
            // 
            // driverComboBox
            // 
            this.driverComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.driverComboBox.FormattingEnabled = true;
            this.driverComboBox.Location = new System.Drawing.Point(13, 88);
            this.driverComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.driverComboBox.Name = "driverComboBox";
            this.driverComboBox.Size = new System.Drawing.Size(223, 27);
            this.driverComboBox.TabIndex = 3;
            // 
            // appointDriverBtn
            // 
            this.appointDriverBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(64)))));
            this.appointDriverBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appointDriverBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appointDriverBtn.ForeColor = System.Drawing.Color.Black;
            this.appointDriverBtn.Location = new System.Drawing.Point(11, 123);
            this.appointDriverBtn.Margin = new System.Windows.Forms.Padding(4);
            this.appointDriverBtn.Name = "appointDriverBtn";
            this.appointDriverBtn.Size = new System.Drawing.Size(225, 45);
            this.appointDriverBtn.TabIndex = 4;
            this.appointDriverBtn.Text = "Назначить водителя ";
            this.appointDriverBtn.UseVisualStyleBackColor = false;
            this.appointDriverBtn.Click += new System.EventHandler(this.appointDriverBtn_Click);
            // 
            // AppointDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(249, 181);
            this.Controls.Add(this.appointDriverBtn);
            this.Controls.Add(this.driverComboBox);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.idLabel);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(115)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AppointDriver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Назначить водителя";
            this.Load += new System.EventHandler(this.AppointDriver_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.ComboBox driverComboBox;
        private System.Windows.Forms.Button appointDriverBtn;
    }
}