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

        // updating data in the database

        public bool Insert(ProductsLogic p)
        {
            // creating boolean variable and set default value to false
            bool isSuccess = false;

            // SQL connection for the database

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {

                string sql = "INSERT INTO tbl_products (name, category, description, rate, quantity, added_date, added_by) VALUES (@name, @category, @description, @rate, @quantity, @added_date, @added_by)  ";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@name", p.name);
                cmd.Parameters.AddWithValue("@category", p.category);
                cmd.Parameters.AddWithValue("@description", p.description);
                cmd.Parameters.AddWithValue("@rate", p.rate);
                cmd.Parameters.AddWithValue("@quantity", p.quantity);
                cmd.Parameters.AddWithValue("@added_date", p.added_date);
                cmd.Parameters.AddWithValue("@added_by", p.added_by);

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

        public bool Update(ProductsLogic p)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);


            try
            {

                string sql = "UPDATE tbl_products SET name = @name, category = @category, description = @description, rate = @rate, quantity = @quantity, added_date = @added_date, added_by = @added_by WHERE id = @id  ";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@name", p.name);
                cmd.Parameters.AddWithValue("@category", p.category);
                cmd.Parameters.AddWithValue("@description", p.description);
                cmd.Parameters.AddWithValue("@rate", p.rate);
                cmd.Parameters.AddWithValue("@quantity", p.quantity);
                cmd.Parameters.AddWithValue("@added_date", p.added_date);
                cmd.Parameters.AddWithValue("@added_by", p.added_by);
                cmd.Parameters.AddWithValue("@id", p.id);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if(rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                
            }



            return isSuccess;
        }

        public bool Delete(ProductsLogic p)
        {
            bool isSuccess = true;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try 
            {
                string sql = "DELETE FROM tbl_products WHERE id = @id";

                SqlCommand cmd = new SqlCommand(sql,conn);

                cmd.Parameters.AddWithValue("@id", p.id);

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
