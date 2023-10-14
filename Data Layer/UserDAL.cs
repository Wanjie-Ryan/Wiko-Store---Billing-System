using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wiko_Store.Logics;

namespace Wiko_Store.Data_Layer
{
    internal class UserDAL
    {

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //region Select Data from Database

        public DataTable Select()
        {
            //static method to connect database
            SqlConnection conn = new SqlConnection(myconnstrng);
            //holds data from the database
            DataTable dt = new DataTable();

            try
            {
                //sql query to fetch data from the database
                string sql = "SELECT * FROM tbl_users";
                //for executing command
                SqlCommand cmd = new SqlCommand(sql, conn);
                //getting data from database
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                // database connection open
                conn.Open();
                //fill data in our data table
                adapter.Fill(dt);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();

            }
            return dt;

        }

        //inserting data to the database

        public bool Insert(UserLogics c)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "INSERT INTO tbl_users(first_name, last_name,email,username,password,contact,address,gender,user_type,added_date,added_by) VALUES (@first_name, @last_name,email, @username, @password, @contact, @address, @gender, @user_type, @added_date, @added_by)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@first_name", c.first_name);
                cmd.Parameters.AddWithValue("@last_name", c.last_name);
                cmd.Parameters.AddWithValue("@email", c.email);   
                cmd.Parameters.AddWithValue("@username", c.username);
                cmd.Parameters.AddWithValue("@password", c.password);
                cmd.Parameters.AddWithValue("@first_name", c.first_name);
                cmd.Parameters.AddWithValue("@first_name", c.first_name);
                cmd.Parameters.AddWithValue("@first_name", c.first_name);
                cmd.Parameters.AddWithValue("@first_name", c.first_name);






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
