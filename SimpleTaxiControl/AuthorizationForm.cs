using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleTaxiControlLibrary;


namespace SimpleTaxiControl
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
            
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            User user = null;

            try { user = User.GetUser(loginTextBox.Text, passwordTextBox.Text); }

            catch { new EditConnection().Show(); }

            if (user != null)
            {
                if (user.Type == UserTypes.Admin)
                {
                    Program.Context.MainForm = new AdminForm(user);
                }
                else if (user.Type == UserTypes.Dispatcher)
                {
                    Program.Context.MainForm = new UserForm(user);
                }

                Program.Context.MainForm.Show();

                Close();

            }
            else if (MessageBox.Show("Введен неверный логин и/или пароль", "Ошибка", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Cancel) Close();
        }
    }
}
