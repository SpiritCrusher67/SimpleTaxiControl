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
    public partial class TakeCallForm : Form
    {
        public Call CurrentCall { get; set; }

        public TakeCallForm(Call call)
        {
            InitializeComponent();

            CurrentCall = call;
        }

        private void TakeCallForm_Load(object sender, EventArgs e)
        {
            numberLabel.Text = CurrentCall.Number;
        }

        private void preOrderCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            preOrderDateTimePicker.Enabled = preOrderCheckBox.Checked;
        }

        private void acceptOrderBtn_Click(object sender, EventArgs e)
        {
            double expectedTime = (double)ExpectedTimePicker.Value;

            DateTime preDate = (preOrderCheckBox.Checked) ? preOrderDateTimePicker.Value : DateTime.Now.AddMinutes(expectedTime);

            Order order = 
                new Order(AddressFromTextBox.Text, NumberFromTextBox.Text, AddressToTextBox.Text, NumberToTextBox.Text, preDate, commentTextBox.Text, CurrentCall);

            Close();
        }

        private void rejectOrderBtn_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
