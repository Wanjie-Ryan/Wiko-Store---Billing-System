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
    internal class transactionDetailsDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;


        public bool InsertTransDetails(transactionDetailsLogics tl)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "INSERT INTO tbl_transaction_detail (product_id, rate, quantity, total, dea_cust_id, added_date, added_by) VALUES (@product_id, @rate, @quantity, @total, @dea_cust_id, @added_date, @added_by)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@product_id", tl.product_id);
                cmd.Parameters.AddWithValue("@rate", tl.rate);
                cmd.Parameters.AddWithValue("@quantity", tl.quantity);
                cmd.Parameters.AddWithValue("@total", tl.total);
                cmd.Parameters.AddWithValue("@dea_cust_id", tl.dea_cust_id);
                cmd.Parameters.AddWithValue("@added_date", tl.added_date);
                cmd.Parameters.AddWithValue("@added_by", tl.added_by);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
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
