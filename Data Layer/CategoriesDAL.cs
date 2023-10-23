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
    internal class CategoriesDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM tbl_categories";

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

        public bool InsertCategory(CategoryLogics l)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "INSERT INTO tbl_categories (title, description, added_date, added_by) VALUES (@title, @description, @added_date, @added_by) ";

                SqlCommand cmd = new SqlCommand(sql,conn);

                cmd.Parameters.AddWithValue("@title", l.title);
                cmd.Parameters.AddWithValue("@description", l.description);
                cmd.Parameters.AddWithValue("@added_date", l.added_date);
                cmd.Parameters.AddWithValue("@added_by", l.added_by);


                conn.Open();
                int rows =  cmd.ExecuteNonQuery();
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

        public Boolean Update(CategoryLogics l)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "UPDATE tbl_categories SET title = @title, description = @description, added_date = @added_date, added_by = @added_by WHERE id =@id";

                SqlCommand cmd = new SqlCommand(sql,conn);

                cmd.Parameters.AddWithValue("@title", l.title);
                cmd.Parameters.AddWithValue("@description", l.description);
                cmd.Parameters.AddWithValue("@added_date", l.added_date);
                cmd.Parameters.AddWithValue("@added_by", l.added_by);
                cmd.Parameters.AddWithValue("@id", l.id);

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

        public bool Delete (CategoryLogics l)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "DELETE FROM tbl_categories WHERE  id=@id";

                SqlCommand cmd = new SqlCommand(sql,conn);

                cmd.Parameters.AddWithValue("@id", l.id);

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
            catch(Exception ex )
            {
                MessageBox.Show (ex.Message);

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;

        }
    }
}
