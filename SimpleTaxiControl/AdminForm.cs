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
        public User CurrentUser { get; }

        public AdminForm(User user)
        {
            InitializeComponent();

            CurrentUser = user;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            LoadCalls();

            userCombobox.Items.AddRange(User.GetAllUsersFromDB().Select(u => u.Name).ToArray());

            LoadOrders(Order.GetAllOrders());

            LoadUsers(User.GetAllUsersFromDB());

            LoadDrivers(OnlineDrivers.GetAllDrivers());

            callsContMenuRefresh.Click += CallsContMenuRefresh_Click;

            ordersContMenuRefresh.Click += OrdersContMenuRefresh_Click;

            usersContMenuRefresh.Click += UsersContMenuRefresh_Click;

            usersContMenuShowPassword.Click += UsersContMenuShowPassword_Click;

            driversContMenuRefresh.Click += DriversContMenuRefresh_Click;

            userNameLabel.Text += CurrentUser.Name;

        }

        private void UsersContMenuShowPassword_Click(object sender, EventArgs e)
        {
            if (usersListView.SelectedItems.Count > 0)
            {
                string password = User.GetUserPassword(usersListView.SelectedItems[0].Text,CurrentUser);

                if (MessageBox.Show($"Пароль: {password }\nСкопировать в буфер обмена?", "Пароль пользователя", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Clipboard.SetText(password);
                }
            }
        }

        private void DriversContMenuRefresh_Click(object sender, EventArgs e) => LoadDrivers(OnlineDrivers.GetAllDrivers());

        private void UsersContMenuRefresh_Click(object sender, EventArgs e) => LoadUsers(User.GetAllUsersFromDB());
            
        private void OrdersContMenuRefresh_Click(object sender, EventArgs e) => LoadOrders(Order.GetAllOrders());

        private void CallsContMenuRefresh_Click(object sender, EventArgs e) => LoadCalls();



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
            IEnumerable<Order> orders = Order.GetAllOrders();

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

            LoadOrders(orders);
        }

        private void LoadCalls()
        {
            callsListView.Items.Clear();

            foreach (Call call in Call.GetAllCallsFromDB())
            {
                callsListView.Items.Add(new ListViewItem(new string[] 
                {
                    call.Id.ToString(),
                    call.Number,
                    call.ResponsibleUser.Name,
                    call.Date.ToString()
                }));
            }
        }

        private void LoadOrders(IEnumerable<Order> orders)
        {
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

        private void LoadUsers(IEnumerable<User> users)
        {
            usersListView.Items.Clear();

            foreach (User user in users)
            {
                usersListView.Items.Add(new ListViewItem(new string[]
                {
                    user.Login,
                    user.Name,
                    user.Type.ToString()
                }));
            }
        }

        private void LoadDrivers(IEnumerable<Driver> drivers)
        {
            driversListView.Items.Clear();

            foreach (Driver driver in drivers)
            {
                driversListView.Items.Add(new ListViewItem(new string[]
                {
                    driver.Id.ToString(),
                    driver.Model,
                    driver.Name,
                    driver.Status.ToString()

                }));
            }
        }

        private void orderDateCheckBox_MouseClick(object sender, MouseEventArgs e)
        {
            orderDate.Enabled = orderDateCheckBox.Checked;

        }

        private void userSearchBtn_Click(object sender, EventArgs e)
        {
            IEnumerable<User> users = User.GetAllUsersFromDB();

            if (userLogin.Text != string.Empty)
            {
                users = users.Where(u => u.Login == userLogin.Text);
            }

            if (userName.Text != string.Empty)
            {
                users = users.Where(u => u.Name.IndexOf(userName.Text) != -1);
            }

            LoadUsers(users);
        }

        private void driverSearchBtn_Click(object sender, EventArgs e)
        {
            IEnumerable<Driver> drivers = OnlineDrivers.GetAllDrivers();

            if (driverId.Text != string.Empty)
            {
                drivers = drivers.Where(d => d.Id.ToString() == driverId.Text);
            }

            if (driverModel.Text != string.Empty)
            {
                drivers = drivers.Where(d => d.Model.IndexOf(driverModel.Text) != -1);
            }

            if (driverName.Text != string.Empty)
            {
                drivers = drivers.Where(d => d.Name.IndexOf(driverName.Text) != -1);
            }

            if (driverName.Text != string.Empty)
            {
                drivers = drivers.Where(d => d.Name.IndexOf(driverName.Text) != -1);
            }

            if (driverStatus.Text != string.Empty && driverStatus.SelectedIndex != 0)
            {
                drivers = drivers.Where(d => d.Status == (DriverStatuses)driverStatus.SelectedIndex);
            }

            LoadDrivers(drivers);
        }

        private void createUserBtn_Click(object sender, EventArgs e)
        {
            new CreateUser().Show();
        }

        private void createDriverBtn_Click(object sender, EventArgs e)
        {
            new CreateDriver().Show();
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.Context.MainForm = new AuthorizationForm();

            Program.Context.MainForm.Show();
        }
    }
}
