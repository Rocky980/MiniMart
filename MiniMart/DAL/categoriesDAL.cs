using MiniMart.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniMart.DAL
{
	class categoriesDAL
	{
		//static string method for db connection string

		static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

		#region select method

		public DataTable Select()
		{
			//creating connection to database
			SqlConnection conn = new SqlConnection(myconnstrng);

			DataTable dt = new DataTable();

			try
			{
				string sql = "SELECT * FROM categories";
				//sql command to execute query
				SqlCommand cmd = new SqlCommand(sql,conn);
				//adapter to get data from database
				SqlDataAdapter adapter = new SqlDataAdapter(cmd);
				//openn db connection
				conn.Open();
				//pas data from adapter to datatable dt
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
		#endregion

		#region Insert New Category

		public bool Insert(categoriesBLL c)
		{
			bool isSuccess = false;

			//connect to DB
			SqlConnection conn = new SqlConnection(myconnstrng);
			try
			{
				string sql = "INSERT INTO categories (title,description,added_date,added_by) VALUES(@title,@description,@added_date,@added_by)";

				//creating sql command to passs values in our query
				SqlCommand cmd = new SqlCommand(sql,conn);
				//passing values through paramater
				cmd.Parameters.AddWithValue("@title", c.title);
				cmd.Parameters.AddWithValue("@description", c.description);
				cmd.Parameters.AddWithValue("@added_date", c.added_date);
				cmd.Parameters.AddWithValue("@added_by", c.added_by);

				conn.Open();
				int rows = cmd.ExecuteNonQuery(); 
				//if query sucessfully executed rows will be > 0 else < 0
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
		#endregion

		#region Update method
		public bool Update (categoriesBLL c)
		{
			bool isSuccess = false;

			SqlConnection conn = new SqlConnection(myconnstrng);
			try
			{
				string sql = "UPDATE categories SET title=@title,description=@description,added_date=@added_date,added_by=@added_by WHERE id=@id";

				//sql command to pass value to sql query
				SqlCommand cmd = new SqlCommand(sql,conn);

				//passin values using cmd
				cmd.Parameters.AddWithValue("@title",c.title);
				cmd.Parameters.AddWithValue("@description", c.description);
				cmd.Parameters.AddWithValue("@added_date", c.added_date);
				cmd.Parameters.AddWithValue("@added_by", c.added_by);
				cmd.Parameters.AddWithValue("@id", c.id);

				conn.Open();
				int rows=cmd.ExecuteNonQuery();
				if (rows > 0)
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
		#endregion

		#region Delete Category Method
		public bool Delete(categoriesBLL c)
		{
			bool isSuccess = false;

			SqlConnection conn = new SqlConnection(myconnstrng);
			try
			{
				string sql = "DELETE FROM categories WHERE id=@id";

				SqlCommand cmd = new SqlCommand(sql, conn);

				//passing value using CMD
				cmd.Parameters.AddWithValue("@id", c.id);
				conn.Open();
				int rows = cmd.ExecuteNonQuery();
				if (rows > 0)
				{
					isSuccess = true;
				}
				else
					isSuccess = false;
				{

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
		#endregion

		#region Method for Search

		public DataTable Search(string keywords)
		{
			SqlConnection conn = new SqlConnection(myconnstrng);

			DataTable dt = new DataTable();

			try
			{
				string sql = "SELECT * FROM categories WHERE id LIKE '%" + keywords + "%' OR title LIKE '%" + keywords + "%' OR description LIKE '%" + keywords + "%'";
				//sql command to execute query
				SqlCommand cmd = new SqlCommand(sql, conn);
				//getting data from database

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
		#endregion
	}
}
