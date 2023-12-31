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
    internal class CustomerDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;


        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);


            DataTable dt = new DataTable();

            try
            {


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
