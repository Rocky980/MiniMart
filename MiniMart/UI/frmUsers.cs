using MiniMart.BLL;
using MiniMart.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace MiniMart.UI
{
	public partial class frmUsers : Form
	{
		public frmUsers()
		{
			InitializeComponent();
		}
		userBLL u = new userBLL();
		userDAL dal = new userDAL();
		 
		private void pictureBoxClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{

			string sSourceData;
			byte[] tmpSource;
			byte[] tmpHash;

			sSourceData = txtPassword.Text;
			tmpSource = ASCIIEncoding.ASCII.GetBytes(sSourceData);
			tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);

			bool check_error = false;
			bool email_validation = dal.check_email(txtEmail.Text);

			if (email_validation == false)
			{
				MessageBox.Show("Invalid Email Address");
			}

			//getting user name of logged in user because he is the one to insert new user so his ID should be there in added by field
			string loggedUser = frmLogin.loggedIn;    //now we need his id from username

			//getting data from UI
			u.first_name = txtFirstName.Text;
			u.last_name = txtLastName.Text;
			u.email = txtEmail.Text;
			u.username = txtUsername.Text;

			u.password = Convert.ToBase64String(tmpHash);

			//MessageBox.Show(tmpHash);
			//MessageBox.Show(u.password);
			//MessageBox.Show(Convert.ToBase64String(tmpHash));





			u.contact = txtContact.Text;
			u.address = txtAddress.Text;
			u.gender = cmbGender.Text;
			u.user_type = cmbUserType.Text;
			u.added_date = DateTime.Now;


			if(u.username=="" || u.last_name == "" || u.password == "" || u.first_name == "" || u.address == "" || u.user_type == "" || u.gender == "")
			{
				check_error = true;
			}


			//to get user ID of who added

			userBLL usr = dal.GetIDFromUsername(loggedUser);
			u.added_by = usr.id;


			//now we have all the data in the setter in the business logic layer 
			//inserting data into database..for this we should use data access layer  i.e. Data access layer object

			bool phoneCheck_success = dal.CheckPhoneNumber(txtContact.Text);
			bool success=false;

			string validation_check = dal.completeValidation(u.first_name,u.last_name,u.username,u.email,u.password,u.contact,u.address,u.gender,u.gender);
			if (validation_check == "FINE")
			{
				if (phoneCheck_success == true && email_validation == true && check_error == false && email_validation == true)
				{
					success = dal.Insert(u);
				}
			}
		
			else
			{
				MessageBox.Show(validation_check);
			}
		
			//if data is successfully inserted then value of success will be true else it will be false

			if(success == true)
			{
				//data inserted succesfully
				MessageBox.Show("User successfully created");
				clear();
			}
			else
			{
				//failed to insert
				MessageBox.Show("Failed to add User");
			}


			//Refresh data grid view..so that bhkhr naya user add gaepar teslai thau ko thau tei dekhauna sakam
			//for this we need to create data table...data table is a temporary table to store data from database

			DataTable dt = dal.Select();
			dgvUsers.DataSource = dt; //this will refresh data grid view when ever we add a user
		}

		private void frmUsers_Load(object sender, EventArgs e)
		{
			DataTable dt = dal.Select();
			dgvUsers.DataSource = dt; //this will refresh data grid view when ever we add a user
		}

		private void clear()
		{
			txtUserID.Text = "";
			txtFirstName.Text = "";
			txtEmail.Text = "";
			txtLastName.Text = "";
			txtUsername.Text = "";
			txtPassword.Text = "";
			txtContact.Text = "";
			txtAddress.Text = "";
			cmbGender.Text = "";
			cmbUserType.Text = "";
		}

		private void dgvUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			//get the index of particular row being clicked..it is called RowIndex . It starts from zero impppppppppppppp..cells count from 0
			int rowIndex = e.RowIndex;
			txtUserID.Text = dgvUsers.Rows[rowIndex].Cells[0].Value.ToString();
			txtFirstName.Text = dgvUsers.Rows[rowIndex].Cells[1].Value.ToString();
			txtLastName.Text = dgvUsers.Rows[rowIndex].Cells[2].Value.ToString();
			txtEmail.Text = dgvUsers.Rows[rowIndex].Cells[3].Value.ToString();
			txtUsername.Text = dgvUsers.Rows[rowIndex].Cells[4].Value.ToString();
			txtPassword.Text = dgvUsers.Rows[rowIndex].Cells[5].Value.ToString();
			txtContact.Text = dgvUsers.Rows[rowIndex].Cells[6].Value.ToString();
			txtAddress.Text = dgvUsers.Rows[rowIndex].Cells[7].Value.ToString();
			cmbGender.Text = dgvUsers.Rows[rowIndex].Cells[8].Value.ToString();
			cmbUserType.Text = dgvUsers.Rows[rowIndex].Cells[9].Value.ToString();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			//for updating get the values from user UI
			//we just converted the data into string and placed it on the boxes while we clicked on rows..now when updating the data must again be converted into
			//its respective data type before updating.. example id is int..so before updating change it into int



			string sSourceData;
			byte[] tmpSource;
			byte[] tmpHash;

			sSourceData = txtPassword.Text;
			//Create a byte array from source data.
			tmpSource = ASCIIEncoding.ASCII.GetBytes(sSourceData);
			tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);


			u.id = Convert.ToInt32(txtUserID.Text);
			u.first_name = txtFirstName.Text;
			u.last_name = txtLastName.Text;
			u.email = txtEmail.Text;
			u.username = txtUsername.Text;
			//u.password = txtPassword.Text;

			u.password = Convert.ToBase64String(tmpHash);
			u.contact = txtContact.Text;
			u.address = txtAddress.Text;
			u.gender = cmbGender.Text;
			u.user_type = cmbUserType.Text;
			u.added_date = DateTime.Now;
			u.added_by = 1;


			bool email_validation = dal.check_email(txtEmail.Text);
			//bool phoneCheck_success = dal.CheckPhoneNumber(txtContact.Text);
			bool success = false;

			string result = dal.completeValidation(u.first_name, u.last_name, u.username, u.email, u.password, u.contact, u.address, u.gender, u.gender);
			if (result == "FINE")
			{
				if (email_validation == true)
				{
					success = dal.Update(u);
			}
				else
				{
					MessageBox.Show("Email is Invalid.");
				}
			
			}
			else
			{
				MessageBox.Show(result);
			}
		
			

			//if data if updated successfully then the value of success will be true or else it will be false
			if (success == true)
			{
				//data updated successfully
				MessageBox.Show("User Successfully Updated");
				clear();
			}
			else
			{
				//failed to update user
				MessageBox.Show("Failed to update user");
			}
			//refreshing data grid view

			DataTable dt = dal.Select();
			dgvUsers.DataSource = dt;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			//first select user from data grid view..row ma click garesi ID box ma tesko id ko value aae halxa..teslai hamile sirf tanne ho code ma aba
			////getting user ID from form
			u.id = Convert.ToInt32(txtUserID.Text);

			bool success = dal.Delete(u);
			//if data deleted then value of success will be true else false
			if (success == true)
			{
				MessageBox.Show("User Deleted Successfully");
				clear();
			}
			else
			{
				MessageBox.Show("Failed to delete User");
			}
			//refreshing Data Grid View
			DataTable dt = dal.Select();
			dgvUsers.DataSource = dt;

		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			//textbox bata keywords liney
			string keywords = txtSearch.Text;
			if (keywords != null)
			{
				//show gardim user lai
				DataTable dt = dal.Search(keywords);
				dgvUsers.DataSource=dt;
			}
			else
			{
				//show all users from database
				DataTable dt = dal.Select();
				dgvUsers.DataSource = dt;

			}
		}

		private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
