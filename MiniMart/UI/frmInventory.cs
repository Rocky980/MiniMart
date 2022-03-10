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
	public partial class frmInventory : Form
	{
		public frmInventory()
		{
			InitializeComponent();
		}

		categoriesDAL cdal = new categoriesDAL();
		productsDAL pdal = new productsDAL();

		private void pictureBoxClose_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void frmInventory_Load(object sender, EventArgs e)
		{
			//display the categories in combo box
			DataTable cDt = cdal.Select();
			cmbCategories.DataSource = cDt;

			//give the value member and display member for combo box

			cmbCategories.DisplayMember = "title";
			cmbCategories.ValueMember = "title";

			//display all products in data grid view when the form is loaded
			DataTable pdt = pdal.Select();
			dgvProducts.DataSource = pdt;

		}

		private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
		{
			string category = cmbCategories.Text;
			DataTable dt = pdal.DisplayProductByCategory(category);
			dgvProducts.DataSource = dt;
		}

		private void btnAll_Click(object sender, EventArgs e)
		{
			cmbCategories.ResetText();
			DataTable dt = pdal.Select();
			dgvProducts.DataSource = dt;
		}
	}
}
