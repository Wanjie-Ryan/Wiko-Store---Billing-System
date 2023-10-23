using System;
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
    public partial class FormCategories : Form
    {
        public FormCategories()
        {
            InitializeComponent();
        }
        
        CategoryLogics cl = new CategoryLogics();
        CategoriesDAL cdal =  new CategoriesDAL();
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // getting data from the textboxes

            cl.title = txtTitle.Text;
            cl.description = txtDesc.Text;

            bool isSuccess = cdal.InsertCategory(cl);

            if(isSuccess == true)
            {
                MessageBox.Show("New Category Successfully Inserted");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to add new category");
            }   



        }

        public void Clear()
        {
            txtTitle.Text = "";
            txtDesc.Text = "";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
