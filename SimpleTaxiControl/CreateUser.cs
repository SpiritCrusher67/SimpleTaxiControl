using SimpleTaxiControlLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleTaxiControl
{
    public partial class CreateUser : Form
    {
        public CreateUser()
        {
            InitializeComponent();
        }

        private void randomPasswordBtn_Click(object sender, EventArgs e)
        {
            passwordTextBox.Text = User.GetRandomPassword(8);
        }

        private void createUserBtn_Click(object sender, EventArgs e)
        {
            if (User.SaveUserInDb(loginTextBox.Text, passwordTextBox.Text, nameTextBox.Text) != 0)
            {
                MessageBox.Show("Пользователь создан");
                Close();
            }
            else
            {
                MessageBox.Show("Пользователь с таким логином уже создан");
            }
        }
    }
}
