namespace Raktar.App.Forms
{
	partial class MainForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tabs = new MetroFramework.Controls.MetroTabControl();
			this.pageWarehouse = new System.Windows.Forms.TabPage();
			this.panelWarehouseTab = new MetroFramework.Controls.MetroPanel();
			this.page2 = new System.Windows.Forms.TabPage();
			this.gridWarehouse = new MetroFramework.Controls.MetroGrid();
			this.btnNewWarehouse = new MetroFramework.Controls.MetroButton();
			this.btnDeleteWarehouse = new MetroFramework.Controls.MetroButton();
			this.warehouseNAme = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.warehouseCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.warehousePostCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.warehouseStreet = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.warehouseStreetNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabs.SuspendLayout();
			this.pageWarehouse.SuspendLayout();
			this.panelWarehouseTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridWarehouse)).BeginInit();
			this.SuspendLayout();
			// 
			// tabs
			// 
			this.tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabs.Controls.Add(this.pageWarehouse);
			this.tabs.Controls.Add(this.page2);
			this.tabs.Location = new System.Drawing.Point(25, 63);
			this.tabs.Name = "tabs";
			this.tabs.SelectedIndex = 0;
			this.tabs.Size = new System.Drawing.Size(953, 541);
			this.tabs.TabIndex = 0;
			this.tabs.UseSelectable = true;
			// 
			// pageWarehouse
			// 
			this.pageWarehouse.Controls.Add(this.panelWarehouseTab);
			this.pageWarehouse.Location = new System.Drawing.Point(4, 38);
			this.pageWarehouse.Name = "pageWarehouse";
			this.pageWarehouse.Size = new System.Drawing.Size(945, 499);
			this.pageWarehouse.TabIndex = 0;
			this.pageWarehouse.Text = "Raktárak";
			// 
			// panelWarehouseTab
			// 
			this.panelWarehouseTab.Controls.Add(this.btnDeleteWarehouse);
			this.panelWarehouseTab.Controls.Add(this.btnNewWarehouse);
			this.panelWarehouseTab.Controls.Add(this.gridWarehouse);
			this.panelWarehouseTab.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelWarehouseTab.HorizontalScrollbarBarColor = true;
			this.panelWarehouseTab.HorizontalScrollbarHighlightOnWheel = false;
			this.panelWarehouseTab.HorizontalScrollbarSize = 10;
			this.panelWarehouseTab.Location = new System.Drawing.Point(0, 0);
			this.panelWarehouseTab.Name = "panelWarehouseTab";
			this.panelWarehouseTab.Size = new System.Drawing.Size(945, 499);
			this.panelWarehouseTab.TabIndex = 1;
			this.panelWarehouseTab.VerticalScrollbarBarColor = true;
			this.panelWarehouseTab.VerticalScrollbarHighlightOnWheel = false;
			this.panelWarehouseTab.VerticalScrollbarSize = 10;
			// 
			// page2
			// 
			this.page2.Location = new System.Drawing.Point(4, 38);
			this.page2.Name = "page2";
			this.page2.Size = new System.Drawing.Size(945, 499);
			this.page2.TabIndex = 1;
			this.page2.Text = "tabPage2";
			// 
			// gridWarehouse
			// 
			this.gridWarehouse.AllowUserToAddRows = false;
			this.gridWarehouse.AllowUserToDeleteRows = false;
			this.gridWarehouse.AllowUserToResizeRows = false;
			this.gridWarehouse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridWarehouse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gridWarehouse.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.gridWarehouse.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.gridWarehouse.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridWarehouse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.gridWarehouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridWarehouse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.warehouseNAme,
            this.warehouseCity,
            this.warehousePostCode,
            this.warehouseStreet,
            this.warehouseStreetNumber});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gridWarehouse.DefaultCellStyle = dataGridViewCellStyle2;
			this.gridWarehouse.EnableHeadersVisualStyles = false;
			this.gridWarehouse.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.gridWarehouse.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.gridWarehouse.Location = new System.Drawing.Point(3, 3);
			this.gridWarehouse.Name = "gridWarehouse";
			this.gridWarehouse.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridWarehouse.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.gridWarehouse.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.gridWarehouse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridWarehouse.Size = new System.Drawing.Size(939, 454);
			this.gridWarehouse.TabIndex = 2;
			this.gridWarehouse.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridWarehouse_CellDoubleClick);
			this.gridWarehouse.SelectionChanged += new System.EventHandler(this.gridWarehouse_SelectionChanged);
			// 
			// btnNewWarehouse
			// 
			this.btnNewWarehouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNewWarehouse.Location = new System.Drawing.Point(826, 462);
			this.btnNewWarehouse.Name = "btnNewWarehouse";
			this.btnNewWarehouse.Size = new System.Drawing.Size(116, 30);
			this.btnNewWarehouse.TabIndex = 3;
			this.btnNewWarehouse.Text = "Új raktár";
			this.btnNewWarehouse.UseSelectable = true;
			this.btnNewWarehouse.Click += new System.EventHandler(this.btnNewWarehouse_Click);
			// 
			// btnDeleteWarehouse
			// 
			this.btnDeleteWarehouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDeleteWarehouse.Enabled = false;
			this.btnDeleteWarehouse.Location = new System.Drawing.Point(704, 462);
			this.btnDeleteWarehouse.Name = "btnDeleteWarehouse";
			this.btnDeleteWarehouse.Size = new System.Drawing.Size(116, 30);
			this.btnDeleteWarehouse.TabIndex = 4;
			this.btnDeleteWarehouse.Text = "Raktár törlése";
			this.btnDeleteWarehouse.UseSelectable = true;
			this.btnDeleteWarehouse.Click += new System.EventHandler(this.btnDeleteWarehouse_Click);
			// 
			// warehouseNAme
			// 
			this.warehouseNAme.HeaderText = "Név";
			this.warehouseNAme.Name = "warehouseNAme";
			this.warehouseNAme.ReadOnly = true;
			// 
			// warehouseCity
			// 
			this.warehouseCity.HeaderText = "Város";
			this.warehouseCity.Name = "warehouseCity";
			this.warehouseCity.ReadOnly = true;
			// 
			// warehousePostCode
			// 
			this.warehousePostCode.HeaderText = "Irányítószám";
			this.warehousePostCode.Name = "warehousePostCode";
			this.warehousePostCode.ReadOnly = true;
			this.warehousePostCode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.warehousePostCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// warehouseStreet
			// 
			this.warehouseStreet.HeaderText = "Utca";
			this.warehouseStreet.Name = "warehouseStreet";
			this.warehouseStreet.ReadOnly = true;
			// 
			// warehouseStreetNumber
			// 
			this.warehouseStreetNumber.HeaderText = "Házszám";
			this.warehouseStreetNumber.Name = "warehouseStreetNumber";
			this.warehouseStreetNumber.ReadOnly = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1001, 627);
			this.Controls.Add(this.tabs);
			this.Name = "MainForm";
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
			this.Text = "MainForm";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.tabs.ResumeLayout(false);
			this.pageWarehouse.ResumeLayout(false);
			this.panelWarehouseTab.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridWarehouse)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroTabControl tabs;
		private System.Windows.Forms.TabPage pageWarehouse;
		private System.Windows.Forms.TabPage page2;
		private MetroFramework.Controls.MetroPanel panelWarehouseTab;
		private MetroFramework.Controls.MetroGrid gridWarehouse;
		private MetroFramework.Controls.MetroButton btnDeleteWarehouse;
		private MetroFramework.Controls.MetroButton btnNewWarehouse;
		private System.Windows.Forms.DataGridViewTextBoxColumn warehouseNAme;
		private System.Windows.Forms.DataGridViewTextBoxColumn warehouseCity;
		private System.Windows.Forms.DataGridViewTextBoxColumn warehousePostCode;
		private System.Windows.Forms.DataGridViewTextBoxColumn warehouseStreet;
		private System.Windows.Forms.DataGridViewTextBoxColumn warehouseStreetNumber;
	}
}