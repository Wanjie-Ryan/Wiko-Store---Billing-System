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
    internal class transactionDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;


        public bool InsertTransactions(transactionLogics t, out int transactionID)

        {

            // the transactionID will be used to store the id of the inserted transaction

            bool isSuccess = false;

            // set the out transactionID value to -1

            transactionID = -1;

            SqlConnection conn = new SqlConnection(myconnstrng);


            try
            {
                string sql = "INSERT INTO tbl_transactions (type, dea_cust_id, total, transaction_date, tax, discount, added_by) VALUES (@type, @dea_cust_id, @total, @transaction_date, @tax, @discount, @added_by)";


                SqlCommand cmd = new SqlCommand(sql, conn);

                // parameterized queries such as these, help in preventing sql injections, by treating user input as data rather than executable code.
                cmd.Parameters.AddWithValue("@type", t.type);
                cmd.Parameters.AddWithValue("@dea_cust_id", t.dea_cust_id);
                cmd.Parameters.AddWithValue("@total", t.total);
                cmd.Parameters.AddWithValue("@transaction_date", t.transaction_date);
                cmd.Parameters.AddWithValue("@tax", t.tax);
                cmd.Parameters.AddWithValue("@discount", t.discount);
                cmd.Parameters.AddWithValue("@added_by", t.added_by);

                conn.Open();

                // for this, we will use the Execute Scalar, instead of the Execute Non Query
                // The difference between Execute Non query and Execute Scalar is that, Execute Non Query returns the number of rows affected after executing the query, while /n
                // Execute Scalar returns the first column of the first row in the result set by the query. The first row of the first column, in this case is the ID of the inserted transaction.

                object o = cmd.ExecuteScalar();

                // if the query is executed successfully, then the value will not be null, else it will be null

                if (0 != null)
                {
                    // query executed successfully
                    // the transactionID is then assigned a parsed value of the ID that is returned from the query

                    transactionID = int.Parse(o.ToString());
                    isSuccess = true;
                }
                else
                {
                    // failed to execute query
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
