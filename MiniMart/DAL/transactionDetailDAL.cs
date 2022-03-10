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
	class transactionDetailDAL
	{
		static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
		#region INSERT method for Transaction Detail

		public bool InsertTransactionDetail(transactionDetailBLL td)
		{
			bool isSuccess = false;

			SqlConnection conn = new SqlConnection(myconnstrng);
			try
			{
				string sql = "INSERT INTO transaction_detail(product_id, rate, qty, total, dea_cust_id, added_date, added_by,transaction_id) VALUES(@product_id, @rate, @qty, @total, @dea_cust_id, @added_date, @added_by,@transaction_id)";
				SqlCommand cmd = new SqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@product_id",td.product_id);
				cmd.Parameters.AddWithValue("@rate", td.rate);
				cmd.Parameters.AddWithValue("@qty", td.qty);
				cmd.Parameters.AddWithValue("@total", td.total);
				cmd.Parameters.AddWithValue("@dea_cust_id", td.dea_cust_id);
				cmd.Parameters.AddWithValue("@added_date", td.added_date);
				cmd.Parameters.AddWithValue("@added_by", td.added_by);
				cmd.Parameters.AddWithValue("@transaction_id", td.transaction_id);

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
		#endregion


		#region GET Transaction Detail From Transaction ID

		public DataTable getTransactionDetailFromTransactionID(int transaction_id)
		{

			SqlConnection conn = new SqlConnection(myconnstrng);
			DataTable dt = new DataTable();
			try
			{
				string sql = "SELECT * FROM transaction_detail WHERE transaction_id='" + transaction_id + "'";
				//sql command to execute query
				SqlCommand cmd = new SqlCommand(sql, conn);
				//data adapter to hold the data from DB
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
