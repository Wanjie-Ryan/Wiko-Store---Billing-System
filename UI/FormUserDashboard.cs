using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wiko_Store.UI;

namespace Wiko_Store
{
    public partial class FormUserDashboard : Form
    {
        public FormUserDashboard()
        {
            InitializeComponent();
        }

        // set a public static method to specify whether the form is purchase or sales
        public static string transactionType;
        private void FormUserDashboard_Load(object sender, EventArgs e)
        {
            lblLoggedInUser.Text = LoginForm.loggedIn;
        }

        private void dealerAndCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerForm cust = new CustomerForm();
            cust.Show();
        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // set value on transactionType static method

            transactionType = "Purchase";
            SalesForm sf = new SalesForm();
            sf.Show();

        }

        private void salesFormsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            transactionType = "sales";
            SalesForm sales = new SalesForm();
            sales.Show();

        }
    }
}
