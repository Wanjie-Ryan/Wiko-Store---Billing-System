﻿using System;
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

                string sql = "UPDATE tbl_products SET name = @name, category = @category, description = @description, rate = @rate, added_date = @added_date, added_by = @added_by WHERE id = @id  ";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@name", p.name);
                cmd.Parameters.AddWithValue("@category", p.category);
                cmd.Parameters.AddWithValue("@description", p.description);
                cmd.Parameters.AddWithValue("@rate", p.rate);
                //cmd.Parameters.AddWithValue("@quantity", p.quantity);
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

        public DataTable Search(string keywords)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            // datatable holds the values fetched from the database
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM tbl_products WHERE id LIKE '%" + keywords + "%' OR name LIKE '%" + keywords + "%' OR category LIKE '%" + keywords + "%'";

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

        // searching for a product in the transaction module
        // the name ProductsLogic is the method name
        public ProductsLogic SearchProductTransaction(string keyword)
        {
            ProductsLogic pl = new ProductsLogic();
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();


            try
            {
                string sql = "SELECT name, rate, quantity FROM tbl_products WHERE id LIKE '%" +keyword+ "%' OR name LIKE '%" +keyword+ "%'";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

                conn.Open();

                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    pl.name = dt.Rows[0]["name"].ToString();
                    pl.rate = decimal.Parse(dt.Rows[0]["rate"].ToString());
                    pl.quantity = decimal.Parse(dt.Rows[0]["quantity"].ToString());
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

            return pl;
        }

        public ProductsLogic GetIDByProductName(string prodName)
        {
            ProductsLogic pl = new ProductsLogic();
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();


            try
            {
                string sql = "SELECT name from tbl_products WHERE name = '%" +prodName+ "%' ";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

                conn.Open();

                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    pl.id = int.Parse(dt.Rows[0]["id"].ToString());
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

            return pl;
        }

        // METHOD TO GET CURRENT QUANTITY FROM THE DB BASED ON PRODUCTID

        public decimal GetProductQty(int productId)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            // create a decimal varibale and set it to 0

            decimal qty = 0;

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT quantity FROM tbl_products WHERE id= '%" + productId + "%' ";

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();

                adapter.Fill(dt);

                // check if the dataTable has values or not

                if(dt.Rows.Count > 0)
                {
                    qty = decimal.Parse(dt.Rows[0]["quantity"].ToString());
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


            return qty;

        }

        // METHOD TO UPDATE THE QUANTITY IN THE DATABASE

        public bool UpdateQuantity(int productId, decimal qty)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "UPDATE tbl_products SET quantity = '%" +qty + "%' WHERE id = '%" +productId + "%'";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@quantity", qty);
                cmd.Parameters.AddWithValue("@id", productId);

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

        // METHOD TO INCREASE PRODUCT

        public bool IncreaseProduct (int productId, decimal Increaseqty)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                // get the current quantity from the DB based on the id of the product

                decimal currentQty = GetProductQty(productId);

                // increase the current quantity by the qty purchased from the dealer

                decimal newQty = currentQty +Increaseqty;

                // update the product quantity

                isSuccess = UpdateQuantity(productId, newQty);

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

        // METHOD TO DECREASE PRODUCT QUANTITY

        public bool DecreaseProduct(int productId, decimal qty)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);


            try
            {
                decimal currentqty = GetProductQty(productId);

                decimal newQty = currentqty - qty;

                isSuccess = UpdateQuantity(productId, newQty);
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
