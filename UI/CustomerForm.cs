using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

                MessageBox.Show($"{usertype} was added successfully", "Successful Insertion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();

                DataTable dt = cdal.Select();
                dgvDealCust.DataSource = dt;
            }
            else
            {
                String usertype = cl.type.ToLower();

                MessageBox.Show($"Failed to add {usertype}", "Insertion failure", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }






        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            DataTable dt = cdal.Select();
            dgvDealCust.DataSource = dt;
        }

        private void dgvDealCust_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rows = e.RowIndex;
            txtID.Text = dgvDealCust.Rows[rows].Cells[0].Value.ToString();
            cmbType.Text = dgvDealCust.Rows[rows].Cells[1].Value.ToString();
            txtName.Text = dgvDealCust.Rows[rows].Cells[2].Value.ToString();
            txtEmail.Text = dgvDealCust.Rows[rows].Cells[3].Value.ToString();
            txtContact.Text = dgvDealCust.Rows[rows].Cells[4].Value.ToString();
            txtAddress.Text = dgvDealCust.Rows[rows].Cells[5].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (dgvDealCust.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer or dealer from the list before attempting to update.", "No customer or dealer was selected", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            // get the values from the UI

            int tempId;

            if (!int.TryParse(txtID.Text, out tempId))
            {
                MessageBox.Show("Invalid Customer or Dealer ID. Please select a valid ID.", "Invalid ID", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            // convert the string id to integer using the int.parse

            cl.id = tempId;
            cl.type = cmbType.Text;
            cl.name = txtName.Text;
            cl.email = txtEmail.Text;
            cl.contact = txtContact.Text;
            cl.address = txtAddress.Text;

            string loggeduser = LoginForm.loggedIn;
            UserLogics usr = uDal.GetIDFromUsername(loggeduser);

            cl.added_by = usr.id;

            bool success = cdal.Update(cl);

            if(success == true)
            {
                string usertype = cl.type.ToString();

                MessageBox.Show($"{usertype} was updated successfully", "Successful Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                DataTable dt = cdal.Select();
                dgvDealCust.DataSource = dt;

            }
            else
            {
                String usertype = cl.type.ToLower();

                MessageBox.Show($"Failed to add {usertype}", "Insertion failure", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDealCust.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer or dealer from the list before attempting to delete.", "No customer or dealer was selected", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            // get the values from the UI

            int tempId;

            if (!int.TryParse(txtID.Text, out tempId))
            {
                MessageBox.Show("Invalid Customer or Dealer ID. Please select a valid ID.", "Invalid ID", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }

            cl.id = tempId;
            cl.type = cmbType.Text;

            bool success = cdal.Delete(cl);

            if(success == true)
            {
                string usertype = cl.type.ToLower();

                MessageBox.Show($"{usertype} was deleted successfully", "Deletion successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear();

                DataTable dt = cdal.Select();
                dgvDealCust.DataSource = dt;    
            }
            else
            {
                MessageBox.Show("Failed to delete customer or dealer", "Deletion failure", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }





        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;

            if(keywords != null)
            {
                DataTable dt = cdal.Search(keywords);
                dgvDealCust.DataSource = dt;

            }
            else
            {
                DataTable dt = cdal.Select();
                dgvDealCust.DataSource = dt;
            }
        }
    }
}
