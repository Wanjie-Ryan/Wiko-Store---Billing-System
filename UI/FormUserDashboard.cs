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

        private void FormUserDashboard_Load(object sender, EventArgs e)
        {
            lblLoggedInUser.Text = LoginForm.loggedIn;
        }

        private void dealerAndCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerForm cust = new CustomerForm();
            cust.Show();
        }
    }
}
