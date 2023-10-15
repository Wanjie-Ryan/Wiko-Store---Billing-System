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
    public partial class FormUsers : Form
    {
        public FormUsers()
        {
            InitializeComponent();
        }

        UserLogics userlogics = new UserLogics();
        UserDAL userDAL = new UserDAL();

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // getting data from textboxes

            userlogics.first_name = txtFirstName.Text;
            userlogics.last_name = txtLastName.Text;
            userlogics.email = txtEmail.Text;
            userlogics.username = txtUsername.Text;
            userlogics.contact = txtContact.Text;
            userlogics.address = txtAddress.Text;
            userlogics.gender = cmbGender.Text;
            userlogics.user_type = cmbUserType.Text;
            userlogics.added_date = DateTime.Now;
            userlogics.added_by = 1;
            userlogics.password = txtPwd.Text;
        }
    }
}
