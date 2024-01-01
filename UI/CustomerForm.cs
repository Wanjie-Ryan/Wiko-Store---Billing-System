﻿using System;
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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void lblProductID_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        CustomerLogics cl = new CustomerLogics();
        CustomerDAL cdal = new CustomerDAL();
        UserDAL uDal = new UserDAL();

        public void Clear()
        {
            txtID.Text = "";
            cmbType.Text = "";
            txtName.Text = "";
            txtEmail.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            cl.type = cmbType.Text;
            cl.name = txtName.Text;
            cl.email = txtEmail.Text;
            cl.contact = txtContact.Text;
            cl.address = txtAddress.Text;
            cl.added_date = DateTime.Now;

            string loggedUser = LoginForm.loggedIn;
            UserLogics usr = uDal.GetIDFromUsername(loggedUser);

            cl.added_by = usr.id;

            bool Success = cdal.Insert(cl);

            if(Success == true)
            {

                // to render the usertype dynamically in the messagebox
                string usertype = cl.type.ToLower();
                MessageBox.Show("");
                Clear();

                DataTable dt = cdal.Select();
                dgvDealCust.DataSource = dt;
            }
            else
            {

            }






        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
