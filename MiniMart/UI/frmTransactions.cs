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
	public partial class frmTransactions : Form
	{
		public frmTransactions()
		{
			InitializeComponent();
		}

		transactionDAL tdal = new transactionDAL();
		transactionDetailDAL tDDAL = new transactionDetailDAL();


		private void pictureBoxClose_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void frmTransactions_Load(object sender, EventArgs e)
		{
			//display all transaction
			DataTable dt = tdal.DisplayAllTransactions();
			dgvTransactions.DataSource = dt;
		}

		private void cmbTransactionType_SelectedIndexChanged(object sender, EventArgs e)
		{
			dgvTransactionDetail.DataSource = null;
			//get the value from combo box
			string type = cmbTransactionType.Text;

			DataTable dt = tdal.DisplayTransactionByType(type);
			dgvTransactions.DataSource = dt;
		}

		private void btnAll_Click(object sender, EventArgs e)
		{

			txtSearch.Text = string.Empty;
			DataTable dt = tdal.DisplayAllTransactions();
			dgvTransactions.DataSource = dt;
			cmbTransactionType.ResetText();
			dgvTransactionDetail.DataSource = null;
		}

		private void dgvTransactions_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			int rowIndex = e.RowIndex;
			string string_transaction_id= dgvTransactions.Rows[rowIndex].Cells[0].Value.ToString();
			int transaction_ID = int.Parse(string_transaction_id);
			DataTable dt2 = tDDAL.getTransactionDetailFromTransactionID(transaction_ID);
			dgvTransactionDetail.DataSource = dt2;
		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
			txtSearch.Text = string.Empty;
			dgvTransactionDetail.DataSource = null;
			DateTime date = dtp_transaction.Value.Date;
			string type = cmbTransactionType.Text;
			DataTable dt = tdal.DisplayAllTransactionsByDate(date,type);
			dgvTransactions.DataSource = dt;
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			string keywords = txtSearch.Text;
			if (keywords != null)
			{
				//show gardim user lai
				DataTable dt = tdal.SearchTransactionByName_ID(keywords);

				dgvTransactions.DataSource = dt;
			}
			else
			{
				//show all users from database
				DataTable dt = tdal.DisplayAllTransactions();
				dgvTransactions.DataSource = dt;

			}
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			
		}
	}
}
