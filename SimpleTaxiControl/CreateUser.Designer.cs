namespace SimpleTaxiControl
{
    partial class CreateUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.randomPasswordBtn = new System.Windows.Forms.Button();
            this.createUserBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(59, 6);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(59, 32);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(100, 20);
            this.loginTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Логин:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(59, 58);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Пароль:";
            // 
            // randomPasswordBtn
            // 
            this.randomPasswordBtn.Location = new System.Drawing.Point(165, 56);
            this.randomPasswordBtn.Name = "randomPasswordBtn";
            this.randomPasswordBtn.Size = new System.Drawing.Size(116, 23);
            this.randomPasswordBtn.TabIndex = 6;
            this.randomPasswordBtn.Text = "Случайный пароль";
            this.randomPasswordBtn.UseVisualStyleBackColor = true;
            this.randomPasswordBtn.Click += new System.EventHandler(this.randomPasswordBtn_Click);
            // 
            // createUserBtn
            // 
            this.createUserBtn.Location = new System.Drawing.Point(8, 84);
            this.createUserBtn.Name = "createUserBtn";
            this.createUserBtn.Size = new System.Drawing.Size(151, 23);
            this.createUserBtn.TabIndex = 7;
            this.createUserBtn.Text = "Создать пользователя";
            this.createUserBtn.UseVisualStyleBackColor = true;
            this.createUserBtn.Click += new System.EventHandler(this.createUserBtn_Click);
            // 
            // CreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 135);
            this.Controls.Add(this.createUserBtn);
            this.Controls.Add(this.randomPasswordBtn);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "CreateUser";
            this.Text = "CreateUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button randomPasswordBtn;
        private System.Windows.Forms.Button createUserBtn;
    }
}