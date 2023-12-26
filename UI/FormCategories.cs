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
            txtTitle.Text = "";
            txtDesc.Text = "";

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


        }

        private void dgvCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }
    }
}