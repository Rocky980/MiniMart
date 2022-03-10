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
	public partial class frmLogin : Form
	{
		public frmLogin()
		{
			InitializeComponent();
		}

		loginBLL l = new loginBLL();
		loginDAL dal = new loginDAL();

		public static string loggedIn;   //yo user logged in xa so esko name display garaune

		private void pboxClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{

			string sSourceData;
			byte[] tmpSource;
			byte[] tmpHash;

			sSourceData = txtPassword.Text;
			//Create a byte array from source data.
			tmpSource = ASCIIEncoding.ASCII.GetBytes(sSourceData);
			tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);



			l.username = txtUsername.Text.Trim();
		//	l.password = txtPassword.Text.Trim();
			l.password = Convert.ToBase64String(tmpHash);
			l.user_type = cmbUserType.Text.Trim();

			//checking the login crredential
			bool success = dal.loginCheck(l);
			if (success == true)
			{
				//login successful
				//MessageBox.Show("Login Successful");
				loggedIn = l.username;                       //login garesi tei user le add garxa arko user lai
				//need to open respective forms based on user type
				switch(l.user_type)
				{
					case "Admin":
						{
							frmAdminDashboard admin = new frmAdminDashboard();
							admin.Show();
							this.Hide(); //hide the current form that is login form
						}
						break;

					case "User":
						{
							frmUserDashboard user = new frmUserDashboard();
							user.Show();
							this.Hide();
						}
						break;

					default:
						{
							MessageBox.Show("Invalid User type");
						}
						break;
				}
			}
			else
			{
				//login failed
				MessageBox.Show("Login Failed. Try Again");
			}
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
