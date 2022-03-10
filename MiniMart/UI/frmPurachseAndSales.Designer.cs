
namespace MiniMart.UI
{
	partial class frmPurachseAndSales
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurachseAndSales));
			this.pictureBoxClose = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblTop = new System.Windows.Forms.Label();
			this.pnlDeaCust = new System.Windows.Forms.Panel();
			this.datePicker = new System.Windows.Forms.DateTimePicker();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtContact = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.lblAddress = new System.Windows.Forms.Label();
			this.lblBillDate = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.lblContact = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.lblSearch = new System.Windows.Forms.Label();
			this.lblDeaCustTitle = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnAdd = new System.Windows.Forms.Button();
			this.txtQty = new System.Windows.Forms.TextBox();
			this.txtRate = new System.Windows.Forms.TextBox();
			this.txtInventory = new System.Windows.Forms.TextBox();
			this.txtProductName = new System.Windows.Forms.TextBox();
			this.txtSearchProduct = new System.Windows.Forms.TextBox();
			this.lblQuantity = new System.Windows.Forms.Label();
			this.lblRate = new System.Windows.Forms.Label();
			this.lblInventory = new System.Windows.Forms.Label();
			this.lblProductName = new System.Windows.Forms.Label();
			this.lblProductSearch = new System.Windows.Forms.Label();
			this.lblTitle = new System.Windows.Forms.Label();
			this.pnldataGridView = new System.Windows.Forms.Panel();
			this.dgvAddedProducts = new System.Windows.Forms.DataGridView();
			this.lblDGVTitle = new System.Windows.Forms.Label();
			this.pnlCalculation = new System.Windows.Forms.Panel();
			this.btnSave = new System.Windows.Forms.Button();
			this.txtReturnAmount = new System.Windows.Forms.TextBox();
			this.txtPaidAmount = new System.Windows.Forms.TextBox();
			this.txtGrandTotal = new System.Windows.Forms.TextBox();
			this.txtVat = new System.Windows.Forms.TextBox();
			this.txtDiscount = new System.Windows.Forms.TextBox();
			this.txtSubTotal = new System.Windows.Forms.TextBox();
			this.lblReturnAmount = new System.Windows.Forms.Label();
			this.lblPaidAmount = new System.Windows.Forms.Label();
			this.lblDiscount = new System.Windows.Forms.Label();
			this.lblVat = new System.Windows.Forms.Label();
			this.lblGrandTotal = new System.Windows.Forms.Label();
			this.lblTotal = new System.Windows.Forms.Label();
			this.lblCalculationTitle = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
			this.panel1.SuspendLayout();
			this.pnlDeaCust.SuspendLayout();
			this.panel2.SuspendLayout();
			this.pnldataGridView.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvAddedProducts)).BeginInit();
			this.pnlCalculation.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBoxClose
			// 
			this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
			this.pictureBoxClose.Location = new System.Drawing.Point(1356, 3);
			this.pictureBoxClose.Name = "pictureBoxClose";
			this.pictureBoxClose.Size = new System.Drawing.Size(37, 36);
			this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxClose.TabIndex = 1;
			this.pictureBoxClose.TabStop = false;
			this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
			this.panel1.Controls.Add(this.pictureBoxClose);
			this.panel1.Controls.Add(this.lblTop);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1409, 48);
			this.panel1.TabIndex = 4;
			// 
			// lblTop
			// 
			this.lblTop.AutoSize = true;
			this.lblTop.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTop.ForeColor = System.Drawing.Color.White;
			this.lblTop.Location = new System.Drawing.Point(622, 9);
			this.lblTop.Name = "lblTop";
			this.lblTop.Size = new System.Drawing.Size(230, 30);
			this.lblTop.TabIndex = 0;
			this.lblTop.Text = "PURCHASE AND SALES";
			// 
			// pnlDeaCust
			// 
			this.pnlDeaCust.Controls.Add(this.datePicker);
			this.pnlDeaCust.Controls.Add(this.txtAddress);
			this.pnlDeaCust.Controls.Add(this.txtEmail);
			this.pnlDeaCust.Controls.Add(this.txtContact);
			this.pnlDeaCust.Controls.Add(this.txtName);
			this.pnlDeaCust.Controls.Add(this.txtSearch);
			this.pnlDeaCust.Controls.Add(this.lblAddress);
			this.pnlDeaCust.Controls.Add(this.lblBillDate);
			this.pnlDeaCust.Controls.Add(this.lblName);
			this.pnlDeaCust.Controls.Add(this.lblContact);
			this.pnlDeaCust.Controls.Add(this.lblEmail);
			this.pnlDeaCust.Controls.Add(this.lblSearch);
			this.pnlDeaCust.Controls.Add(this.lblDeaCustTitle);
			this.pnlDeaCust.Location = new System.Drawing.Point(3, 45);
			this.pnlDeaCust.Name = "pnlDeaCust";
			this.pnlDeaCust.Size = new System.Drawing.Size(1406, 109);
			this.pnlDeaCust.TabIndex = 5;
			this.pnlDeaCust.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDeaCust_Paint);
			// 
			// datePicker
			// 
			this.datePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.datePicker.CustomFormat = "dd-MM-yyyy";
			this.datePicker.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.datePicker.Location = new System.Drawing.Point(1130, 37);
			this.datePicker.Name = "datePicker";
			this.datePicker.Size = new System.Drawing.Size(249, 27);
			this.datePicker.TabIndex = 12;
			this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
			// 
			// txtAddress
			// 
			this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAddress.Location = new System.Drawing.Point(784, 31);
			this.txtAddress.Multiline = true;
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(261, 75);
			this.txtAddress.TabIndex = 11;
			// 
			// txtEmail
			// 
			this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmail.Location = new System.Drawing.Point(468, 37);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(243, 27);
			this.txtEmail.TabIndex = 10;
			// 
			// txtContact
			// 
			this.txtContact.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtContact.Location = new System.Drawing.Point(468, 70);
			this.txtContact.Name = "txtContact";
			this.txtContact.Size = new System.Drawing.Size(243, 27);
			this.txtContact.TabIndex = 9;
			// 
			// txtName
			// 
			this.txtName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtName.Location = new System.Drawing.Point(81, 70);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(287, 27);
			this.txtName.TabIndex = 8;
			// 
			// txtSearch
			// 
			this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearch.Location = new System.Drawing.Point(81, 37);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(287, 27);
			this.txtSearch.TabIndex = 7;
			this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
			// 
			// lblAddress
			// 
			this.lblAddress.AutoSize = true;
			this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAddress.Location = new System.Drawing.Point(717, 40);
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.Size = new System.Drawing.Size(62, 20);
			this.lblAddress.TabIndex = 6;
			this.lblAddress.Text = "Address";
			// 
			// lblBillDate
			// 
			this.lblBillDate.AutoSize = true;
			this.lblBillDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBillDate.Location = new System.Drawing.Point(1051, 40);
			this.lblBillDate.Name = "lblBillDate";
			this.lblBillDate.Size = new System.Drawing.Size(66, 20);
			this.lblBillDate.TabIndex = 5;
			this.lblBillDate.Text = "Bill Date";
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.Location = new System.Drawing.Point(9, 73);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(49, 20);
			this.lblName.TabIndex = 4;
			this.lblName.Text = "Name";
			// 
			// lblContact
			// 
			this.lblContact.AutoSize = true;
			this.lblContact.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblContact.Location = new System.Drawing.Point(402, 77);
			this.lblContact.Name = "lblContact";
			this.lblContact.Size = new System.Drawing.Size(60, 20);
			this.lblContact.TabIndex = 3;
			this.lblContact.Text = "Contact";
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEmail.Location = new System.Drawing.Point(402, 37);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(46, 20);
			this.lblEmail.TabIndex = 2;
			this.lblEmail.Text = "Email";
			// 
			// lblSearch
			// 
			this.lblSearch.AutoSize = true;
			this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSearch.Location = new System.Drawing.Point(8, 40);
			this.lblSearch.Name = "lblSearch";
			this.lblSearch.Size = new System.Drawing.Size(53, 20);
			this.lblSearch.TabIndex = 1;
			this.lblSearch.Text = "Search";
			// 
			// lblDeaCustTitle
			// 
			this.lblDeaCustTitle.AutoSize = true;
			this.lblDeaCustTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDeaCustTitle.Location = new System.Drawing.Point(8, 5);
			this.lblDeaCustTitle.Name = "lblDeaCustTitle";
			this.lblDeaCustTitle.Size = new System.Drawing.Size(227, 21);
			this.lblDeaCustTitle.TabIndex = 0;
			this.lblDeaCustTitle.Text = "Dealer and Customer Details";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnAdd);
			this.panel2.Controls.Add(this.txtQty);
			this.panel2.Controls.Add(this.txtRate);
			this.panel2.Controls.Add(this.txtInventory);
			this.panel2.Controls.Add(this.txtProductName);
			this.panel2.Controls.Add(this.txtSearchProduct);
			this.panel2.Controls.Add(this.lblQuantity);
			this.panel2.Controls.Add(this.lblRate);
			this.panel2.Controls.Add(this.lblInventory);
			this.panel2.Controls.Add(this.lblProductName);
			this.panel2.Controls.Add(this.lblProductSearch);
			this.panel2.Controls.Add(this.lblTitle);
			this.panel2.Location = new System.Drawing.Point(3, 161);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1406, 105);
			this.panel2.TabIndex = 6;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.ForestGreen;
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnAdd.Location = new System.Drawing.Point(1257, 21);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(133, 52);
			this.btnAdd.TabIndex = 18;
			this.btnAdd.Text = "ADD";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// txtQty
			// 
			this.txtQty.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtQty.Location = new System.Drawing.Point(1091, 35);
			this.txtQty.Name = "txtQty";
			this.txtQty.Size = new System.Drawing.Size(127, 27);
			this.txtQty.TabIndex = 17;
			// 
			// txtRate
			// 
			this.txtRate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRate.Location = new System.Drawing.Point(926, 32);
			this.txtRate.Name = "txtRate";
			this.txtRate.Size = new System.Drawing.Size(127, 27);
			this.txtRate.TabIndex = 16;
			// 
			// txtInventory
			// 
			this.txtInventory.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtInventory.Location = new System.Drawing.Point(730, 31);
			this.txtInventory.Name = "txtInventory";
			this.txtInventory.Size = new System.Drawing.Size(150, 27);
			this.txtInventory.TabIndex = 15;
			this.txtInventory.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// txtProductName
			// 
			this.txtProductName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtProductName.Location = new System.Drawing.Point(401, 32);
			this.txtProductName.Name = "txtProductName";
			this.txtProductName.Size = new System.Drawing.Size(246, 27);
			this.txtProductName.TabIndex = 14;
			// 
			// txtSearchProduct
			// 
			this.txtSearchProduct.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearchProduct.Location = new System.Drawing.Point(69, 31);
			this.txtSearchProduct.Name = "txtSearchProduct";
			this.txtSearchProduct.Size = new System.Drawing.Size(271, 27);
			this.txtSearchProduct.TabIndex = 13;
			this.txtSearchProduct.TextChanged += new System.EventHandler(this.txtSearchProduct_TextChanged);
			// 
			// lblQuantity
			// 
			this.lblQuantity.AutoSize = true;
			this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblQuantity.Location = new System.Drawing.Point(1053, 35);
			this.lblQuantity.Name = "lblQuantity";
			this.lblQuantity.Size = new System.Drawing.Size(32, 20);
			this.lblQuantity.TabIndex = 5;
			this.lblQuantity.Text = "Qty";
			// 
			// lblRate
			// 
			this.lblRate.AutoSize = true;
			this.lblRate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRate.Location = new System.Drawing.Point(883, 35);
			this.lblRate.Name = "lblRate";
			this.lblRate.Size = new System.Drawing.Size(39, 20);
			this.lblRate.TabIndex = 4;
			this.lblRate.Text = "Rate";
			// 
			// lblInventory
			// 
			this.lblInventory.AutoSize = true;
			this.lblInventory.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInventory.Location = new System.Drawing.Point(658, 34);
			this.lblInventory.Name = "lblInventory";
			this.lblInventory.Size = new System.Drawing.Size(70, 20);
			this.lblInventory.TabIndex = 3;
			this.lblInventory.Text = "Inventory";
			// 
			// lblProductName
			// 
			this.lblProductName.AutoSize = true;
			this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblProductName.Location = new System.Drawing.Point(346, 34);
			this.lblProductName.Name = "lblProductName";
			this.lblProductName.Size = new System.Drawing.Size(49, 20);
			this.lblProductName.TabIndex = 2;
			this.lblProductName.Text = "Name";
			// 
			// lblProductSearch
			// 
			this.lblProductSearch.AutoSize = true;
			this.lblProductSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblProductSearch.Location = new System.Drawing.Point(10, 35);
			this.lblProductSearch.Name = "lblProductSearch";
			this.lblProductSearch.Size = new System.Drawing.Size(53, 20);
			this.lblProductSearch.TabIndex = 1;
			this.lblProductSearch.Text = "Search";
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.Location = new System.Drawing.Point(8, 0);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(116, 20);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Product Details";
			// 
			// pnldataGridView
			// 
			this.pnldataGridView.Controls.Add(this.dgvAddedProducts);
			this.pnldataGridView.Controls.Add(this.lblDGVTitle);
			this.pnldataGridView.Location = new System.Drawing.Point(3, 273);
			this.pnldataGridView.Name = "pnldataGridView";
			this.pnldataGridView.Size = new System.Drawing.Size(690, 424);
			this.pnldataGridView.TabIndex = 7;
			// 
			// dgvAddedProducts
			// 
			this.dgvAddedProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAddedProducts.Location = new System.Drawing.Point(10, 47);
			this.dgvAddedProducts.Name = "dgvAddedProducts";
			this.dgvAddedProducts.Size = new System.Drawing.Size(677, 377);
			this.dgvAddedProducts.TabIndex = 14;
			// 
			// lblDGVTitle
			// 
			this.lblDGVTitle.AutoSize = true;
			this.lblDGVTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDGVTitle.Location = new System.Drawing.Point(9, 14);
			this.lblDGVTitle.Name = "lblDGVTitle";
			this.lblDGVTitle.Size = new System.Drawing.Size(121, 20);
			this.lblDGVTitle.TabIndex = 13;
			this.lblDGVTitle.Text = "Added Products";
			// 
			// pnlCalculation
			// 
			this.pnlCalculation.Controls.Add(this.btnSave);
			this.pnlCalculation.Controls.Add(this.txtReturnAmount);
			this.pnlCalculation.Controls.Add(this.txtPaidAmount);
			this.pnlCalculation.Controls.Add(this.txtGrandTotal);
			this.pnlCalculation.Controls.Add(this.txtVat);
			this.pnlCalculation.Controls.Add(this.txtDiscount);
			this.pnlCalculation.Controls.Add(this.txtSubTotal);
			this.pnlCalculation.Controls.Add(this.lblReturnAmount);
			this.pnlCalculation.Controls.Add(this.lblPaidAmount);
			this.pnlCalculation.Controls.Add(this.lblDiscount);
			this.pnlCalculation.Controls.Add(this.lblVat);
			this.pnlCalculation.Controls.Add(this.lblGrandTotal);
			this.pnlCalculation.Controls.Add(this.lblTotal);
			this.pnlCalculation.Controls.Add(this.lblCalculationTitle);
			this.pnlCalculation.Location = new System.Drawing.Point(699, 273);
			this.pnlCalculation.Name = "pnlCalculation";
			this.pnlCalculation.Size = new System.Drawing.Size(710, 424);
			this.pnlCalculation.TabIndex = 8;
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.Teal;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.Location = new System.Drawing.Point(230, 364);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(385, 52);
			this.btnSave.TabIndex = 30;
			this.btnSave.Text = "SAVE";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// txtReturnAmount
			// 
			this.txtReturnAmount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtReturnAmount.Location = new System.Drawing.Point(171, 293);
			this.txtReturnAmount.Name = "txtReturnAmount";
			this.txtReturnAmount.ReadOnly = true;
			this.txtReturnAmount.Size = new System.Drawing.Size(504, 54);
			this.txtReturnAmount.TabIndex = 29;
			// 
			// txtPaidAmount
			// 
			this.txtPaidAmount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPaidAmount.Location = new System.Drawing.Point(171, 243);
			this.txtPaidAmount.Name = "txtPaidAmount";
			this.txtPaidAmount.Size = new System.Drawing.Size(504, 33);
			this.txtPaidAmount.TabIndex = 28;
			this.txtPaidAmount.TextChanged += new System.EventHandler(this.txtPaidAmount_TextChanged);
			// 
			// txtGrandTotal
			// 
			this.txtGrandTotal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtGrandTotal.Location = new System.Drawing.Point(171, 197);
			this.txtGrandTotal.Name = "txtGrandTotal";
			this.txtGrandTotal.ReadOnly = true;
			this.txtGrandTotal.Size = new System.Drawing.Size(504, 33);
			this.txtGrandTotal.TabIndex = 27;
			// 
			// txtVat
			// 
			this.txtVat.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtVat.Location = new System.Drawing.Point(171, 148);
			this.txtVat.Name = "txtVat";
			this.txtVat.Size = new System.Drawing.Size(504, 33);
			this.txtVat.TabIndex = 26;
			this.txtVat.TextChanged += new System.EventHandler(this.txtVat_TextChanged);
			// 
			// txtDiscount
			// 
			this.txtDiscount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDiscount.Location = new System.Drawing.Point(171, 98);
			this.txtDiscount.Name = "txtDiscount";
			this.txtDiscount.Size = new System.Drawing.Size(504, 33);
			this.txtDiscount.TabIndex = 25;
			this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
			// 
			// txtSubTotal
			// 
			this.txtSubTotal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSubTotal.Location = new System.Drawing.Point(171, 49);
			this.txtSubTotal.Name = "txtSubTotal";
			this.txtSubTotal.ReadOnly = true;
			this.txtSubTotal.Size = new System.Drawing.Size(504, 33);
			this.txtSubTotal.TabIndex = 19;
			this.txtSubTotal.Text = "0";
			// 
			// lblReturnAmount
			// 
			this.lblReturnAmount.AutoSize = true;
			this.lblReturnAmount.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblReturnAmount.Location = new System.Drawing.Point(17, 300);
			this.lblReturnAmount.Name = "lblReturnAmount";
			this.lblReturnAmount.Size = new System.Drawing.Size(109, 20);
			this.lblReturnAmount.TabIndex = 24;
			this.lblReturnAmount.Text = "Return Amount";
			// 
			// lblPaidAmount
			// 
			this.lblPaidAmount.AutoSize = true;
			this.lblPaidAmount.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPaidAmount.Location = new System.Drawing.Point(17, 250);
			this.lblPaidAmount.Name = "lblPaidAmount";
			this.lblPaidAmount.Size = new System.Drawing.Size(94, 20);
			this.lblPaidAmount.TabIndex = 23;
			this.lblPaidAmount.Text = "Paid Amount";
			// 
			// lblDiscount
			// 
			this.lblDiscount.AutoSize = true;
			this.lblDiscount.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDiscount.Location = new System.Drawing.Point(15, 98);
			this.lblDiscount.Name = "lblDiscount";
			this.lblDiscount.Size = new System.Drawing.Size(93, 20);
			this.lblDiscount.TabIndex = 22;
			this.lblDiscount.Text = "Discount (%)";
			// 
			// lblVat
			// 
			this.lblVat.AutoSize = true;
			this.lblVat.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVat.Location = new System.Drawing.Point(15, 148);
			this.lblVat.Name = "lblVat";
			this.lblVat.Size = new System.Drawing.Size(60, 20);
			this.lblVat.TabIndex = 21;
			this.lblVat.Text = "VAT (%)";
			// 
			// lblGrandTotal
			// 
			this.lblGrandTotal.AutoSize = true;
			this.lblGrandTotal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGrandTotal.Location = new System.Drawing.Point(17, 197);
			this.lblGrandTotal.Name = "lblGrandTotal";
			this.lblGrandTotal.Size = new System.Drawing.Size(86, 20);
			this.lblGrandTotal.TabIndex = 20;
			this.lblGrandTotal.Text = "Grand Total";
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotal.Location = new System.Drawing.Point(15, 52);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(71, 20);
			this.lblTotal.TabIndex = 13;
			this.lblTotal.Text = "Sub Total";
			// 
			// lblCalculationTitle
			// 
			this.lblCalculationTitle.AutoSize = true;
			this.lblCalculationTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCalculationTitle.Location = new System.Drawing.Point(15, 14);
			this.lblCalculationTitle.Name = "lblCalculationTitle";
			this.lblCalculationTitle.Size = new System.Drawing.Size(138, 20);
			this.lblCalculationTitle.TabIndex = 19;
			this.lblCalculationTitle.Text = "Calculation Details";
			// 
			// frmPurachseAndSales
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.ClientSize = new System.Drawing.Size(1409, 724);
			this.Controls.Add(this.pnlCalculation);
			this.Controls.Add(this.pnldataGridView);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.pnlDeaCust);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmPurachseAndSales";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Purchase and Sales";
			this.Load += new System.EventHandler(this.frmPurachseAndSales_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.pnlDeaCust.ResumeLayout(false);
			this.pnlDeaCust.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.pnldataGridView.ResumeLayout(false);
			this.pnldataGridView.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvAddedProducts)).EndInit();
			this.pnlCalculation.ResumeLayout(false);
			this.pnlCalculation.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxClose;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblTop;
		private System.Windows.Forms.Panel pnlDeaCust;
		private System.Windows.Forms.Label lblSearch;
		private System.Windows.Forms.Label lblDeaCustTitle;
		private System.Windows.Forms.Label lblAddress;
		private System.Windows.Forms.Label lblBillDate;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblContact;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.DateTimePicker datePicker;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtContact;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox txtQty;
		private System.Windows.Forms.TextBox txtRate;
		private System.Windows.Forms.TextBox txtInventory;
		private System.Windows.Forms.TextBox txtProductName;
		private System.Windows.Forms.TextBox txtSearchProduct;
		private System.Windows.Forms.Label lblQuantity;
		private System.Windows.Forms.Label lblRate;
		private System.Windows.Forms.Label lblInventory;
		private System.Windows.Forms.Label lblProductName;
		private System.Windows.Forms.Label lblProductSearch;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Panel pnldataGridView;
		private System.Windows.Forms.DataGridView dgvAddedProducts;
		private System.Windows.Forms.Label lblDGVTitle;
		private System.Windows.Forms.Panel pnlCalculation;
		private System.Windows.Forms.Label lblReturnAmount;
		private System.Windows.Forms.Label lblPaidAmount;
		private System.Windows.Forms.Label lblDiscount;
		private System.Windows.Forms.Label lblVat;
		private System.Windows.Forms.Label lblGrandTotal;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Label lblCalculationTitle;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.TextBox txtReturnAmount;
		private System.Windows.Forms.TextBox txtPaidAmount;
		private System.Windows.Forms.TextBox txtGrandTotal;
		private System.Windows.Forms.TextBox txtVat;
		private System.Windows.Forms.TextBox txtDiscount;
		private System.Windows.Forms.TextBox txtSubTotal;
	}
}