using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wiko_Store.Logics;

namespace Wiko_Store.Data_Layer
{
    internal class LoginDAL
    {
        //static strong to connect to my database

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        public bool LoginCheck(LoginLogics1 l)
        {

            //creating a boolean variable and set its value to false and return it.
            bool isSuccess = false;

            //connecting to the database
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //sql query to check login
                string sql = "SELECT * FROM users WHERE username = @username AND password =@password AND user_type= @user_type";

                //creating sql command to pass value
                SqlCommand cmd = new SqlCommand(sql, conn);

                //passing values through parameters
                cmd.Parameters.AddWithValue("@username", l.username);
                cmd.Parameters.AddWithValue("@password", l.password);
                cmd.Parameters.AddWithValue("@user_type", l.userType);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();

            }




            return isSuccess;

        }
    }
}
