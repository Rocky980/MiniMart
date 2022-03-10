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

namespace MiniMart.UI
{
	public partial class frmDeaCust : Form
	{
		public frmDeaCust()
		{
			InitializeComponent();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void pictureBoxClose_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		DeaCustBLL dc = new DeaCustBLL();
		DeaCustDAL dcDal = new DeaCustDAL();

		userDAL uDal = new userDAL();

		private void btnAdd_Click(object sender, EventArgs e)
		{

			dc.type=cmbDeaCust.Text;
			dc.name = txtName.Text;
			dc.email = txtEmail.Text;
			dc.contact = txtContact.Text;
			dc.address = txtAddress.Text;
			dc.added_date = DateTime.Now;


			//getting ID to logged in user and passing it in dealer or customer module
			string loggedUsr = frmLogin.loggedIn;
			userBLL usr = uDal.GetIDFromUsername(loggedUsr);

			dc.added_by = usr.id;

			bool success = false;
			bool phoneCheck_success = uDal.CheckPhoneNumber(txtContact.Text);

			if (phoneCheck_success == true)
			{
				success = dcDal.Insert(dc);
			}

			if (success == true)
			{
				MessageBox.Show("Dealer or Customer Added Successfully");
				Clear();
				DataTable dt = dcDal.Select();
				dgvDeaCust.DataSource = dt;
			}
			else
			{
				//failed to INSERT
				MessageBox.Show("Dealer or Customer cannot be Inserted");
			}
		}

		public void Clear()
		{
			txtDeaCustID.Text = "";
			txtName.Text = "";
			txtEmail.Text = "";
			txtContact.Text = "";
			txtAddress.Text = "";
			txtSearch.Text = "";
		}

		private void frmDeaCust_Load(object sender, EventArgs e)
		{
			DataTable dt = dcDal.Select();
			dgvDeaCust.DataSource = dt;
		}

		private void dgvDeaCust_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			int rowIndex = e.RowIndex;

			txtDeaCustID.Text = dgvDeaCust.Rows[rowIndex].Cells[0].Value.ToString();
			cmbDeaCust.Text = dgvDeaCust.Rows[rowIndex].Cells[1].Value.ToString();
			txtName.Text = dgvDeaCust.Rows[rowIndex].Cells[2].Value.ToString();
			txtEmail.Text = dgvDeaCust.Rows[rowIndex].Cells[3].Value.ToString();
			txtContact.Text = dgvDeaCust.Rows[rowIndex].Cells[4].Value.ToString();
			txtAddress.Text = dgvDeaCust.Rows[rowIndex].Cells[5].Value.ToString();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			dc.id = int.Parse(txtDeaCustID.Text);
			dc.type = cmbDeaCust.Text;
			dc.name = txtName.Text;
			dc.email = txtEmail.Text;
			dc.contact = txtContact.Text;
			dc.address = txtAddress.Text;
			dc.added_date = DateTime.Now;
			//getting id of logged in user
			string loggedUsr = frmLogin.loggedIn;
			userBLL usr = uDal.GetIDFromUsername(loggedUsr);
			dc.added_by = usr.id;

			bool phoneCheck_success = uDal.CheckPhoneNumber(txtContact.Text);
			bool success = false;
			if (phoneCheck_success == true)
			{
				success = dcDal.Update(dc);
			}
			if (success == true)
			{
				MessageBox.Show("Dealer or Customer Updated Successfully");
				Clear();
				DataTable dt = dcDal.Select();
				dgvDeaCust.DataSource = dt;
			}
			else
			{
				MessageBox.Show("Failed To Update.");
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			dc.id = int.Parse(txtDeaCustID.Text);
			bool success = dcDal.Delete(dc);
			if (success == true)
			{
				MessageBox.Show("Dealer or Customer Deleted Successfully");
				Clear();
				DataTable dt = dcDal.Select();
				dgvDeaCust.DataSource = dt;
			}
			else
			{
				MessageBox.Show("Failed To Delete");
			}
		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			string keyword = txtSearch.Text;
			if (keyword != null)
			{
				DataTable dt = dcDal.Search(keyword);
				dgvDeaCust.DataSource = dt;
			}
			else
			{
				//else show all
				DataTable dt = dcDal.Select();
				dgvDeaCust.DataSource = dt;
			}
		}
	}
}
