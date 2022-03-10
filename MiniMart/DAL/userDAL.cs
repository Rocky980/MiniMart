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
	class userDAL
	{
		static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

		#region Select Data from Database
		public DataTable Select()
		{
			//static method database sanga connect garna lai
			SqlConnection conn = new SqlConnection(myconnstrng);
			//database bata aako data lai hold garna ko lagi
			DataTable dt = new DataTable();
			try
			{
				String sql = "SELECT * FROM users";
				//For execting command
				SqlCommand cmd = new SqlCommand(sql,conn);
				//for getting data from database
				SqlDataAdapter adapter = new SqlDataAdapter(cmd);
				//db connection open
				conn.Open();
				//fill data in datatable
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

		#region Insert Data in Database
		public bool Insert(userBLL u)
		{
			bool isSuccess = false;
			SqlConnection conn = new SqlConnection(myconnstrng);

			try
			{
				String sql = "INSERT INTO users (first_name,last_name,email,username,password,contact,address,gender,user_type,added_date,added_by) VALUES (@first_name,@last_name,@email,@username,@password,@contact,@address,@gender,@user_type,@added_date,@added_by)";
				SqlCommand cmd = new SqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@first_name",u.first_name);
				cmd.Parameters.AddWithValue("@last_name", u.last_name);
				cmd.Parameters.AddWithValue("@email", u.email);
				cmd.Parameters.AddWithValue("@username", u.username);
				cmd.Parameters.AddWithValue("@password", u.password);
				cmd.Parameters.AddWithValue("@contact", u.contact);
				cmd.Parameters.AddWithValue("@address", u.address);
				cmd.Parameters.AddWithValue("@gender", u.gender);
				cmd.Parameters.AddWithValue("@user_type", u.user_type);
				cmd.Parameters.AddWithValue("@added_date", u.added_date);
				cmd.Parameters.AddWithValue("@added_by", u.added_by);

				conn.Open();

				int rows = cmd.ExecuteNonQuery();
				
				if (rows > 0)
				{
					//query sucessfull
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

		#region Update Data in Database
		public bool Update(userBLL u)
		{
			bool isSuccess = false;
			SqlConnection conn = new SqlConnection(myconnstrng);
			try
			{
			


					string sql = "UPDATE users SET first_name=@first_name,last_name=@last_name,email=@email,username=@username,password=@password,contact=@contact,address=@address,gender=@gender,user_type=@user_type,added_date=@added_date,added_by=@added_by WHERE id=@id";
					SqlCommand cmd = new SqlCommand(sql, conn);
					cmd.Parameters.AddWithValue("@first_name", u.first_name);
					cmd.Parameters.AddWithValue("@last_name", u.last_name);
					cmd.Parameters.AddWithValue("@email", u.email);
					cmd.Parameters.AddWithValue("@username", u.username);
					cmd.Parameters.AddWithValue("@password", u.password);
					cmd.Parameters.AddWithValue("@contact", u.contact);
					cmd.Parameters.AddWithValue("@address", u.address);
					cmd.Parameters.AddWithValue("@gender", u.gender);
					cmd.Parameters.AddWithValue("@user_type", u.user_type);
					cmd.Parameters.AddWithValue("@added_date", u.added_date);
					cmd.Parameters.AddWithValue("@added_by", u.added_by);

					cmd.Parameters.AddWithValue("@id", u.id);
					conn.Open();
					int rows = cmd.ExecuteNonQuery();
					if (rows > 0)
					{
						//query succesful
						isSuccess = true;
					}

					else
					{
						//query failed
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

		#region Delete data from database

		public bool Delete(userBLL u)
		{

			bool isSuccess = false;
			SqlConnection conn = new SqlConnection(myconnstrng);
			try
			{
				string sql = "DELETE from users where id=@id";
				//sql command using sql and conn
				SqlCommand cmd = new SqlCommand(sql, conn);
				//need to create a parameter to pass value in ID
				cmd.Parameters.AddWithValue("@id",u.id);
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
		#endregion

		#region Search user from database using keywords
		public DataTable Search(string keywords)
		{
			//static method database sanga connect garna lai
			SqlConnection conn = new SqlConnection(myconnstrng);
			//database bata aako data lai hold garna ko lagi
			DataTable dt = new DataTable();
			try
			{
				String sql = "SELECT * FROM users WHERE id LIKE '%"+keywords+"%' OR first_name LIKE '%"+keywords+"%' OR last_name LIKE '%"+keywords+"%' OR username LIKE '%"+keywords+"%'";
				//For execting command
				SqlCommand cmd = new SqlCommand(sql, conn);
				//for getting data from database
				SqlDataAdapter adapter = new SqlDataAdapter(cmd);
				//db connection open
				conn.Open();
				//fill data in datatable
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

		#region Getting User ID from Username

		public userBLL GetIDFromUsername (string username)
		{

			userBLL u = new userBLL();
			SqlConnection conn = new SqlConnection(myconnstrng);
			DataTable dt = new DataTable();

			try
			{
				string sql = "SELECT * FROM users WHERE username='" + username + "'";
				SqlDataAdapter adapter = new SqlDataAdapter(sql,conn);
				conn.Open();

				adapter.Fill(dt);

				if(dt.Rows.Count > 0) {

					u.id = int.Parse(dt.Rows[0]["id"].ToString());
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
			return u;
		}
		#endregion


		#region Checking phone numbers before adding new user
		public bool CheckPhoneNumber(string phone)
		{

			userBLL u = new userBLL();
			SqlConnection conn = new SqlConnection(myconnstrng);
			DataTable dt = new DataTable();
			bool isSuccess = true;
		

			try
			{
				string sql = "SELECT * FROM users WHERE contact='" + phone + "'";
				SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
				conn.Open();

				adapter.Fill(dt);
				int phone_length = phone.Length;

				

				if (dt.Rows.Count > 0 || phone_length<9 || phone_length>11)
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


		#region CHECK EMAIL ADDRESS


           public bool check_email(string emailToValidate)
		{
			return System.Text.RegularExpressions.Regex.IsMatch(emailToValidate,
				@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
		}
		#endregion


		#region FULL VALIDATION OF USER FORM

		public string completeValidation(string firstname,string lastname,string username,string email,string password,string phone,string address,string gender,string usertype)
		{
			string result= "";

			if (firstname == "")
			{
				result="First Name is Empty";
				
			}
			
			else if ((lastname).All(char.IsDigit) == true)
			{
				result="First Name cannot contain numbers";


			}
			else if ((phone).All(char.IsDigit) == false)
			{
				result = "Invalid Phone Number";
			
			}
			else if ((lastname).All(char.IsDigit) == true)
			{
				result = "Last Name cannot contain numbers";
				

			}
			else if (lastname == "")
			{
				result = "Last Name is Empty";
				

			}
			else if (email == "")
			{
				result = "Email is Empty";


			}
			else if (password == "")
			{
				result = "Password is Empty";

			}
			else if (password.Length < 5)
			{
				result = "Password Length should be greater than 5 ";


			}
			else if (username == "")
			{
				result = "Username is Empty";

			}
			else if (address == "")
			{
				result = "Address is Empty.";
			
			}

		
			else if (gender == "")
			{
				result = "Please Select the Gender";
			
			}
			else if (usertype == "")
			{
				result = "Please select the User Type";
				
			}
			else
			{
				result = "FINE";
			}
			return result;
		}

		#endregion
	}
}
