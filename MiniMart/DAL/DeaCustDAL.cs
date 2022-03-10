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
	class DeaCustDAL
	{

		static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

		#region Select method for dealer and customer

		public DataTable Select()
		{
			SqlConnection conn = new SqlConnection(myconnstrng);
			DataTable dt = new DataTable();
			try
			{
				string sql = "SELECT * FROM dea_cust";
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
		#endregion

		#region Insert method to add details of dealer and customers
		public bool Insert(DeaCustBLL dc)
		{
			SqlConnection conn = new SqlConnection(myconnstrng);
			
			bool isSuccess = false;
			try
			{
				string sql = "INSERT INTO dea_cust(type,name,email,contact,address,added_date,added_by) VALUES(@type,@name,@email,@contact,@address,@added_date,@added_by)";
				SqlCommand cmd = new SqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@type", dc.type);
				cmd.Parameters.AddWithValue("@name", dc.name);
				cmd.Parameters.AddWithValue("@email", dc.email);
				cmd.Parameters.AddWithValue("@contact", dc.contact);
				cmd.Parameters.AddWithValue("@address", dc.address);
				cmd.Parameters.AddWithValue("@added_date", dc.added_date);
				cmd.Parameters.AddWithValue("@added_by", dc.added_by);

				conn.Open();
				int rows=cmd.ExecuteNonQuery();
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

		#region UPDATE method for dealer and customer

		public bool Update(DeaCustBLL dc)
		{
			SqlConnection conn = new SqlConnection(myconnstrng);
			bool isSuccess = false;

			try
			{
				string sql = "UPDATE dea_cust SET type=@type, name=@name,email=@email, contact=@contact, address=@address, added_date=@added_date, added_by=@added_by WHERE id=@id";
				SqlCommand cmd = new SqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@type",dc.type);
				cmd.Parameters.AddWithValue("@name", dc.name);
				cmd.Parameters.AddWithValue("@email", dc.email);
				cmd.Parameters.AddWithValue("@contact", dc.contact);
				cmd.Parameters.AddWithValue("@address", dc.address);
				cmd.Parameters.AddWithValue("@added_date", dc.added_date);
				cmd.Parameters.AddWithValue("@added_by", dc.added_by);
				cmd.Parameters.AddWithValue("@id", dc.id);

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

		#endregion

		#region Delete for DeaCust
		public bool Delete(DeaCustBLL dc)
		{
			SqlConnection conn = new SqlConnection(myconnstrng);
			bool isSuccess = false;

			try
			{
				string sql = "DELETE FROM dea_cust WHERE id=@id";
				SqlCommand cmd = new SqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@id", dc.id);
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
		#endregion

		#region Search method for dea and cust
		public DataTable Search(string keyword)
		{
			SqlConnection conn = new SqlConnection(myconnstrng);
			DataTable dt = new DataTable();
			try
			{
				string sql = "SELECT * FROM dea_cust WHERE id LIKE '%"+keyword+ "%' OR type LIKE '%"+keyword+"%' OR name LIKE '%"+keyword+"%'";
				//command to execcute query
				SqlCommand cmd = new SqlCommand(sql,conn);
				//adapter to store data from DB temporarily
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

		#region Method to search dealer or customer for transaction module
        public DeaCustBLL SearchDealerCustomerForTransaction(string keyword)
		{
			//object for DeaCustBLL
			DeaCustBLL dc = new DeaCustBLL();
			SqlConnection conn = new SqlConnection(myconnstrng);
			DataTable dt = new DataTable();

			try
			{
				string sql = "SELECT name,email,contact,address from dea_cust WHERE id like '%" + keyword + "%' OR name LIKE '%" + keyword + "%' OR contact LIKE '%" + keyword + "%'";
				//sql adapter to execute the query
				SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
				conn.Open();
				adapter.Fill(dt);
				//if we have values on dt we need to save it on dealerCust
				if (dt.Rows.Count > 0)
				{
					dc.name = dt.Rows[0]["name"].ToString();
					dc.email = dt.Rows[0]["email"].ToString();
					dc.contact = dt.Rows[0]["contact"].ToString();
					dc.address = dt.Rows[0]["address"].ToString();

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
			return dc;
		}

		#endregion

		#region MEthod to get ID of delaer or customer based on Name
		public DeaCustBLL GetDeaCustIDFromName(string Name)
		{
			DeaCustBLL dc = new DeaCustBLL();
			SqlConnection conn = new SqlConnection(myconnstrng);
			//datatable to hold data temporarily
			DataTable dt = new DataTable();
			try
			{
				//sql query to get ID based on name
				string sql = "SELECT id FROM dea_cust WHERE name='" + Name + "'";
				//creating sql data adapter to execute the query
				SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
				conn.Open();
				//passing value from adapter to datatable
				adapter.Fill(dt);
				if(dt.Rows.Count > 0)
				{
					//pass the value from dt to deaCustBLL dc
					dc.id = int.Parse(dt.Rows[0]["id"].ToString());
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
			return dc;
		}
		#endregion

		#region Check Phone Number of Customer Before Inserting
		public bool CheckPhoneNumber(string phone)
		{

			userBLL u = new userBLL();
			SqlConnection conn = new SqlConnection(myconnstrng);
			DataTable dt = new DataTable();
			bool isSuccess = true;

			try
			{
				string sql = "SELECT * FROM dea_cust WHERE contact='" + phone + "'";
				SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
				conn.Open();

				adapter.Fill(dt);

				if (dt.Rows.Count > 0)
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
	}
}
