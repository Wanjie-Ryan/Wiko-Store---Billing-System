using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wiko_Store.Data_Layer
{
    internal class productsDAL
    {
        //creating a static string method for DB connection

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //fetching data from database 

        public DataTable Select()
        {
            // creating a database connection

            SqlConnection conn = new SqlConnection(myconnstrng);
            

            // datatable to hold the data from database
            DataTable dt = new DataTable();

            try
            {
                // writing sql query to select all products from the database

                string sql = "SELECT * FROM tbl_products";

                // creating sql command to execute the query

                SqlCommand cmd = new SqlCommand(sql, conn);

                //SqlDataAdapter to hold data from the DB temporarily

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //open database connection

                conn.Open();

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

    }
}
