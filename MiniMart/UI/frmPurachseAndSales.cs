using MiniMart.BLL;
using MiniMart.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace MiniMart.UI
{
	public partial class frmPurachseAndSales : Form
	{
		public frmPurachseAndSales()
		{
			InitializeComponent();
		}

		private void pictureBoxClose_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		string amount;
		DeaCustDAL dcDal = new DeaCustDAL();
		productsDAL pDAL = new productsDAL();
		userDAL uDAL = new userDAL();

		transactionDAL tDAL = new transactionDAL();
		transactionDetailDAL tdDAL = new transactionDetailDAL();



		DataTable transactionDT = new DataTable(); //yaha banaesi xae esmas sab add hudai jana..tala ko code ma datatable banaepar tyo ghari ghari refresh hunxa euta matra dekhauxa

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void frmPurachseAndSales_Load(object sender, EventArgs e)
		{
			//get the transaction type value from user dashboard
			string type = frmUserDashboard.transactionType;
			lblTop.Text = type;

			//when we load our form we need tospecify column for our transaction datatable
			transactionDT.Columns.Add("Product Name");
			transactionDT.Columns.Add("Rate");
			transactionDT.Columns.Add("Quantity");
			transactionDT.Columns.Add("Total");
		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			string keyword = txtSearch.Text;
			if (keyword == "")
			{
				txtName.Text = "";
				txtEmail.Text = "";
				txtContact.Text = "";
				txtAddress.Text = "";
			}

			//code to get details
			DeaCustBLL dc = dcDal.SearchDealerCustomerForTransaction(keyword);
			txtName.Text = dc.name;
			txtEmail.Text = dc.email;
			txtContact.Text = dc.contact;
			txtAddress.Text = dc.address;

		}

		private void txtSearchProduct_TextChanged(object sender, EventArgs e)
		{
			string keyword = txtSearchProduct.Text;
			if (keyword == "")
			{
				txtProductName.Text = "";
				txtInventory.Text = "";
				txtRate.Text = "";
				txtQty.Text = "";
				return;
			}

			productsBLL p = pDAL.GetProductsForTransaction(keyword);
			if (lblTop.Text == "Purchase")
			{
				txtProductName.Text = p.name;
				txtInventory.Text = p.qty.ToString();
				txtRate.Text = p.rate.ToString();
			}
			else
			{
				txtProductName.Text = p.name;
				txtInventory.Text = p.qty.ToString();
				txtRate.Text = p.selling_price.ToString();
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
				string productName = txtProductName.Text;
				decimal Rate = decimal.Parse(txtRate.Text);
			int errorCounter = Regex.Matches(txtQty.Text, @"[a-zA-Z]").Count;
			productsBLL pdbll = pDAL.GetProductIDFromName(txtProductName.Text);
			decimal Current_qty_in_db = pDAL.GetProductQty(pdbll.id);

			if (lblTop.Text == "Sales")
			{
				if (errorCounter == 0 && (int.Parse(txtQty.Text) > 0))
				{

					if (Current_qty_in_db - decimal.Parse(txtQty.Text) >= 0)
					{
						decimal Qty = decimal.Parse(txtQty.Text);

						decimal Total = Rate * Qty;

						//display the subtotal in textbox
						//first get the total value from textbox
						decimal subTotal = decimal.Parse(txtSubTotal.Text);
						subTotal = subTotal + Total;



						//check whether the product is selected or not
						if (productName == "")
						{
							MessageBox.Show("SELECT THE PRODUCT FIRST. TRY AGAIN");
						}
						else
						{
							//add product to data grid view 
							transactionDT.Rows.Add(productName, Rate, Qty, Total);

							//show in data grid view
							dgvAddedProducts.DataSource = transactionDT;
							//display subtotal in textbox
							txtSubTotal.Text = subTotal.ToString();

							//after showing data in dgv clear text boxes for new items to be searched and added

							txtSearchProduct.Text = "";
							txtProductName.Text = "";
							txtInventory.Text = "0.00";
							txtRate.Text = "0.00";
							txtQty.Text = "0.00";
						}
					}
					else
					{
						MessageBox.Show("Given quantity exceeds the available quantity");
					}
				}
				else
				{
					MessageBox.Show("Please enter a valid Quantity.");
				}
			}
			else
			{
				if (errorCounter == 0 && (int.Parse(txtQty.Text) > 0))
				{

			
						decimal Qty = decimal.Parse(txtQty.Text);

						decimal Total = Rate * Qty;

						//display the subtotal in textbox
						//first get the total value from textbox
						decimal subTotal = decimal.Parse(txtSubTotal.Text);
						subTotal = subTotal + Total;



						//check whether the product is selected or not
						if (productName == "")
						{
							MessageBox.Show("SELECT THE PRODUCT FIRST. TRY AGAIN");
						}
						else
						{
							//add product to data grid view 
							transactionDT.Rows.Add(productName, Rate, Qty, Total);

							//show in data grid view
							dgvAddedProducts.DataSource = transactionDT;
							//display subtotal in textbox
							txtSubTotal.Text = subTotal.ToString();

							//after showing data in dgv clear text boxes for new items to be searched and added

							txtSearchProduct.Text = "";
							txtProductName.Text = "";
							txtInventory.Text = "0.00";
							txtRate.Text = "0.00";
							txtQty.Text = "0.00";
						}
					}
					else
					{
						MessageBox.Show("Given quantity exceeds the available quantity");
					}
			}
			}
			
		

		private void txtDiscount_TextChanged(object sender, EventArgs e)
		{
			txtVat.Text = string.Empty;
			//get the value from discount textbox
			string value = txtDiscount.Text;
			if (value == "")
			{
				//MessageBox.Show("Please Add Discount First");
				txtDiscount.Text = string.Empty;
				txtVat.Text = string.Empty;
				amount = txtSubTotal.Text;
				txtGrandTotal.Text = string.Empty;
				
			

			}
			else
			{
				decimal subTotal = decimal.Parse(txtSubTotal.Text);
				//get the discount in decumal value
				decimal discount = decimal.Parse(txtDiscount.Text);

				//caculate the grand total based on discount
				decimal grandTotal = ((100 - discount) / 100) * subTotal; //discount is in %

				//dispaly grantotal in textbox
				txtGrandTotal.Text = grandTotal.ToString();
				amount = txtGrandTotal.Text;

			}
		}

		private void txtVat_TextChanged(object sender, EventArgs e)
		{
			//check if grandtotal has value or not..bcause vat is calcuated on grand total..calculate discount first
			if (txtVat.Text == "")
			{
				if (txtDiscount.Text == "")
				{
					txtGrandTotal.Text = "";
				}
				else
				{
					//txtVat.Text = "0";
					txtGrandTotal.Text = amount;
					txtVat.Text = string.Empty;
				}

			}
			else
			{
				string check = txtGrandTotal.Text;
				if (check == "")
				{
					//dispaly error message to calculate discount
					MessageBox.Show("Calculate the discount and set Grand Total First.");
					txtVat.Text = string.Empty;

				}
				else
				{
					//calculate vat
					decimal previousGT = decimal.Parse(txtGrandTotal.Text);  //GT is grandtotal

					decimal vat = decimal.Parse(txtVat.Text);
					decimal grandTotalWithVat = ((100 + vat) / 100) * previousGT;

					//display new grandtotal with vat
					txtGrandTotal.Text = grandTotalWithVat.ToString();
				}
			}
		}

		private void txtPaidAmount_TextChanged(object sender, EventArgs e)
		{
			//get the paid amount and grand total
			decimal grandTotal = decimal.Parse(txtGrandTotal.Text);
			decimal paidAmount;
			if (txtPaidAmount.Text == "")
			{
				paidAmount = 0;
			}
			else
			{
				paidAmount = decimal.Parse(txtPaidAmount.Text);
			}
			
			

			decimal returnAmount = paidAmount - grandTotal;

			txtReturnAmount.Text = returnAmount.ToString();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			decimal paidAmount = decimal.Parse(txtPaidAmount.Text);
		
			//get the values from purachse form first
			transactionsBLL transaction = new transactionsBLL();
			transaction.type = lblTop.Text;


			//get id of dealer or customer..get name first
			string deaCustName = txtName.Text;
			DeaCustBLL dcBLL = dcDal.GetDeaCustIDFromName(deaCustName); //ussed again down below


			transaction.dea_cust_id=dcBLL.id;    //used again
			transaction.grandTotal = Math.Round(decimal.Parse(txtGrandTotal.Text),2);
			//transaction.transaction_date = datePicker.Value.ToString();
			transaction.transaction_date = datePicker.Value.Date;	
			transaction.tax = decimal.Parse(txtVat.Text);
			transaction.discount = decimal.Parse(txtDiscount.Text);

			//get the username of logged in user111
			string username = frmLogin.loggedIn; //chalae rakhne user ko id
			userBLL u = uDAL.GetIDFromUsername(username);
			transaction.added_by = u.id;
		/*	if (lblTop.Text == "Purchase")
			{
				transaction.profit = 0;
			}
		*/
			transaction.transactionDetails = transactionDT; //product add garda sabae transactionDT ma basxa..mathi ko code herne
															//
			bool success = false;

			//actual code to insert transaction and transaction detail
			//using(TransactionScope scope = new TransactionScope())       8888888888
			//{                                                            888888888888
				//DeaCustBLL dcBLL
				//transactionsBLL transaction
				//transactionDAL tDAL 
				//transactionDetailDAL tdDAL
				//transactionDetailBLL transactionDetail

				int transactionID = -1;
			if (paidAmount > transaction.grandTotal)
			{



				string insert_id = tDAL.Insert_Transaction(transaction, out transactionID);


				decimal TotalCost = 0.0M;

				decimal TotalSelling = 0.0M;

				//use for loop to insert transaction details
				for (int i = 0; i < transactionDT.Rows.Count; i++)
				{
					//get all details of product
					transactionDetailBLL transactionDetail = new transactionDetailBLL();

					//get product name and convert it to id
					string ProductName = transactionDT.Rows[i][0].ToString();
					productsBLL p = pDAL.GetProductIDFromName(ProductName);  //also gets cost pricee

					transactionDetail.product_id = p.id;
					//mathi transactionDT.Columns.Add("field_name") gareko xam..tesko anusar numbering hunxa 
					//index of Product Name is 0, Rate is 1, Quantity is 2, Total is 3

					//create a function in productDAL to get the cost price of product in order to calculate profit



					transactionDetail.transaction_id = int.Parse(insert_id);
					transactionDetail.rate = decimal.Parse(transactionDT.Rows[i][1].ToString());



					transactionDetail.qty = decimal.Parse(transactionDT.Rows[i][2].ToString());
					transactionDetail.total = Math.Round(decimal.Parse(transactionDT.Rows[i][3].ToString()), 2);
					transactionDetail.dea_cust_id = dcBLL.id;  //line 200,203
					transactionDetail.added_date = datePicker.Value.Date;
					transactionDetail.added_by = u.id;

					decimal CostPricePerUnit = p.rate;
					//MessageBox.Show(CostPricePerUnit.ToString());

					decimal totalCostPerUnit = CostPricePerUnit * transactionDetail.qty;

					//MessageBox.Show(totalCostPerUnit.ToString());

					//got from GetProductIDFromName  function in productsDAL
					TotalCost = TotalCost + totalCostPerUnit;
					//TotalCost = Decimal.Add(TotalCost, totalCostPerUnit);

					TotalSelling = TotalSelling + (transactionDetail.rate * transactionDetail.qty);

					//MessageBox.Show(TotalCost.ToString());

					//decimal PriceAfterDiscount=transaction.







					//before inserting transaction detail i will increase or decrease product quantity based on purchase or sales
					string transactionType = lblTop.Text;
					bool x = false;
					//lets check if we are on purchase or sales
					if (transactionType == "Purchase")
					{
						x = pDAL.IncreaseProduct(transactionDetail.product_id, transactionDetail.qty);

					}
					else if (transactionType == "Sales")
					{
						x = pDAL.DecreaseProduct(transactionDetail.product_id, transactionDetail.qty);
					}


					//insert tranasction in dataabse
					bool y = tdDAL.InsertTransactionDetail(transactionDetail);

					success = y && x;

				}
				



				decimal TotalSellingWithDiscount = TotalSelling - ((TotalSelling * transaction.discount) / 100);



				decimal vat = (TotalSellingWithDiscount * transaction.tax) / 100;



				decimal profit = TotalSellingWithDiscount - (TotalCost + vat);
				if (lblTop.Text == "Sales")
				{
					transaction.profit = profit;
				}
				else
				{
					transaction.profit = 0.0M;
				}
				transaction.id = int.Parse(insert_id);
				bool check = tDAL.InsertProfit(transaction);

				success = success && check;








				if (success == true)
				{
					//transaction complete

					//scope.Complete();
					//very very imporatant ..yo complete garena vane insert hudaena
					MessageBox.Show("Transaction Completed Successfully");
					//clear the data grid view and clear the text boxes
					transactionDT.Clear();
					dgvAddedProducts.DataSource = null;
					dgvAddedProducts.Rows.Clear();

					txtSearch.Text = "";
					txtName.Text = "";
					txtEmail.Text = "";
					txtContact.Text = "";
					txtAddress.Text = "";
					txtSearchProduct.Text = "";
					txtProductName.Text = "";
					txtInventory.Text = "0";
					txtRate.Text = "0";
					txtQty.Text = "0";
					txtSubTotal.Text = "0";
					txtDiscount.Text = "0";
					txtVat.Text = "0";
					txtGrandTotal.Text = "0";
					txtPaidAmount.Text = "0";
					txtReturnAmount.Text = "0";



					//MessageBox.Show(insert_id);





					this.Close();
					frmPurachseAndSales sales = new frmPurachseAndSales();
					sales.Show();
				}
				else
				{
					//transaction failed
					MessageBox.Show("Transaction Failed");
				}
			}
			else
			{
				MessageBox.Show("Please Check the Paid Amount");
			}

			}

		private void datePicker_ValueChanged(object sender, EventArgs e)
		{

		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void asliDate_TextChanged(object sender, EventArgs e)
		{

		}

		private void pnlDeaCust_Paint(object sender, PaintEventArgs e)
		{

		}
	}
	}
//}
