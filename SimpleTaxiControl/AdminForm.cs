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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            foreach (Call call in Call.GetAllCallsFromDB())
            {
                callsListView.Items.Add(new ListViewItem(new string[] { call.Id.ToString(),call.Number,call.ResponsibleUser.Name,call.Date.ToString() }));
            }

            userCombobox.Items.AddRange(User.GetAllUsersFromDB().Select(u => u.Name).ToArray());

        }


        private void callsSearchBtn_Click(object sender, EventArgs e)
        {
            IEnumerable<Call> calls = Call.GetAllCallsFromDB();

            if (idTextBox.Text != string.Empty)
            {
                calls = calls.Where(c => c.Id.ToString() == idTextBox.Text);
            }

            if (numberTextBox.Text != string.Empty)
            {
                calls = calls.Where(c => c.Number == numberTextBox.Text);
            }

            if (userCombobox.Text != string.Empty)
            {
                calls = calls.Where(c => c.ResponsibleUser.Name == userCombobox.Text);
            }

            if (datePicker.Enabled)
            {
                calls = calls.Where(c => c.Date.DayOfYear == datePicker.Value.DayOfYear);
            }

            callsListView.Items.Clear();

            foreach (Call call in calls)
            {
                callsListView.Items.Add(new ListViewItem(new string[] { call.Id.ToString(), call.Number, call.ResponsibleUser.Name, call.Date.ToString() }));
            }
        }

        private void dataCheckBox_MouseClick(object sender, MouseEventArgs e)
        {
            datePicker.Enabled = dataCheckBox.Checked;
        }

        private void orderSearchBtn_Click(object sender, EventArgs e)
        {
            IEnumerable<Order> orders = ActiveOrders.GetAllOrders();

            if (orderId.Text != string.Empty)
            {
                orders = orders.Where(o => o.Id.ToString() == orderId.Text);
            }

            if (orderCallId.Text != string.Empty)
            {
                orders = orders.Where(o => o.Call.Id.ToString() == orderCallId.Text);
            }

            if (orderDriverId.Text != string.Empty)
            {
                orders = orders.Where(o => o.Driver != null && o.Driver.Id.ToString() == orderDriverId.Text);
            }

            if (orderStatus.Text != string.Empty && orderStatus.SelectedIndex != 0)
            {
                orders = orders.Where(o => o.Status == (OrderStatuses)orderStatus.SelectedIndex);
            }

            if (orderDate.Enabled)
            {
                orders = orders.Where(o => o.Date.DayOfYear == orderDate.Value.DayOfYear);
            }

            ordersListView.Items.Clear();

            foreach (Order order in orders)
            {
                ordersListView.Items.Add(new ListViewItem(new string[]
                {
                    order.Id.ToString(),
                    $"{order.AddressFrom} {order.NumberFrom}",
                    $"{order.AddressTo} {order.NumberTo}",
                    order.Date.ToString(),
                    order.Status.ToString(),
                    order.Call.Id.ToString(),
                    order.Comment,
                    (order.Driver != null) ? order.Driver.Id.ToString(): "нет"
                }));

            }
        }

        private void orderDateCheckBox_MouseClick(object sender, MouseEventArgs e)
        {
            orderDate.Enabled = orderDateCheckBox.Checked;

        }
    }
}
