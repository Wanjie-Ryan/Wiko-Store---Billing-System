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
    public partial class FormCategories : Form
    {
        public FormCategories()
        {
            InitializeComponent();
        }
        
        CategoryLogics cl = new CategoryLogics();
        CategoriesDAL cdal =  new CategoriesDAL();
        UserDAL uDal = new UserDAL();
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Clear()
        {
            txtCategoryID.Text = "";
            txtTitle.Text = "";
            txtDesc.Text = "";
            txtSearch.Text = "";

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // getting data from the textboxes

            cl.title = txtTitle.Text;
            cl.description = txtDesc.Text;
            cl.added_date = DateTime.Now;

            //getting id of logged in user

            string loggedUser = LoginForm.loggedIn;

            UserLogics usr = uDal.GetIDFromUsername(loggedUser);



            bool isSuccess = cdal.InsertCategory(cl);

            if(isSuccess == true)
            {
                MessageBox.Show("New Category Successfully Inserted");
                Clear();

                //Refreshing the datagrid view

                DataTable dt = cdal.Select();
                dgvCategories.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to add new category");
            }   

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // check if a row has been selected in the datagrid view

            if(dgvCategories.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a category from the list before attempting to delete.", "No category was selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // getting the values from the textboxes

            cl.id = int.Parse(txtCategoryID.Text);
            cl.title = txtTitle.Text;
            cl.description = txtDesc.Text;
            cl.added_date = DateTime.Now;

            //getting id of logged in user

            string loggedUser = LoginForm.loggedIn;

            UserLogics usr = uDal.GetIDFromUsername(loggedUser);

            cl.added_by = usr.id;

            // creating boolean variable to check if the category is updated or not

            bool isSuccess = cdal.Update(cl);
            
            if(isSuccess == true)
            {
                MessageBox.Show("Category Successfully Updated");
                Clear();

                // refreshing the datagrid view

                DataTable dt = cdal.Select();
                dgvCategories.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to update category");
            }


        }

        private void dgvCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormCategories_Load(object sender, EventArgs e)
        {
            // to display all the added categories in the datagrid view

            DataTable dt = cdal.Select();
            dgvCategories.DataSource = dt;


        }

        private void dgvCategories_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // finding the row index of the row that has been clicked

            int RowIndex = e.RowIndex;

            txtCategoryID.Text = dgvCategories.Rows[RowIndex].Cells[0].Value.ToString();
            txtTitle.Text = dgvCategories.Rows[RowIndex].Cells[1].Value.ToString();
            txtDesc.Text = dgvCategories.Rows[RowIndex].Cells[2].Value.ToString();


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            // check if a row has been selected in the datagrid view

            if (dgvCategories.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a category from the list before attempting to delete.", "No Category Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // Exit the method if no row is selected
            }


            // getting the id of the category from which we want to delete

            cl.id = int.Parse(txtCategoryID.Text);

            // creating boolean variable to check if the category is deleted or not

            bool isSuccess = cdal.Delete(cl);

            if(isSuccess == true)
            {
                MessageBox.Show("Category was deleted successfully");
                Clear();

                // refreshing the datagrid view

                DataTable dt = cdal.Select();

                dgvCategories.DataSource = dt;

            }
            else
            {
                MessageBox.Show("Failed to delete category");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //get the keywords

            string keywords = txtSearch.Text;

            // filter the categories based on the keywords
             
            if(keywords != null)
            {
                // use search method to display the categories

                DataTable dt = cdal.Search(keywords);
                dgvCategories.DataSource = dt;
            }
            else
            {
                // use the select method to render the normal data

                DataTable dt = cdal.Select();
                dgvCategories.DataSource = dt;
            }
        }
    }
}
