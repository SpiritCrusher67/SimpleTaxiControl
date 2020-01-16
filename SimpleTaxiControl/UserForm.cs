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
        public User CurrentUser { get; }

        public UserForm()
        {
            InitializeComponent();

        }

        public UserForm(User user)
        {
            InitializeComponent();
            CurrentUser = user;
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            userNameLabel.Text = "Пользователь: " + CurrentUser.Name;
            LoadData();

            ContextMenuStrip freeOrdersMenu = new ContextMenuStrip();

            freeOrdersMenu.Items.Add("Назначить водителя",new Bitmap(23,32),SetDriver);

            freeOrdersMenu.Items.Add("Редактировать", new Bitmap(23, 32),EditOrder);

            freeOrdersListView.ContextMenuStrip = freeOrdersMenu;

            ContextMenuStrip acceptedOrdersMenu = new ContextMenuStrip();

            acceptedOrdersMenu.Items.Add("Установить статус \"Выполняется\"", new Bitmap(23, 32), SetOrderInProgress);

            acceptedOrdersListView.ContextMenuStrip = acceptedOrdersMenu;

            ContextMenuStrip inProgresOrdersMenu = new ContextMenuStrip();

            inProgresOrdersMenu.Items.Add("Установить статус \"Выполнен\"", new Bitmap(23, 32), SetOrderCompleted);

            executingOrdersListView.ContextMenuStrip = inProgresOrdersMenu;
        }

        private void SetDriver(object sender, EventArgs e)
        {
            if(freeOrdersListView.SelectedItems.Count > 0)
            {
                new AppointDriver(Order.GetFreeOrders().Where(o => o.Id.ToString() == freeOrdersListView.SelectedItems[0].SubItems[0].Text).First()).Show();
            }
            else
            {
                MessageBox.Show("Выберите заказ");

            }
        }

        private void EditOrder(object sender, EventArgs e)
        {
            if (freeOrdersListView.SelectedItems.Count > 0)
            {
                new OrderEdit(Order.GetFreeOrders().Where(o => o.Id.ToString() == freeOrdersListView.SelectedItems[0].SubItems[0].Text).First()).Show();
            }
            else
            {
                MessageBox.Show("Выберите заказ");

            }
        }

        private void SetOrderInProgress(object sender, EventArgs e)
        {
            if (acceptedOrdersListView.SelectedItems.Count>0)
            {
                Order selectedOrder = Order.GetAcceptedOrders().Where(o => o.Id.ToString() == acceptedOrdersListView.SelectedItems[0].SubItems[0].Text).First();

                selectedOrder.Status = OrderStatuses.InProgress;

                selectedOrder.SaveChanges();
            }

        }

        private void SetOrderCompleted(object sender, EventArgs e)
        {
            if (executingOrdersListView.SelectedItems.Count > 0)
            {
                Order selectedOrder = Order.GetInProgressOrders().Where(o => o.Id.ToString() == executingOrdersListView.SelectedItems[0].SubItems[0].Text).First();

                selectedOrder.Status = OrderStatuses.Сompleted;

                selectedOrder.SaveChanges();

                Driver currentDriver = OnlineDrivers.GetOnlineDrivers().Where(d => d.Id.ToString() == executingOrdersListView.SelectedItems[0].SubItems[3].Text).First();

                if (currentDriver != null)
                {
                    currentDriver.Status = DriverStatuses.Free;
                    currentDriver.SaveChanges();
                }

            }

        }

        private void takeСallBtn_Click(object sender, EventArgs e)
        {
            if (incomingCallsListBox.SelectedItem != null)
            {
                Call call = new Call(incomingCallsListBox.SelectedItem.ToString(), CurrentUser);
                incomingCallsListBox.Items.Remove(incomingCallsListBox.SelectedItem);
                new TakeCallForm(call).Show();

            }

        }

        private void LoadData()
        {
            foreach (Order order in Order.GetFreeOrders())
            {
                freeOrdersListView.Items.Add(new ListViewItem(new string[] { order.Id.ToString(), order.AddressFrom, order.AddressTo }));
            }

            if(Order.GetAcceptedOrders().Count >0)
                foreach (Order order in Order.GetAcceptedOrders())
                {
                    acceptedOrdersListView.Items.Add(new ListViewItem(new string[] { order.Id.ToString(), order.AddressFrom, order.AddressTo,order.Driver.Id.ToString() }));
                }

            foreach (Order order in Order.GetInProgressOrders())
            {
                executingOrdersListView.Items.Add(new ListViewItem(new string[] { order.Id.ToString(), order.AddressFrom, order.AddressTo, order.Driver.Id.ToString() }));
            }

            foreach (Driver driver in OnlineDrivers.GetOnlineDrivers())
            {
                driversListView.Items.Add(new ListViewItem(new string[] { driver.Id.ToString(),driver.Status.ToString(),driver.Model }));
            }

        }

        private void ClearData()
        {
            freeOrdersListView.Items.Clear();

            acceptedOrdersListView.Items.Clear();

            executingOrdersListView.Items.Clear();

            driversListView.Items.Clear();
        }

        private void refreshData_Click(object sender, EventArgs e)
        {
            ClearData();

            LoadData();
        }
    }
}
