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
	public partial class frmProducts : Form
	{
		public frmProducts()
		{
			InitializeComponent();
		}

		private void pictureBoxClose_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		categoriesDAL cdal = new categoriesDAL();

		productsBLL p = new productsBLL();
		productsDAL pdal = new productsDAL();

		userDAL udal = new userDAL(); //for finding ID from username

		private void frmProducts_Load(object sender, EventArgs e)
		{
			//creating datatable to hold categories from db
			DataTable categoriesDT = cdal.Select();
			//specify datasource for category combobox
			cmbCategory.DataSource = categoriesDT;
			//specify dispaly member and value member for combobox
			cmbCategory.DisplayMember = "title";
			cmbCategory.ValueMember = "title";
			//category ko table ma title leraera tesma click garda tesko value ni title kai value jane gari banaune..and we have varchar for category section in product table not INT


			//load all product at starting
			DataTable dt = pdal.Select();
			dgvProducts.DataSource = dt;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			//get all values from product form

			p.name = txtName.Text;
			p.category = cmbCategory.Text;
			p.description = txtDescription.Text;
			p.rate = decimal.Parse(txtRate.Text);   //convert this to decimal because data from textbox is in string datatype
			p.qty = decimal.Parse(txtQty.Text);
			p.selling_price = decimal.Parse(txtSellPrice.Text);
			p.added_date = DateTime.Now;
			//getting username of logged in user
			String loggedUsr = frmLogin.loggedIn;
			userBLL usr = udal.GetIDFromUsername(loggedUsr);

			p.added_by = usr.id;
			bool success = pdal.Insert(p);
			if (success == true)
			{
				MessageBox.Show("Product Added Successfully");
				Clear();
				DataTable dt = pdal.Select();
				dgvProducts.DataSource = dt;
			}
			else
			{
				MessageBox.Show("Failed to Add New Product");
			}

		
		}


		public void Clear()
		{
			txtID.Text = "";
			txtName.Text = "";
			txtDescription.Text = "";
			txtRate.Text = "";
			txtSearch.Text = "";
			txtSellPrice.Text = "";
		}

		private void dgvProducts_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			//creating int to know which row was clicked
			int rowIndex = e.RowIndex;
			txtID.Text = dgvProducts.Rows[rowIndex].Cells[0].Value.ToString();
			txtName.Text = dgvProducts.Rows[rowIndex].Cells[1].Value.ToString();
			cmbCategory.Text = dgvProducts.Rows[rowIndex].Cells[2].Value.ToString();
			txtDescription.Text = dgvProducts.Rows[rowIndex].Cells[3].Value.ToString();
			txtRate.Text = dgvProducts.Rows[rowIndex].Cells[4].Value.ToString();
			txtQty.Text= dgvProducts.Rows[rowIndex].Cells[5].Value.ToString();
			txtSellPrice.Text= dgvProducts.Rows[rowIndex].Cells[8].Value.ToString();

		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			p.id = int.Parse(txtID.Text);
			p.name = txtName.Text;
			p.category = cmbCategory.Text;
			p.description = txtDescription.Text;
			p.rate = decimal.Parse(txtRate.Text);
			p.added_date = DateTime.Now;
			p.qty= decimal.Parse(txtQty.Text);
			p.selling_price = decimal.Parse(txtSellPrice.Text);

			String loggedUsr = frmLogin.loggedIn;
			userBLL usr = udal.GetIDFromUsername(loggedUsr);

			p.added_by = usr.id;

			bool success = pdal.Update(p);
			if (success == true)
			{
				MessageBox.Show("Product Successfully Updated");
				Clear();
				DataTable dt = pdal.Select();
				dgvProducts.DataSource = dt;
			}
			else
			{
				MessageBox.Show("Failed to Update Product");
			}

		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			p.id = int.Parse(txtID.Text);
			bool success = pdal.Delete(p);
			if (success == true)
			{
				MessageBox.Show("Product Successfully Deleted");
				Clear();
				DataTable dt = pdal.Select();
				dgvProducts.DataSource = dt;
			}
			else
			{
				MessageBox.Show("Failed To Delete Product");
			}
		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			//get keywords from form
			string keywords = txtSearch.Text;
			if (keywords != null)
			{
				DataTable dt = pdal.Search(keywords);
				dgvProducts.DataSource = dt;
			}
			else
			{
				//display all products
				DataTable dt = pdal.Select();
				dgvProducts.DataSource = dt;
			}
		}

		private void lblQuantity_Click(object sender, EventArgs e)
		{

		}
	}
}
