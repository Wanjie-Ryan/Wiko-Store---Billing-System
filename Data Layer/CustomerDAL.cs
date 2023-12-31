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
    internal class CustomerDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;


        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);


            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM tbl_dealer_customer";

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

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

        public bool Insert(CustomerLogics cl)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);


            try
            {
                string sql = "INSERT INTO tbl_dealer_customer (id, type, name) VALUES () ";

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
