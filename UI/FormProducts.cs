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
    public partial class FormProducts : Form
    {
        public FormProducts()
        {
            InitializeComponent();
        }

        private void lblTop_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblProductID_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            // code to hide this form when the x icon is clicked

            this.Hide();
        }

        CategoriesDAL cdal =  new CategoriesDAL();
        productsDAL prodal =  new productsDAL();
        ProductsLogic p =  new ProductsLogic();
        UserDAL userdal = new UserDAL();

        private void FormProducts_Load(object sender, EventArgs e)
        {
            // creating dataTable to hold categories from DB

            DataTable catDT = cdal.Select();
            cmbCategory.DataSource = catDT;

            // specify the display member and value member for combobox

            cmbCategory.DisplayMember = "title";
            cmbCategory.ValueMember = "title";

            DataTable pdat =  prodal.Select();
            dgvProducts.DataSource = pdat;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            p.name = txtName.Text;
            p.category = cmbCategory.Text;
            p.description = txtDesc.Text;
            p.rate = decimal.Parse(txtRate.Text);
            p.quantity = 0;
            p.added_date = DateTime.Now;

            // getting the username of logged in user

            string loggeduser = LoginForm.loggedIn;
            UserLogics usr = userdal.GetIDFromUsername(loggeduser);

            p.added_by = usr.id;

            //create boolean variable to check if the product is added successfully or not

            bool success = prodal.Insert(p);

            if(success == true)
            {
                MessageBox.Show("Products Inserted Successfully");
                Clear();

                DataTable dt = new DataTable();
                dgvProducts.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to add new Product");
            }


        }

        public void Clear()
        {
            txtID.Text = "";
            txtDesc.Text = "";
            txtRate.Text = "";
            txtName.Text = "";
            txtSearch.Text = "";
            cmbCategory.Text = "";
        }

        private void dgvProducts_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            txtID.Text = dgvProducts.Rows[RowIndex].Cells[0].Value.ToString();
            txtName.Text = dgvProducts.Rows[RowIndex].Cells[1].Value.ToString();
            cmbCategory.Text = dgvProducts.Rows[RowIndex].Cells[2].Value.ToString();
            txtDesc.Text = dgvProducts.Rows[RowIndex].Cells[3].Value.ToString();
            txtRate.Text = dgvProducts.Rows[RowIndex].Cells[4].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a Product from the list before attempting to update.", "No Product was selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // get the values from the UI

            int tempId;

            if (!int.TryParse(txtID.Text, out tempId))
            {
                MessageBox.Show("Invalid Product ID. Please select a valid ID.", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            p.id = tempId;
            p.name = txtName.Text;
            p.category = cmbCategory.Text;
            p.description = txtDesc.Text;
            p.rate = decimal.Parse(txtRate.Text);
            p.added_date = DateTime.Now;

            // getting the username of logged in user

            string loggeduser = LoginForm.loggedIn;
            UserLogics usr = userdal.GetIDFromUsername(loggeduser);

            p.added_by = usr.id;

            bool success = prodal.Update(p);

            if(success == true)
            {
                MessageBox.Show("Product Updated Successfully", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();

                DataTable dt = prodal.Select();
                dgvProducts.DataSource = dt;

            }
            else
            {
                MessageBox.Show("Product failed to update, try Again!", "Failure to update", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a Product from the list before attempting to delete.", "No Product was selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //p.id = int.Parse(txtID.Text);

            int tempId;

            if (!int.TryParse(txtID.Text, out tempId))
            {
                MessageBox.Show("Invalid Product ID. Please select a valid ID.", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            p.id = tempId;


            bool success = prodal.Delete(p);

            if(success == true)
            {
                MessageBox.Show("Product was Deleted Successfully", "Delete successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();

                DataTable dt = prodal.Select();
                dgvProducts.DataSource = dt;

            }
            else
            {
                MessageBox.Show("Product failed to Delete, try Again!", "Failure to Delete", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);


            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;

            if(keywords != null)
            {
                DataTable dt = prodal.Search(keywords);
                dgvProducts.DataSource = dt;

            }
            else
            {
                DataTable dt = prodal.Select();
                dgvProducts.DataSource = dt;
            }
        }
    }
}
