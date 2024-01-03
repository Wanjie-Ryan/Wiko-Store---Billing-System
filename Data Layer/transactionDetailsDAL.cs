using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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


            }
            catch(Exception ex)
            {

            }
            finally
            {

            }

            return isSuccess;
        }
    }
}
