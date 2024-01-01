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
                string sql = "INSERT INTO tbl_dealer_customer (type, name, email, contact, address, added_date, added_by ) VALUES (@type, @name, @email, @contact, @address, @added_date, @added_by ) ";


                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@type", cl.type);
                cmd.Parameters.AddWithValue("@name", cl.name);
                cmd.Parameters.AddWithValue("@email", cl.email);
                cmd.Parameters.AddWithValue("@contact", cl.contact);
                cmd.Parameters.AddWithValue("@address", cl.address);
                cmd.Parameters.AddWithValue("@added_date", cl.added_date);
                cmd.Parameters.AddWithValue("@added_by", cl.added_by);

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

        public bool Update(CustomerLogics cl)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "UPDATE tbl_dealer_customer SET type = @type, name=@name, email=@email, contact=@contact, address= @address, added_date = @added_date, added_by = @added_by WHERE id =@id ";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@type", cl.type);
                cmd.Parameters.AddWithValue("@name", cl.name);
                cmd.Parameters.AddWithValue("@email", cl.email);
                cmd.Parameters.AddWithValue("@contact", cl.contact);
                cmd.Parameters.AddWithValue("@address", cl.address);
                cmd.Parameters.AddWithValue("@added_date", cl.added_date);
                cmd.Parameters.AddWithValue("@added_by", cl.added_by);
                cmd.Parameters.AddWithValue("@id", cl.id);

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

        public bool Delete(CustomerLogics cl)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "DELETE FROM tbl_dealer_customer WHERE id =@id";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", cl.id);

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
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "SELECT * FROM tbl_dealer_customer WHERE id LIKE '%" +keywords+ "%' OR type LIKE '%" +keywords+ "%' OR name LIKE '%" +keywords+ "%' OR email LIKE '%" +keywords+ "%'";

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


    }
}
