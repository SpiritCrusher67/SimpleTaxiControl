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
    public partial class AppointDriver : Form
    {
        Order currentOrder;

        public AppointDriver(Order order)
        {
            InitializeComponent();

            currentOrder = order;
        }

        private void AppointDriver_Load(object sender, EventArgs e)
        {
            idLabel.Text += currentOrder.Id;

            fromLabel.Text += currentOrder.AddressFrom;

            toLabel.Text += currentOrder.AddressTo;

            driverComboBox.Items.AddRange(OnlineDrivers.GetFreeDrivers().Select(d => d.Id.ToString()).ToArray());

        }

        private void appointDriverBtn_Click(object sender, EventArgs e)
        {
            if (driverComboBox.SelectedIndex != -1)
            {
                Driver currentDriver = OnlineDrivers.GetOnlineDrivers().Where(d => d.Id.ToString() == driverComboBox.SelectedItem.ToString()).First();

                currentOrder.Driver = currentDriver;

                currentDriver.Status = DriverStatuses.NotFree;

                currentDriver.SaveChanges();

                currentOrder.Status = OrderStatuses.Accepted;

                currentOrder.SaveChanges();

                currentOrder.SaveDriver();

                Close();
            }
        }

    }
}
