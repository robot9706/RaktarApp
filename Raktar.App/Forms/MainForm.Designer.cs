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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tabs = new MetroFramework.Controls.MetroTabControl();
			this.pageWarehouse = new System.Windows.Forms.TabPage();
			this.panelWarehouseTab = new MetroFramework.Controls.MetroPanel();
			this.btnDeleteWarehouse = new MetroFramework.Controls.MetroButton();
			this.btnNewWarehouse = new MetroFramework.Controls.MetroButton();
			this.gridWarehouse = new MetroFramework.Controls.MetroGrid();
			this.warehouseNAme = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.warehouseCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.warehousePostCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.warehouseStreet = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.warehouseStreetNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pageItems = new System.Windows.Forms.TabPage();
			this.panelItems = new System.Windows.Forms.Panel();
			this.gridItems = new MetroFramework.Controls.MetroGrid();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnDeleteItem = new MetroFramework.Controls.MetroButton();
			this.btnNewItem = new MetroFramework.Controls.MetroButton();
			this.tabs.SuspendLayout();
			this.pageWarehouse.SuspendLayout();
			this.panelWarehouseTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridWarehouse)).BeginInit();
			this.pageItems.SuspendLayout();
			this.panelItems.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridItems)).BeginInit();
			this.SuspendLayout();
			// 
			// tabs
			// 
			this.tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabs.Controls.Add(this.pageWarehouse);
			this.tabs.Controls.Add(this.pageItems);
			this.tabs.Location = new System.Drawing.Point(25, 63);
			this.tabs.Name = "tabs";
			this.tabs.SelectedIndex = 1;
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
			// btnDeleteWarehouse
			// 
			this.btnDeleteWarehouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDeleteWarehouse.Enabled = false;
			this.btnDeleteWarehouse.Location = new System.Drawing.Point(704, 466);
			this.btnDeleteWarehouse.Name = "btnDeleteWarehouse";
			this.btnDeleteWarehouse.Size = new System.Drawing.Size(116, 30);
			this.btnDeleteWarehouse.TabIndex = 4;
			this.btnDeleteWarehouse.Text = "Raktár törlése";
			this.btnDeleteWarehouse.UseSelectable = true;
			this.btnDeleteWarehouse.Click += new System.EventHandler(this.btnDeleteWarehouse_Click);
			// 
			// btnNewWarehouse
			// 
			this.btnNewWarehouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNewWarehouse.Location = new System.Drawing.Point(826, 466);
			this.btnNewWarehouse.Name = "btnNewWarehouse";
			this.btnNewWarehouse.Size = new System.Drawing.Size(116, 30);
			this.btnNewWarehouse.TabIndex = 3;
			this.btnNewWarehouse.Text = "Új raktár";
			this.btnNewWarehouse.UseSelectable = true;
			this.btnNewWarehouse.Click += new System.EventHandler(this.btnNewWarehouse_Click);
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
			this.gridWarehouse.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
			// pageItems
			// 
			this.pageItems.Controls.Add(this.panelItems);
			this.pageItems.Location = new System.Drawing.Point(4, 38);
			this.pageItems.Name = "pageItems";
			this.pageItems.Size = new System.Drawing.Size(945, 499);
			this.pageItems.TabIndex = 1;
			this.pageItems.Text = "Cikkek";
			// 
			// panelItems
			// 
			this.panelItems.BackColor = System.Drawing.Color.White;
			this.panelItems.Controls.Add(this.btnDeleteItem);
			this.panelItems.Controls.Add(this.btnNewItem);
			this.panelItems.Controls.Add(this.gridItems);
			this.panelItems.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelItems.Location = new System.Drawing.Point(0, 0);
			this.panelItems.Name = "panelItems";
			this.panelItems.Size = new System.Drawing.Size(945, 499);
			this.panelItems.TabIndex = 1;
			// 
			// gridItems
			// 
			this.gridItems.AllowUserToAddRows = false;
			this.gridItems.AllowUserToDeleteRows = false;
			this.gridItems.AllowUserToResizeRows = false;
			this.gridItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gridItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.gridItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.gridItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.gridItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.gridItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gridItems.DefaultCellStyle = dataGridViewCellStyle5;
			this.gridItems.EnableHeadersVisualStyles = false;
			this.gridItems.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.gridItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.gridItems.Location = new System.Drawing.Point(3, 3);
			this.gridItems.Name = "gridItems";
			this.gridItems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.gridItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.gridItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridItems.Size = new System.Drawing.Size(939, 454);
			this.gridItems.TabIndex = 3;
			this.gridItems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridItems_CellDoubleClick);
			this.gridItems.SelectionChanged += new System.EventHandler(this.gridItems_SelectionChanged);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.HeaderText = "Név";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.HeaderText = "Ár";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.HeaderText = "Kategória";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.HeaderText = "Leírás";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// btnDeleteItem
			// 
			this.btnDeleteItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDeleteItem.Enabled = false;
			this.btnDeleteItem.Location = new System.Drawing.Point(704, 466);
			this.btnDeleteItem.Name = "btnDeleteItem";
			this.btnDeleteItem.Size = new System.Drawing.Size(116, 30);
			this.btnDeleteItem.TabIndex = 6;
			this.btnDeleteItem.Text = "Cikk törlése";
			this.btnDeleteItem.UseSelectable = true;
			this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
			// 
			// btnNewItem
			// 
			this.btnNewItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNewItem.Location = new System.Drawing.Point(826, 466);
			this.btnNewItem.Name = "btnNewItem";
			this.btnNewItem.Size = new System.Drawing.Size(116, 30);
			this.btnNewItem.TabIndex = 5;
			this.btnNewItem.Text = "Új cikk";
			this.btnNewItem.UseSelectable = true;
			this.btnNewItem.Click += new System.EventHandler(this.btnNewItem_Click);
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
			this.pageItems.ResumeLayout(false);
			this.panelItems.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridItems)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroTabControl tabs;
		private System.Windows.Forms.TabPage pageWarehouse;
		private System.Windows.Forms.TabPage pageItems;
		private MetroFramework.Controls.MetroPanel panelWarehouseTab;
		private MetroFramework.Controls.MetroGrid gridWarehouse;
		private MetroFramework.Controls.MetroButton btnDeleteWarehouse;
		private MetroFramework.Controls.MetroButton btnNewWarehouse;
		private System.Windows.Forms.DataGridViewTextBoxColumn warehouseNAme;
		private System.Windows.Forms.DataGridViewTextBoxColumn warehouseCity;
		private System.Windows.Forms.DataGridViewTextBoxColumn warehousePostCode;
		private System.Windows.Forms.DataGridViewTextBoxColumn warehouseStreet;
		private System.Windows.Forms.DataGridViewTextBoxColumn warehouseStreetNumber;
		private System.Windows.Forms.Panel panelItems;
		private MetroFramework.Controls.MetroGrid gridItems;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private MetroFramework.Controls.MetroButton btnDeleteItem;
		private MetroFramework.Controls.MetroButton btnNewItem;
	}
}