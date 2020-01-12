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
            this.idLabel.Location = new System.Drawing.Point(12, 9);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(52, 13);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "Заказ №";
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(12, 22);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(24, 13);
            this.fromLabel.TabIndex = 1;
            this.fromLabel.Text = "Из ";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(12, 35);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(14, 13);
            this.toLabel.TabIndex = 2;
            this.toLabel.Text = "В";
            // 
            // driverComboBox
            // 
            this.driverComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.driverComboBox.FormattingEnabled = true;
            this.driverComboBox.Location = new System.Drawing.Point(12, 51);
            this.driverComboBox.Name = "driverComboBox";
            this.driverComboBox.Size = new System.Drawing.Size(121, 21);
            this.driverComboBox.TabIndex = 3;
            // 
            // appointDriverBtn
            // 
            this.appointDriverBtn.Location = new System.Drawing.Point(12, 92);
            this.appointDriverBtn.Name = "appointDriverBtn";
            this.appointDriverBtn.Size = new System.Drawing.Size(121, 31);
            this.appointDriverBtn.TabIndex = 4;
            this.appointDriverBtn.Text = "Назначить водителя ";
            this.appointDriverBtn.UseVisualStyleBackColor = true;
            this.appointDriverBtn.Click += new System.EventHandler(this.appointDriverBtn_Click);
            // 
            // AppointDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 242);
            this.Controls.Add(this.appointDriverBtn);
            this.Controls.Add(this.driverComboBox);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.idLabel);
            this.Name = "AppointDriver";
            this.Text = "AppointDriver";
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