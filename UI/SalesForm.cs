using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wiko_Store.Data_Layer;
using Wiko_Store.Logics;

namespace Wiko_Store.UI
{
    public partial class SalesForm : Form
    {
        public SalesForm()
        {
            InitializeComponent();
        }

        CustomerDAL cdal = new CustomerDAL();
        productsDAL pdal = new productsDAL();
        //CustomerLogics cl = new CustomerLogics();   
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            // get the transactionType value from the formuserdashboard

            string type = FormUserDashboard.transactionType;

            // set the value on lblTop

            lblTop.Text = type;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // get the keyword from the textbox

            string keyword = txtSearch.Text;

            if(keyword == "")
            {
                //if the search box is empty, render all the the other textboxes empty too.

                txtName.Text = "";
                txtEmail.Text = "";
                txtContact.Text = "";
                txtAddress.Text = "";
                return;
            }

            // write the code to get the details and set the value on textboxes

            CustomerLogics cl = cdal.SearchDealerCustomer(keyword);

            // set the value in the cl to the textboxes

            txtName.Text = cl.name;
            txtEmail.Text = cl.email;
            txtContact.Text = cl.contact;
            txtAddress.Text = cl.address;



        }

        private void txtProdSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;

            if(keyword == "")
            {
                txtSearch.Text = "";
                txtName.Text = "";
                txtRate.Text = "";
                txtQuantity.Text = "";
                return;
            }


        }
    }
}
