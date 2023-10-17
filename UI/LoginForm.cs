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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        LoginLogics1 l = new LoginLogics1();
        LoginDAL loginDAL = new LoginDAL();
        static string loggedIn;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PicBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            l.username = txtUsername.Text.Trim();
            l.password = txtPwd.Text.Trim();
            l.userType = cmbUserType.Text.Trim();

            //checking the login credentials

            bool isSuccess = loginDAL.LoginCheck(l);

            if(isSuccess == true)
            {

                MessageBox.Show("Login Successful");
                loggedIn = l.username;
                //opening forms based on user types
                switch (l.userType)
                {
                    case "Admin":
                        {
                            //display the admin dashboard
                            formAdmin admin = new formAdmin();
                            admin.Show();
                            //when thw admin form is shown, hide the login form using the command below
                            this.Hide();

                        }
                        break;

                    case "User":
                        {
                            //display the user dashboard
                            FormUserDashboard user = new FormUserDashboard();
                            user.Show();
                            this.Hide();


                        }
                        break;

                    default:
                        {
                            MessageBox.Show("Inavlid User Type");
                        }
                        break;

                }
            }
            else
            {
                MessageBox.Show("Inavlid Credentials");
            }



        }
    }
}
