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
    public partial class EditConnection : Form
    {
        public EditConnection()
        {
            InitializeComponent();
        }

        private void EditConnection_Load(object sender, EventArgs e)
        {
            conStrTxt.Text = DBConnection.ConnectionString;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            DBConnection.ConnectionString = conStrTxt.Text;

            Close();
        }
    }
}
