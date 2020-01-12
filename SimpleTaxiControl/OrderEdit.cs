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
    public partial class OrderEdit : Form
    {
        Order currentOrder;

        public OrderEdit(Order order)
        {
            InitializeComponent();

            currentOrder = order;
        }

        private void OrderEdit_Load(object sender, EventArgs e)
        {
            AddressFromTextBox.Text = currentOrder.AddressFrom;

            NumberFromTextBox.Text = currentOrder.NumberFrom;

            AddressToTextBox.Text = currentOrder.AddressTo;

            NumberToTextBox.Text = currentOrder.NumberTo;

            preOrderDateTimePicker.Value = currentOrder.Date;

            commentTextBox.Text = currentOrder.Comment;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Save();

            currentOrder.SaveChanges();
        }

        private void Save()
        {
            currentOrder.AddressFrom = AddressFromTextBox.Text;

            currentOrder.NumberFrom = NumberFromTextBox.Text;

            currentOrder.AddressTo = AddressToTextBox.Text;

            currentOrder.NumberTo = NumberToTextBox.Text;

            currentOrder.Date = (preOrderCheckBox.Checked) ? preOrderDateTimePicker.Value : DateTime.Now.AddMinutes((double)ExpectedTimePicker.Value);

            currentOrder.Comment = commentTextBox.Text;

        }


    }
}
