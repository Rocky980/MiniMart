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
	class loginDAL
	{
		//static string to connect to DB
		static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;


		public bool loginCheck(loginBLL l)
		{
			bool isSuccess = false;
			//connecting to db
			SqlConnection conn = new SqlConnection(myconnstrng);
			try
			{
				//SQL query to checck Login
				string sql = "SELECT * FROM users WHERE username=@username AND password=@password AND user_type=@user_type";

				//we need to pass value to this query using SQL COMMAND
				//creating sql COMMAND

				SqlCommand cmd = new SqlCommand(sql,conn);

				//pass value through the parameters using command

				cmd.Parameters.AddWithValue("@username", l.username);
				cmd.Parameters.AddWithValue("@password", l.password);
				cmd.Parameters.AddWithValue("@user_type", l.user_type);

				//we need to create SQL DATA ADAPTER to store the data from database temporarily
				SqlDataAdapter adapter = new SqlDataAdapter(cmd);

				//we will create data table to hold the data from SQL DATA ADAPTER temporarily
				DataTable dt = new DataTable();


				//we need to fill the data table using SQL data adapter

				adapter.Fill(dt);

				//query to get data and store the data in adapter first, then fill datatable ...if datatable has value no. of rows will be>0(successful login)..so check

				//checkin the rows in datatable

				if (dt.Rows.Count > 0)
				{
					//login success
					isSuccess = true;
				}
				else
				{
					isSuccess = false;
					//login failed
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
