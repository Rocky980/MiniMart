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
	class productsDAL
	{
		static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

		#region Select method for product module
		public DataTable Select()
		{
			//connec to db
			SqlConnection conn = new SqlConnection(myconnstrng);
			//datatable to hold data from DB
			DataTable dt = new DataTable();
			try
			{
				string sql = "SELECT * FROM products";
				//creating sql command to execute query
				SqlCommand cmd = new SqlCommand(sql, conn);
				//sql adapter to hold the value from db temporarily
				SqlDataAdapter adapter = new SqlDataAdapter(cmd);
				conn.Open();
				adapter.Fill(dt);
			}
			catch (Exception ex)
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

		#region Insert method for product
		public bool Insert(productsBLL p)
		{
			bool isSuccess = false;

			//sql connection for DB
			SqlConnection conn = new SqlConnection(myconnstrng);
			try
			{
				string sql = "INSERT INTO products (name,category,description,rate,qty,added_date,added_by,selling_price) VALUES (@name,@category,@description,@rate,@qty,@added_date,@added_by,@selling_price)";
				//sql command to pass values into query
				SqlCommand cmd = new SqlCommand(sql, conn);
				//passing values through parameters
				cmd.Parameters.AddWithValue("@name", p.name);
				cmd.Parameters.AddWithValue("@category", p.category);
				cmd.Parameters.AddWithValue("@description", p.description);
				cmd.Parameters.AddWithValue("@rate", p.rate);
				cmd.Parameters.AddWithValue("@qty", p.qty);
				cmd.Parameters.AddWithValue("@added_date", p.added_date);
				cmd.Parameters.AddWithValue("@added_by", p.added_by);
				cmd.Parameters.AddWithValue("@selling_price", p.selling_price);

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

		#region Update method
		public bool Update(productsBLL p)
		{
			bool isSuccess = false;

			SqlConnection conn = new SqlConnection(myconnstrng);
			try
			{
				String sql = "UPDATE products SET name=@name,category=@category,description=@description,rate=@rate,added_date=@added_date,added_by=@added_by,qty=@qty,selling_price=@selling_price WHERE id=@id";
				//sql command to pass value to query
				SqlCommand cmd = new SqlCommand(sql, conn);
				//passing values using paramaters and cmd
				cmd.Parameters.AddWithValue("@name", p.name);
				cmd.Parameters.AddWithValue("@category", p.category);
				cmd.Parameters.AddWithValue("@description", p.description);
				cmd.Parameters.AddWithValue("@rate", p.rate);
				cmd.Parameters.AddWithValue("@added_date", p.added_date);
				cmd.Parameters.AddWithValue("@added_by", p.added_by);
				cmd.Parameters.AddWithValue("@id", p.id);
				cmd.Parameters.AddWithValue("@qty", p.qty);
				cmd.Parameters.AddWithValue("@selling_price", p.selling_price);

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

		#region Delete product
		public bool Delete(productsBLL p)
		{
			bool isSuccess = false;
			SqlConnection conn = new SqlConnection(myconnstrng);
			try
			{
				string sql = "DELETE FROM products WHERE id=@id";
				//sql command to pass value
				SqlCommand cmd = new SqlCommand(sql, conn);
				//passing values
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

		#region Search product
		public DataTable Search(string keywords)
		{

			//SQL connection for DB connection
			SqlConnection conn = new SqlConnection(myconnstrng);
			//creating datatable to hold value from DB
			DataTable dt = new DataTable();
			try
			{
				string sql = "SELECT * FROM products WHERE id LIKE '%" + keywords + "%' OR name LIKE '%" + keywords + "%' OR category LIKE '%" + keywords + "%'";
				//sql command to execute query
				SqlCommand cmd = new SqlCommand(sql, conn);
				//sql data adapter to hold the data from database temporarily
				SqlDataAdapter adapter = new SqlDataAdapter(cmd);
				conn.Open();
				adapter.Fill(dt);
			}
			catch (Exception ex)
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

		#region METHOD TO SEARCH PRODUCT IN TRANSACTION MODULE
		public productsBLL GetProductsForTransaction(string keyword)
		{
			productsBLL p = new productsBLL();
			SqlConnection conn = new SqlConnection(myconnstrng);
			//datatable to store data temporarily
			DataTable dt = new DataTable();
			try
			{
				string sql = "SELECT name, rate, qty,selling_price FROM products WHERE id LIKE '%" + keyword + "%' OR name LIKE '%" + keyword + "%'";
				//sql data adapter to execcute query
				SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
				conn.Open();
				//passing values from adapter to dt
				adapter.Fill(dt);
				if (dt.Rows.Count > 0)
				{
					p.name = dt.Rows[0]["name"].ToString();
					p.rate = decimal.Parse(dt.Rows[0]["rate"].ToString());
					p.qty = decimal.Parse(dt.Rows[0]["qty"].ToString());
					p.selling_price = decimal.Parse(dt.Rows[0]["selling_price"].ToString());
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
			return p;
		}
		#endregion

		#region METHOD TO GET PRODUCT ID BASED ON PRODUCT NAME
		public productsBLL GetProductIDFromName(string ProductName)
		{
			productsBLL p = new productsBLL();
			SqlConnection conn = new SqlConnection(myconnstrng);
			//datatable to hold data temporarily
			DataTable dt = new DataTable();
			try
			{
				//sql query to get ID based on name
				string sql = "SELECT id,rate FROM products WHERE name='" + ProductName + "'";
				//creating sql data adapter to execute the query
				SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
				conn.Open();
				//passing value from adapter to datatable
				adapter.Fill(dt);
				if (dt.Rows.Count > 0)
				{
					//pass the value from dt to deaCustBLL dc
					p.id = int.Parse(dt.Rows[0]["id"].ToString());
					p.rate =decimal.Parse(dt.Rows[0]["rate"].ToString());
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
			return p;
		}
		#endregion

		#region METHOD TO GET CURRENT QUANTITY FROM DATABASE BASED ON PRODUCT ID
		public decimal GetProductQty(int ProductID)
		{
			SqlConnection conn = new SqlConnection(myconnstrng);
			decimal qty = 0;
			DataTable dt = new DataTable();
			try
			{
				string sql = "SELECT qty FROM products WHERE id=" + ProductID;
				SqlCommand cmd = new SqlCommand(sql, conn);
				//sql data adapter to execcute the query
				SqlDataAdapter adapter = new SqlDataAdapter(cmd);
				conn.Open();

				//pass the value from adapter to datatable
				adapter.Fill(dt);
				//lets check if the datatable has value or not
				if (dt.Rows.Count > 0)
				{
					qty = decimal.Parse(dt.Rows[0]["qty"].ToString());
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
			return qty;
		}

		#endregion

		#region METHOD TO UPDATE QUANTITY
		public bool UpdateQuantity(int ProductID, decimal Qty)
		{
			bool success = false;
			SqlConnection conn = new SqlConnection(myconnstrng);
			try
			{
				string sql = "UPDATE products SET qty=@qty WHERE id=@id";
				//creating sql command to pass value to query
				SqlCommand cmd = new SqlCommand(sql, conn);
				//passing the value through parameters
				cmd.Parameters.AddWithValue("@qty", Qty);
				cmd.Parameters.AddWithValue("@id", ProductID);

				conn.Open();
				int rows = cmd.ExecuteNonQuery();
				if (rows > 0)
				{
					success = true;
				}
				else
				{
					success = false;
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
			return success;
		}
		#endregion

		#region METHOD TO INCREASE PRODUCT
		public bool IncreaseProduct(int ProductID, decimal IncreaseQty)
		{
			bool success = false;
			SqlConnection conn = new SqlConnection(myconnstrng);
			try
			{
				//getting current qty in database
				decimal currentQty = GetProductQty(ProductID);
				//increase current quantity by the qty purchased from dealer
				decimal NewQty = currentQty + IncreaseQty;
				success = UpdateQuantity(ProductID, NewQty);

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				conn.Close();
			}
			return success;
		}
		#endregion

		#region METHOD TO DECREASE PRODUCT
		public bool DecreaseProduct(int ProductID, decimal SoldQty)
		{
			bool success = false;
			SqlConnection conn = new SqlConnection(myconnstrng);
			try
			{
				decimal currentQty = GetProductQty(ProductID);
				decimal NewQty = currentQty - SoldQty;

				success = UpdateQuantity(ProductID, NewQty);

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				conn.Close();
			}
			return success;
		}
		#endregion


		#region METHOD TO DISPLAY PRODUCTS BASED ON CATEGORIES

		public DataTable DisplayProductByCategory(string category)
		{
			SqlConnection conn = new SqlConnection(myconnstrng);
			DataTable dt = new DataTable();
			try
			{
				string sql = "SELECT * FROM products WHERE category='" + category + "'";
				SqlCommand cmd = new SqlCommand(sql, conn);
				SqlDataAdapter adapter = new SqlDataAdapter(cmd);
				conn.Open();
				adapter.Fill(dt);
			}
			catch (Exception ex)
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
