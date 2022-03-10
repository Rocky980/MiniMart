
namespace MiniMart.UI
{
	partial class frmTransactions
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransactions));
			this.pictureBoxClose = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblTop = new System.Windows.Forms.Label();
			this.dgvTransactions = new System.Windows.Forms.DataGridView();
			this.lblTransactionType = new System.Windows.Forms.Label();
			this.cmbTransactionType = new System.Windows.Forms.ComboBox();
			this.btnAll = new System.Windows.Forms.Button();
			this.dgvTransactionDetail = new System.Windows.Forms.DataGridView();
			this.dtp_transaction = new System.Windows.Forms.DateTimePicker();
			this.lblSearch = new System.Windows.Forms.Label();
			this.txtSearch = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvTransactionDetail)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoxClose
			// 
			this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
			this.pictureBoxClose.Location = new System.Drawing.Point(1520, 0);
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
			this.panel1.Size = new System.Drawing.Size(1560, 48);
			this.panel1.TabIndex = 2;
			// 
			// lblTop
			// 
			this.lblTop.AutoSize = true;
			this.lblTop.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTop.Location = new System.Drawing.Point(690, 9);
			this.lblTop.Name = "lblTop";
			this.lblTop.Size = new System.Drawing.Size(165, 30);
			this.lblTop.TabIndex = 0;
			this.lblTop.Text = "TRANSACTIONS";
			// 
			// dgvTransactions
			// 
			this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTransactions.Location = new System.Drawing.Point(12, 147);
			this.dgvTransactions.Name = "dgvTransactions";
			this.dgvTransactions.Size = new System.Drawing.Size(699, 385);
			this.dgvTransactions.TabIndex = 3;
			this.dgvTransactions.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTransactions_RowHeaderMouseClick);
			// 
			// lblTransactionType
			// 
			this.lblTransactionType.AutoSize = true;
			this.lblTransactionType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTransactionType.Location = new System.Drawing.Point(458, 87);
			this.lblTransactionType.Name = "lblTransactionType";
			this.lblTransactionType.Size = new System.Drawing.Size(125, 21);
			this.lblTransactionType.TabIndex = 4;
			this.lblTransactionType.Text = "Transaction Type";
			// 
			// cmbTransactionType
			// 
			this.cmbTransactionType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbTransactionType.FormattingEnabled = true;
			this.cmbTransactionType.Items.AddRange(new object[] {
            "Purchase",
            "Sales"});
			this.cmbTransactionType.Location = new System.Drawing.Point(589, 84);
			this.cmbTransactionType.Name = "cmbTransactionType";
			this.cmbTransactionType.Size = new System.Drawing.Size(379, 29);
			this.cmbTransactionType.TabIndex = 5;
			this.cmbTransactionType.SelectedIndexChanged += new System.EventHandler(this.cmbTransactionType_SelectedIndexChanged);
			// 
			// btnAll
			// 
			this.btnAll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAll.Location = new System.Drawing.Point(1241, 76);
			this.btnAll.Name = "btnAll";
			this.btnAll.Size = new System.Drawing.Size(168, 51);
			this.btnAll.TabIndex = 6;
			this.btnAll.Text = "Show All";
			this.btnAll.UseVisualStyleBackColor = true;
			this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
			// 
			// dgvTransactionDetail
			// 
			this.dgvTransactionDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTransactionDetail.Location = new System.Drawing.Point(717, 147);
			this.dgvTransactionDetail.Name = "dgvTransactionDetail";
			this.dgvTransactionDetail.Size = new System.Drawing.Size(831, 385);
			this.dgvTransactionDetail.TabIndex = 7;
			// 
			// dtp_transaction
			// 
			this.dtp_transaction.Location = new System.Drawing.Point(1015, 92);
			this.dtp_transaction.Name = "dtp_transaction";
			this.dtp_transaction.Size = new System.Drawing.Size(200, 20);
			this.dtp_transaction.TabIndex = 8;
			this.dtp_transaction.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// lblSearch
			// 
			this.lblSearch.AutoSize = true;
			this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSearch.Location = new System.Drawing.Point(8, 87);
			this.lblSearch.Name = "lblSearch";
			this.lblSearch.Size = new System.Drawing.Size(57, 21);
			this.lblSearch.TabIndex = 9;
			this.lblSearch.Text = "Search";
			// 
			// txtSearch
			// 
			this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearch.Location = new System.Drawing.Point(71, 83);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(347, 29);
			this.txtSearch.TabIndex = 10;
			this.txtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// frmTransactions
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.ClientSize = new System.Drawing.Size(1560, 678);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.lblSearch);
			this.Controls.Add(this.dtp_transaction);
			this.Controls.Add(this.dgvTransactionDetail);
			this.Controls.Add(this.btnAll);
			this.Controls.Add(this.cmbTransactionType);
			this.Controls.Add(this.lblTransactionType);
			this.Controls.Add(this.dgvTransactions);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmTransactions";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Transactions";
			this.Load += new System.EventHandler(this.frmTransactions_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvTransactionDetail)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxClose;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblTop;
		private System.Windows.Forms.DataGridView dgvTransactions;
		private System.Windows.Forms.Label lblTransactionType;
		private System.Windows.Forms.ComboBox cmbTransactionType;
		private System.Windows.Forms.Button btnAll;
		private System.Windows.Forms.DataGridView dgvTransactionDetail;
		private System.Windows.Forms.DateTimePicker dtp_transaction;
		private System.Windows.Forms.Label lblSearch;
		private System.Windows.Forms.TextBox txtSearch;
	}
}