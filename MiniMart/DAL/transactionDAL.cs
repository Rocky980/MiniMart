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
	class transactionDAL
	{
		static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

		#region Insert Transaction Method

		public string Insert_Transaction(transactionsBLL t, out int transactionID)
		{
			string success="";

			transactionID = -1;
			SqlConnection conn = new SqlConnection(myconnstrng);

			try
			{
				string sql = "INSERT INTO transactions(type, dea_cust_id, grandTotal, transaction_date, tax, discount, added_by) VALUES(@type, @dea_cust_id, @grandTotal, @transaction_date, @tax, @discount, @added_by); SELECT @@IDENTITY;";
				//creating sql command to pass value in sql query
				SqlCommand cmd = new SqlCommand(sql, conn);
				//passing the value to sql query using cmd
				cmd.Parameters.AddWithValue("@type",t.type);
				cmd.Parameters.AddWithValue("@dea_cust_id", t.dea_cust_id);
				cmd.Parameters.AddWithValue("@grandTotal", t.grandTotal);
				cmd.Parameters.AddWithValue("@transaction_date", t.transaction_date);
				cmd.Parameters.AddWithValue("@tax", t.tax);
				cmd.Parameters.AddWithValue("@discount", t.discount);
				cmd.Parameters.AddWithValue("@added_by", t.added_by);
				//cmd.Parameters.AddWithValue("@profit", t.profit); 
				//because profit ta jaile update garera haleko xa,,insert garera haleko xaena maile

				conn.Open();


				/*
				 
				MySqlCommand dbcmd = _conn.CreateCommand();
				dbcmd.CommandText = sqlCommandString;
				dbcmd.ExecuteNonQuery();
				long imageId = dbcmd.LastInsertedId;

				*/


				



				//yaha ExecuteScalar use garnu parxa..It returns the value of first column of first row in the result set by query//and for that we need tp create object 0
				//ExecuteNonQuery ONLY returns the number of rows affected after executing query
				success = cmd.ExecuteScalar().ToString();
				//if it is executed successfully its value will not be null..else it will be null

				/*
				if (o != null)
				{
					transactionID = int.Parse(o.ToString());
					isSuccess = true;
				}
				else
				{
					isSuccess = false;
				}

				*/
			}
			catch(Exception ex)
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

		#region METHOD TO DISPLAY ALL THE TRANSACTION

		public DataTable DisplayAllTransactions()
		{
			SqlConnection conn = new SqlConnection(myconnstrng);
			//create datatble to hold data from DB temporarily
			DataTable dt = new DataTable();
			try
			{
				string sql = "SELECT * FROM transactions order by id desc";
				//sql commadn to execute query
				SqlCommand cmd = new SqlCommand(sql, conn);
				//sql dataadapter to hold data from database
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

		#region METHOD TO DISPALY TRANSACTION BASED ON DATE
		public DataTable DisplayAllTransactionsByDate(DateTime date,string type)
		{
			SqlConnection conn = new SqlConnection(myconnstrng);
			//create datatble to hold data from DB temporarily
			DataTable dt = new DataTable();
			try
			{
				string sql = "SELECT * FROM transactions WHERE transaction_date >=@FromDate";
				//sql commadn to execute query
				if (type != "")
				{
					sql = sql + " and type='"+type+"'";
				}
				sql = sql + " order by id desc";
				 SqlCommand cmd = new SqlCommand(sql, conn);
				//sql dataadapter to hold data from database

				cmd.Parameters.Add("@FromDate", SqlDbType.DateTime).Value = date;
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
		#region Display all transaction By type
		public DataTable DisplayTransactionByType(string type)
		{
			SqlConnection conn = new SqlConnection(myconnstrng);
			DataTable dt = new DataTable();
			try
			{
				string sql = "SELECT * FROM transactions WHERE type='" + type + "' order by id desc";
				//sql command to execute query
				SqlCommand cmd = new SqlCommand(sql, conn);
				//data adapter to hold the data from DB
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

		#region METHOD TO INSERT PROFIT IN Transactions Table

		public bool InsertProfit(transactionsBLL t)
		{
			bool isSuccess = false;

			SqlConnection conn = new SqlConnection(myconnstrng);
			try
			{
				String sql = "UPDATE transactions SET profit=@profit WHERE id=@id";
				//sql command to pass value to query
				SqlCommand cmd = new SqlCommand(sql, conn);
				//passing values using paramaters and cmd
				cmd.Parameters.AddWithValue("@profit", t.profit);
				cmd.Parameters.AddWithValue("@id", t.id);


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

		#region SEARCH TRANSACTION BY ID OR USER NAME
		public DataTable SearchTransactionByName_ID(string keywords)
		{
			SqlConnection conn = new SqlConnection(myconnstrng);
			//create datatble to hold data from DB temporarily
			DataTable dt = new DataTable();
			DataTable dt2 = new DataTable();
			try
			{
		
				int cus_dea_id=0;
				string sql = "SELECT * FROM dea_cust WHERE name LIKE '%" + keywords + "%' OR contact LIKE '%" + keywords + "%' ";
				SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
				conn.Open();

				adapter.Fill(dt);

				if (dt.Rows.Count > 0)
				{

					cus_dea_id = int.Parse(dt.Rows[0]["id"].ToString());
				}



				
				sql = "SELECT * FROM transactions WHERE id LIKE '%" + keywords + "%' OR dea_cust_id LIKE '%" + cus_dea_id + "%'";
				//sql commadn to execute query
		
				//sql = sql + " order by id desc";
				SqlCommand cmd = new SqlCommand(sql, conn);
				//sql dataadapter to hold data from database


				SqlDataAdapter adapter2 = new SqlDataAdapter(cmd);
				adapter2.Fill(dt2);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				conn.Close();
			}
			return dt2;
		}
		#endregion
	}
}
