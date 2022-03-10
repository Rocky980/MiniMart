using MiniMart.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniMart
{
	public partial class frmAdminDashboard : Form
	{
		static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
		public frmAdminDashboard()
		{
			InitializeComponent();

		}

		private void lblFooter_Click(object sender, EventArgs e)
		{

		}

		private void usersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmUsers user = new frmUsers();
			user.Show();
		}

		private void frmAdminDashboard_FormClosed(object sender, FormClosedEventArgs e)
		{
			frmLogin login = new frmLogin();
			login.Show();
			this.Hide();
			
		}

		private void frmAdminDashboard_Load(object sender, EventArgs e)
		{

			lblLoggedInUser.Text = frmLogin.loggedIn;
		}

		private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmCategories category = new frmCategories();
			category.Show();
		}

		private void productsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmProducts product = new frmProducts();
			product.Show();
		}

		private void dealerAndCustomerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmDeaCust DeaCust = new frmDeaCust();
			DeaCust.Show();
		}

		private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmTransactions transaction = new frmTransactions();
			transaction.Show();
		}

		private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmInventory inventory = new frmInventory();
			inventory.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			
			//dgvTest2.DataSource = dt2;


		}

		private void chart_Click(object sender, EventArgs e)
		{

		}

		private void dd_ValueChanged(object sender, EventArgs e)
		{
			chart.Series["Transaction"].Points.Clear();
			chart2.Series["Profit"].Points.Clear();
			SqlConnection conn = new SqlConnection(myconnstrng);

			//string theDate = dd.Value.ToString("yyyy-MM-dd");
			//DateTime t = DateTime.Now;
			//string sql = "SELECT transaction_date FROM transactions where transaction_date '"+ 02 / 23 / 2022 + "'";
			//string sql = "SELECT transaction_date FROM transactions where id='" + 58+ "'";
			DataTable dt = new DataTable();
			//DataTable dt2 = new DataTable();
			//dt2.Clear();
			dt.Clear();
			//string sql = "SELECT transaction_date FROM transactions WHERE transaction_date BETWEEN @FromDate AND @ToDate";
			string sql = "SELECT transaction_date,profit FROM transactions WHERE transaction_date >=@FromDate";

			SqlCommand cmd = new SqlCommand(sql, conn);


			// then set these values
			cmd.Parameters.Add("@FromDate", SqlDbType.DateTime).Value = dd.Value.Date;
			//cmd.Parameters.Add("@ToDate", SqlDbType.DateTime).Value = DateTime.Today;
			//cmd.Parameters.Add("@ToDate", SqlDbType.DateTime).Value = DateTime.Now;


			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			conn.Open();

			adapter.Fill(dt);
			DataTable dt2 = new DataTable();
			dt2.Clear();
			dt2 = dt.Copy();
			//	dgvTest.DataSource = dt;
			int i = 0;
			foreach (DataRow row in dt.Rows)
			{
				i = i + 1;



			}
			
			DateTime today = DateTime.Now;
			DateTime answer = today.AddDays(1);

			//dgvTest.DataSource = dt;
			int t = 0;
			int insert = 0;
			int j, k;
		

			for (j = 0; j < dt.Rows.Count; j++)
			{
				t = 0;
				DataRow rows = dt.Rows[j];
				string transaction_date_search = rows["transaction_date"].ToString();
				for (k = 0; k < dt.Rows.Count; k++)
				{
					DataRow row = dt.Rows[k];
					string transaction_date = row["transaction_date"].ToString();
					string checkDate = answer.ToString();
					if (checkDate != transaction_date)
					{


						if (transaction_date == transaction_date_search)
						{
							insert = 1;
							//	row[0] = string.Empty;
							t = t + 1;

							row["transaction_date"] = answer;
							//txtResults.Text = row["transaction_date"].ToString();
						}


					}
				}


				//chart.Series["Transaction"].Points.AddXY(transaction_date_search, NumberOfTransactions);
				if (insert == 1)
				{
					chart.Series["Transaction"].Points.AddXY(transaction_date_search.Replace("12:00:00 AM", string.Empty), t);
					insert = 0;
				}
			}

			//dt.Clear();

			//////////////////////////////////////////////////////////////////////////////////////////
			t = 0;
			insert = 0;

			decimal realProfit = 0.0M;
			decimal totalProfit = 0.0M;
			for (j = 0; j < dt2.Rows.Count; j++)
			{
				t = 0;
				totalProfit = 0.0M;
				DataRow rrs = dt2.Rows[j];
				string transaction_date_search = rrs["transaction_date"].ToString();
				for (k = 0; k < dt2.Rows.Count; k++)
				{
					DataRow rr = dt2.Rows[k];
					string transaction_date = rr["transaction_date"].ToString();
					string checkDate = answer.ToString();
					if (checkDate != transaction_date)
					{


						if (transaction_date == transaction_date_search)
						{
							insert = 1;
							//	row[0] = string.Empty;
							t = t + 1;
							//profit = row["profit"].ToString();
							realProfit = Convert.ToDecimal(rr["profit"]);
							totalProfit = totalProfit + realProfit;
							rr["transaction_date"] = answer;
							//txtResults.Text = row["transaction_date"].ToString();
						}


					}
				}


				
				if (insert == 1)
				{

					chart2.Series["Profit"].Points.AddXY(transaction_date_search.Replace("12:00:00 AM", string.Empty), totalProfit);
					insert = 0;
				}
			}
		}
	}
}
