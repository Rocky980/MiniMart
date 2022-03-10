
namespace MiniMart
{
	partial class frmAdminDashboard
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.panelFooter = new System.Windows.Forms.Panel();
			this.lblFooter = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dealerAndCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lblUser = new System.Windows.Forms.Label();
			this.lblLoggedInUser = new System.Windows.Forms.Label();
			this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.dd = new System.Windows.Forms.DateTimePicker();
			this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.panelFooter.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
			this.SuspendLayout();
			// 
			// panelFooter
			// 
			this.panelFooter.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.panelFooter.Controls.Add(this.lblFooter);
			this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelFooter.Location = new System.Drawing.Point(0, 777);
			this.panelFooter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.panelFooter.Name = "panelFooter";
			this.panelFooter.Size = new System.Drawing.Size(1501, 43);
			this.panelFooter.TabIndex = 0;
			// 
			// lblFooter
			// 
			this.lblFooter.AutoSize = true;
			this.lblFooter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFooter.ForeColor = System.Drawing.Color.White;
			this.lblFooter.Location = new System.Drawing.Point(847, 13);
			this.lblFooter.Name = "lblFooter";
			this.lblFooter.Size = new System.Drawing.Size(78, 21);
			this.lblFooter.TabIndex = 0;
			this.lblFooter.Text = "Mini Mart";
			this.lblFooter.Click += new System.EventHandler(this.lblFooter_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.categoryToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.transactionsToolStripMenuItem,
            this.dealerAndCustomerToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1501, 33);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// usersToolStripMenuItem
			// 
			this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
			this.usersToolStripMenuItem.Size = new System.Drawing.Size(70, 29);
			this.usersToolStripMenuItem.Text = "Users";
			this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
			// 
			// categoryToolStripMenuItem
			// 
			this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
			this.categoryToolStripMenuItem.Size = new System.Drawing.Size(100, 29);
			this.categoryToolStripMenuItem.Text = "Category";
			this.categoryToolStripMenuItem.Click += new System.EventHandler(this.categoryToolStripMenuItem_Click);
			// 
			// productsToolStripMenuItem
			// 
			this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
			this.productsToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
			this.productsToolStripMenuItem.Text = "Products";
			this.productsToolStripMenuItem.Click += new System.EventHandler(this.productsToolStripMenuItem_Click);
			// 
			// inventoryToolStripMenuItem
			// 
			this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
			this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(103, 29);
			this.inventoryToolStripMenuItem.Text = "Inventory";
			this.inventoryToolStripMenuItem.Click += new System.EventHandler(this.inventoryToolStripMenuItem_Click);
			// 
			// transactionsToolStripMenuItem
			// 
			this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
			this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(128, 29);
			this.transactionsToolStripMenuItem.Text = "Transactions";
			this.transactionsToolStripMenuItem.Click += new System.EventHandler(this.transactionsToolStripMenuItem_Click);
			// 
			// dealerAndCustomerToolStripMenuItem
			// 
			this.dealerAndCustomerToolStripMenuItem.Name = "dealerAndCustomerToolStripMenuItem";
			this.dealerAndCustomerToolStripMenuItem.Size = new System.Drawing.Size(202, 29);
			this.dealerAndCustomerToolStripMenuItem.Text = "Dealer and Customer";
			this.dealerAndCustomerToolStripMenuItem.Click += new System.EventHandler(this.dealerAndCustomerToolStripMenuItem_Click);
			// 
			// lblUser
			// 
			this.lblUser.AutoSize = true;
			this.lblUser.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUser.Location = new System.Drawing.Point(44, 98);
			this.lblUser.Name = "lblUser";
			this.lblUser.Size = new System.Drawing.Size(41, 20);
			this.lblUser.TabIndex = 2;
			this.lblUser.Text = "User:";
			// 
			// lblLoggedInUser
			// 
			this.lblLoggedInUser.AutoSize = true;
			this.lblLoggedInUser.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLoggedInUser.ForeColor = System.Drawing.Color.LimeGreen;
			this.lblLoggedInUser.Location = new System.Drawing.Point(91, 98);
			this.lblLoggedInUser.Name = "lblLoggedInUser";
			this.lblLoggedInUser.Size = new System.Drawing.Size(0, 20);
			this.lblLoggedInUser.TabIndex = 3;
			// 
			// chart
			// 
			chartArea1.Name = "ChartArea1";
			this.chart.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chart.Legends.Add(legend1);
			this.chart.Location = new System.Drawing.Point(199, 159);
			this.chart.Name = "chart";
			this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Transaction";
			this.chart.Series.Add(series1);
			this.chart.Size = new System.Drawing.Size(726, 598);
			this.chart.TabIndex = 4;
			this.chart.Text = "chart1";
			this.chart.Click += new System.EventHandler(this.chart_Click);
			// 
			// dd
			// 
			this.dd.Location = new System.Drawing.Point(287, 102);
			this.dd.Name = "dd";
			this.dd.Size = new System.Drawing.Size(245, 25);
			this.dd.TabIndex = 7;
			this.dd.ValueChanged += new System.EventHandler(this.dd_ValueChanged);
			// 
			// chart2
			// 
			this.chart2.BorderlineColor = System.Drawing.Color.Black;
			chartArea2.Name = "ChartArea1";
			this.chart2.ChartAreas.Add(chartArea2);
			legend2.Name = "Legend1";
			this.chart2.Legends.Add(legend2);
			this.chart2.Location = new System.Drawing.Point(984, 159);
			this.chart2.Name = "chart2";
			this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
			series2.BorderColor = System.Drawing.Color.White;
			series2.ChartArea = "ChartArea1";
			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series2.LabelBackColor = System.Drawing.Color.White;
			series2.LabelBorderColor = System.Drawing.Color.White;
			series2.Legend = "Legend1";
			series2.Name = "Profit";
			this.chart2.Series.Add(series2);
			this.chart2.Size = new System.Drawing.Size(710, 598);
			this.chart2.TabIndex = 15;
			this.chart2.Text = "chart1";
			// 
			// frmAdminDashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1501, 820);
			this.Controls.Add(this.chart2);
			this.Controls.Add(this.dd);
			this.Controls.Add(this.chart);
			this.Controls.Add(this.lblLoggedInUser);
			this.Controls.Add(this.lblUser);
			this.Controls.Add(this.panelFooter);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "frmAdminDashboard";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AdminDashboard";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAdminDashboard_FormClosed);
			this.Load += new System.EventHandler(this.frmAdminDashboard_Load);
			this.panelFooter.ResumeLayout(false);
			this.panelFooter.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panelFooter;
		private System.Windows.Forms.Label lblFooter;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
		private System.Windows.Forms.Label lblUser;
		private System.Windows.Forms.Label lblLoggedInUser;
		private System.Windows.Forms.ToolStripMenuItem dealerAndCustomerToolStripMenuItem;
		private System.Windows.Forms.DateTimePicker dd;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
	}
}

