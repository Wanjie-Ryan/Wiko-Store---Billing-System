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
    public partial class formAdmin : Form
    {
        public formAdmin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblLoggedInUser.Text = LoginForm.loggedIn;
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUsers Usersform = new FormUsers();
            Usersform.Show();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCategories categoriesform = new FormCategories();
            categoriesform.Show();

        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProducts products = new FormProducts();
            products.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dealerAndCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerForm cust = new CustomerForm();

            cust.Show();
        }
    }
}
