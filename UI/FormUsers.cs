using System;
using System.Data;
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

        //UserLogics userlogics = new UserLogics();
        private UserLogics c = new UserLogics();

        private UserDAL userDAL = new UserDAL();

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

            // c.id = int.Parse(txtUserID.Text);
            c.first_name = txtFirstName.Text;
            c.last_name = txtLastName.Text;
            c.email = txtEmail.Text;
            c.username = txtUsername.Text;
            c.contact = txtContact.Text;
            c.address = txtAddress.Text;
            c.gender = cmbGender.Text;
            c.user_type = cmbUserType.Text;
            c.added_date = DateTime.Now;
            c.added_by = 1;
            c.password = txtPwd.Text;

            //inserting data to the database using the userDAL class

            bool success = userDAL.Insert(c);

            //if the data is successfully inserted then the value of success will be true else it will be false

            if (success == true)
            {
                MessageBox.Show("User has been created successFully");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to add new user");
            }

            DataTable dt = userDAL.Select();

            dgvUsers.DataSource = dt;
        }

        public void Clear()
        {
            txtUserID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtUsername.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            cmbGender.Text = "";
            cmbUserType.Text = "";
            txtPwd.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            DataTable dt = userDAL.Select();

            dgvUsers.DataSource = dt;
        }

        private void dgvUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // get the index of the particular row.....
            int rowIndex = e.RowIndex;
            txtUserID.Text = dgvUsers.Rows[rowIndex].Cells[0].Value.ToString();
            txtFirstName.Text = dgvUsers.Rows[rowIndex].Cells[1].Value.ToString();
            txtLastName.Text = dgvUsers.Rows[rowIndex].Cells[2].Value.ToString();
            txtEmail.Text = dgvUsers.Rows[rowIndex].Cells[3].Value.ToString();
            txtUsername.Text = dgvUsers.Rows[rowIndex].Cells[4].Value.ToString();
            txtContact.Text = dgvUsers.Rows[rowIndex].Cells[5].Value.ToString();
            txtAddress.Text = dgvUsers.Rows[rowIndex].Cells[6].Value.ToString();
            cmbGender.Text = dgvUsers.Rows[rowIndex].Cells[7].Value.ToString();
            cmbUserType.Text = dgvUsers.Rows[rowIndex].Cells[8].Value.ToString();
            txtPwd.Text = dgvUsers.Rows[rowIndex].Cells[9].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c.first_name = txtFirstName.Text;
            c.last_name = txtLastName.Text;
            c.email = txtEmail.Text;
            c.username = txtUsername.Text;
            c.contact = txtContact.Text;
            c.address = txtAddress.Text;
            c.gender = cmbGender.Text;
            c.user_type = cmbUserType.Text;
            c.added_date = DateTime.Now;
            c.added_by = 1;
            c.password = txtPwd.Text;
        }
    }
}