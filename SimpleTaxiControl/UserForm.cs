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
    public partial class UserForm : Form
    {
        public User CurentUser { get; }

        public UserForm()
        {
            InitializeComponent();
            
        }

        public UserForm(User user)
        {
            InitializeComponent();
            CurentUser = user;
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            userNameLabel.Text = "Пользователь: " + CurentUser.Name;

        }

        private void takeСallBtn_Click(object sender, EventArgs e)
        {
            incomingCallsListBox.Items.Remove(incomingCallsListBox.SelectedItem);

            Call call = new Call(incomingCallsListBox.SelectedItem.ToString(), CurentUser);

            new TakeCallForm(call).Show();
        }
    }
}
