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
    public partial class CreateDriver : Form
    {
        public CreateDriver()
        {
            InitializeComponent();
        }

        private void createUserBtn_Click(object sender, EventArgs e)
        {
            if (Driver.SaveDriverInDb(nameTextBox.Text,modelTextBox.Text) != 0)
            {
                MessageBox.Show("Водитель создан");
                Close();
            }
            else
            {
                MessageBox.Show("Водитель не создан");
            }
        }
    }
}
