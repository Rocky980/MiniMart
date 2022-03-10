using MiniMart.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniMart
{
	public partial class frmUserDashboard : Form
	{
		public frmUserDashboard()
		{
			InitializeComponent();
		}
		//set a public static method to specify whether the form is sale or purchase
		public static string transactionType;
		private void frmUserDashboard_FormClosed(object sender, FormClosedEventArgs e)
		{
			frmLogin login = new frmLogin();
			login.Show();
			this.Hide();
			
		}

		private void frmUserDashboard_Load(object sender, EventArgs e)
		{
			lblLoggedInUser.Text = frmLogin.loggedIn;
		}

		private void dealerAndCustomerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmDeaCust DeaCust = new frmDeaCust();
			DeaCust.Show();
		}

		private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//set value on transationType static 
			transactionType = "Purchase";
			frmPurachseAndSales purchase = new frmPurachseAndSales();
			purchase.Show();
			
		}

		private void salesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//set value on transationType static 
			transactionType = "Sales";

			frmPurachseAndSales sales = new frmPurachseAndSales();
			sales.Show();
		
		}

		private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmInventory inventory = new frmInventory();
			inventory.Show();
		}
	}
}
