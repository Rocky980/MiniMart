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
	public partial class frmCategories : Form
	{
		public frmCategories()
		{
			InitializeComponent();
		}

		private void pictureBoxClose_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		categoriesBLL c = new categoriesBLL();
		categoriesDAL dal = new categoriesDAL();
		userDAL udal = new userDAL();

		private void btnADD_Click(object sender, EventArgs e)
		{
			//get values from category from
			bool success = false;
			c.title = txtTitle.Text;
			c.description = txtDescription.Text;
			c.added_date = DateTime.Now;

			//getting ID of user in added by field
			string loggedUser = frmLogin.loggedIn;   //in our login form we have static method "loggedIn" which has value of logged in user..now we should convert this name into ID
			userBLL usr = udal.GetIDFromUsername(loggedUser);
			//passing the id of loggedInUser in added_by field
			c.added_by = usr.id;

			if (txtTitle.Text == "")
			{
				MessageBox.Show("Please enter the category name");
			}
			else if (txtTitle.Text.Length<2)
			{
				MessageBox.Show("Length of category name should be greater than 2");
			}
			else if (txtDescription.Text=="")
			{
				MessageBox.Show("Please enter the category description");
			}
			else if (txtDescription.Text.Length < 3)
			{
				MessageBox.Show("Length of category description should be greater than 3");
			}
			else
			{
				success = dal.Insert(c);
			}


			//crating boolean method to insert data into DB
			
			if (success == true)
			{
				MessageBox.Show("New Category Inserted Successfully");
				Clear();
				//refresh data grid view
				DataTable dt = dal.Select();
				dgvCategories.DataSource = dt;

			}
			else
			{
				MessageBox.Show("Failed To Insert New Category");
			}
		}

		public void Clear()
		{
			txtCategoryID.Text = "";
			txtTitle.Text = "";
			txtDescription.Text = "";
			txtSearch.Text = "";
		}

		private void frmCategories_Load(object sender, EventArgs e)
		{
			//display all category in data grid view while loading category for
			//we need datatable to store data from DB temporarily

			DataTable dt = dal.Select();
			dgvCategories.DataSource = dt;
		}

		private void dgvCategories_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			//first find row index value..ID of row which is clicked
			int RowIndex = e.RowIndex;
			txtCategoryID.Text = dgvCategories.Rows[RowIndex].Cells[0].Value.ToString();
			txtTitle.Text = dgvCategories.Rows[RowIndex].Cells[1].Value.ToString();
			txtDescription.Text = dgvCategories.Rows[RowIndex].Cells[2].Value.ToString();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			//get values from categories from
			c.id = int.Parse(txtCategoryID.Text);  //text box bata aako data jaile STRING ma hunxa so need to convert it
			c.title = txtTitle.Text;
			c.description = txtDescription.Text;
			c.added_date = DateTime.Now;

			//getting ID of user in added by field
			string loggedUser = frmLogin.loggedIn;   //in our login form we have static method "loggedIn" which has value of logged in user..now we should convert this name into ID
			userBLL usr = udal.GetIDFromUsername(loggedUser);
			//passing the id of loggedInUser in added_by field
			c.added_by = usr.id;

			bool success = dal.Update(c);
			if (success==true)
			{
				MessageBox.Show("Categories Updated Successfully");
				Clear();
				//refresh dgv
				DataTable dt = dal.Select();
				dgvCategories.DataSource = dt;
			}
			else
			{
				MessageBox.Show("Failed To Update Category");
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			//get id of category which is clicked
			c.id = int.Parse(txtCategoryID.Text);
			bool success = dal.Delete(c);
			if (success == true)
			{
				MessageBox.Show("Category Deleted Successfully");
				Clear();
				DataTable dt = dal.Select();
				dgvCategories.DataSource = dt;
			}
			else
			{
				MessageBox.Show("Failed To Delete Category");
			}
		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			string keywords = txtSearch.Text;
			if (keywords != null)
			{
				DataTable dt = dal.Search(keywords);
				dgvCategories.DataSource = dt;
			}
			else
			{
				//use select method to display all categories
				DataTable dt = dal.Select();
				dgvCategories.DataSource = dt;
			}
		}
	}
}
