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

        private void FormProducts_Load(object sender, EventArgs e)
        {
            // creating dataTable to hold categories from DB

            DataTable catDT = cdal.Select();
            cmbCategory.DataSource = catDT;

            // specify the display member and value member for combobox

            cmbCategory.DisplayMember = "title";
            cmbCategory.ValueMember = "title";
        }
    }
}
