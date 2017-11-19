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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tabs = new MetroFramework.Controls.MetroTabControl();
			this.pageWarehouse = new System.Windows.Forms.TabPage();
			this.panelWarehouseTab = new MetroFramework.Controls.MetroPanel();
			this.btnWarehouseEdit = new MetroFramework.Controls.MetroButton();
			this.btnDeleteWarehouse = new MetroFramework.Controls.MetroButton();
			this.btnNewWarehouse = new MetroFramework.Controls.MetroButton();
			this.gridWarehouse = new Raktar.App.Controls.FixedDataGridView();
			this.warehouseNAme = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.warehouseCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.warehousePostCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.warehouseStreet = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.warehouseStreetNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pageItems = new System.Windows.Forms.TabPage();
			this.panelItems = new System.Windows.Forms.Panel();
			this.btnEditItem = new MetroFramework.Controls.MetroButton();
			this.btnDeleteItem = new MetroFramework.Controls.MetroButton();
			this.btnNewItem = new MetroFramework.Controls.MetroButton();
			this.gridItems = new Raktar.App.Controls.FixedDataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pagePartners = new System.Windows.Forms.TabPage();
			this.panelPartners = new MetroFramework.Controls.MetroPanel();
			this.btnEditPartner = new MetroFramework.Controls.MetroButton();
			this.btnDeletePartner = new MetroFramework.Controls.MetroButton();
			this.btnNewPartner = new MetroFramework.Controls.MetroButton();
			this.gridPartners = new Raktar.App.Controls.FixedDataGridView();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnPostCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnStreet = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnStreetNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pageStock = new System.Windows.Forms.TabPage();
			this.panelStock = new System.Windows.Forms.Panel();
			this.btnStockEdit = new MetroFramework.Controls.MetroButton();
			this.gridStock = new Raktar.App.Controls.FixedDataGridView();
			this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabs.SuspendLayout();
			this.pageWarehouse.SuspendLayout();
			this.panelWarehouseTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridWarehouse)).BeginInit();
			this.pageItems.SuspendLayout();
			this.panelItems.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridItems)).BeginInit();
			this.pagePartners.SuspendLayout();
			this.panelPartners.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridPartners)).BeginInit();
			this.pageStock.SuspendLayout();
			this.panelStock.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridStock)).BeginInit();
			this.SuspendLayout();
			// 
			// tabs
			// 
			this.tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabs.Controls.Add(this.pageWarehouse);
			this.tabs.Controls.Add(this.pageItems);
			this.tabs.Controls.Add(this.pagePartners);
			this.tabs.Controls.Add(this.pageStock);
			this.tabs.Location = new System.Drawing.Point(25, 63);
			this.tabs.Name = "tabs";
			this.tabs.SelectedIndex = 3;
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
			this.panelWarehouseTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelWarehouseTab.Controls.Add(this.btnWarehouseEdit);
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
			// btnWarehouseEdit
			// 
			this.btnWarehouseEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnWarehouseEdit.Enabled = false;
			this.btnWarehouseEdit.Location = new System.Drawing.Point(580, 464);
			this.btnWarehouseEdit.Name = "btnWarehouseEdit";
			this.btnWarehouseEdit.Size = new System.Drawing.Size(116, 30);
			this.btnWarehouseEdit.TabIndex = 5;
			this.btnWarehouseEdit.Text = "Raktár szerkesztése";
			this.btnWarehouseEdit.UseSelectable = true;
			this.btnWarehouseEdit.Click += new System.EventHandler(this.btnWarehouseEdit_Click);
			// 
			// btnDeleteWarehouse
			// 
			this.btnDeleteWarehouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDeleteWarehouse.Enabled = false;
			this.btnDeleteWarehouse.Location = new System.Drawing.Point(702, 464);
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
			this.btnNewWarehouse.Location = new System.Drawing.Point(824, 464);
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
			this.gridWarehouse.MultiSelect = false;
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
			this.gridWarehouse.Size = new System.Drawing.Size(937, 452);
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
			this.panelItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelItems.Controls.Add(this.btnEditItem);
			this.panelItems.Controls.Add(this.btnDeleteItem);
			this.panelItems.Controls.Add(this.btnNewItem);
			this.panelItems.Controls.Add(this.gridItems);
			this.panelItems.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelItems.Location = new System.Drawing.Point(0, 0);
			this.panelItems.Name = "panelItems";
			this.panelItems.Size = new System.Drawing.Size(945, 499);
			this.panelItems.TabIndex = 1;
			// 
			// btnEditItem
			// 
			this.btnEditItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEditItem.Enabled = false;
			this.btnEditItem.Location = new System.Drawing.Point(580, 464);
			this.btnEditItem.Name = "btnEditItem";
			this.btnEditItem.Size = new System.Drawing.Size(116, 30);
			this.btnEditItem.TabIndex = 7;
			this.btnEditItem.Text = "Cikk szerkesztése";
			this.btnEditItem.UseSelectable = true;
			this.btnEditItem.Click += new System.EventHandler(this.btnEditItem_Click);
			// 
			// btnDeleteItem
			// 
			this.btnDeleteItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDeleteItem.Enabled = false;
			this.btnDeleteItem.Location = new System.Drawing.Point(702, 464);
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
			this.btnNewItem.Location = new System.Drawing.Point(824, 464);
			this.btnNewItem.Name = "btnNewItem";
			this.btnNewItem.Size = new System.Drawing.Size(116, 30);
			this.btnNewItem.TabIndex = 5;
			this.btnNewItem.Text = "Új cikk";
			this.btnNewItem.UseSelectable = true;
			this.btnNewItem.Click += new System.EventHandler(this.btnNewItem_Click);
			// 
			// gridItems
			// 
			this.gridItems.AllowUserToAddRows = false;
			this.gridItems.AllowUserToDeleteRows = false;
			this.gridItems.AllowUserToResizeRows = false;
			this.gridItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
			this.gridItems.MultiSelect = false;
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
			// pagePartners
			// 
			this.pagePartners.Controls.Add(this.panelPartners);
			this.pagePartners.Location = new System.Drawing.Point(4, 38);
			this.pagePartners.Name = "pagePartners";
			this.pagePartners.Size = new System.Drawing.Size(945, 499);
			this.pagePartners.TabIndex = 2;
			this.pagePartners.Text = "Partnerek";
			// 
			// panelPartners
			// 
			this.panelPartners.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelPartners.Controls.Add(this.btnEditPartner);
			this.panelPartners.Controls.Add(this.btnDeletePartner);
			this.panelPartners.Controls.Add(this.btnNewPartner);
			this.panelPartners.Controls.Add(this.gridPartners);
			this.panelPartners.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelPartners.HorizontalScrollbarBarColor = true;
			this.panelPartners.HorizontalScrollbarHighlightOnWheel = false;
			this.panelPartners.HorizontalScrollbarSize = 10;
			this.panelPartners.Location = new System.Drawing.Point(0, 0);
			this.panelPartners.Name = "panelPartners";
			this.panelPartners.Size = new System.Drawing.Size(945, 499);
			this.panelPartners.TabIndex = 1;
			this.panelPartners.VerticalScrollbarBarColor = true;
			this.panelPartners.VerticalScrollbarHighlightOnWheel = false;
			this.panelPartners.VerticalScrollbarSize = 10;
			// 
			// btnEditPartner
			// 
			this.btnEditPartner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEditPartner.Enabled = false;
			this.btnEditPartner.Location = new System.Drawing.Point(580, 464);
			this.btnEditPartner.Name = "btnEditPartner";
			this.btnEditPartner.Size = new System.Drawing.Size(116, 30);
			this.btnEditPartner.TabIndex = 9;
			this.btnEditPartner.Text = "Partner szerkesztése";
			this.btnEditPartner.UseSelectable = true;
			this.btnEditPartner.Click += new System.EventHandler(this.btnEditPartner_Click);
			// 
			// btnDeletePartner
			// 
			this.btnDeletePartner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDeletePartner.Enabled = false;
			this.btnDeletePartner.Location = new System.Drawing.Point(702, 464);
			this.btnDeletePartner.Name = "btnDeletePartner";
			this.btnDeletePartner.Size = new System.Drawing.Size(116, 30);
			this.btnDeletePartner.TabIndex = 8;
			this.btnDeletePartner.Text = "Partner törlése";
			this.btnDeletePartner.UseSelectable = true;
			this.btnDeletePartner.Click += new System.EventHandler(this.btnDeletePartner_Click);
			// 
			// btnNewPartner
			// 
			this.btnNewPartner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNewPartner.Location = new System.Drawing.Point(824, 464);
			this.btnNewPartner.Name = "btnNewPartner";
			this.btnNewPartner.Size = new System.Drawing.Size(116, 30);
			this.btnNewPartner.TabIndex = 7;
			this.btnNewPartner.Text = "Új partner";
			this.btnNewPartner.UseSelectable = true;
			this.btnNewPartner.Click += new System.EventHandler(this.btnNewPartner_Click);
			// 
			// gridPartners
			// 
			this.gridPartners.AllowUserToAddRows = false;
			this.gridPartners.AllowUserToDeleteRows = false;
			this.gridPartners.AllowUserToResizeRows = false;
			this.gridPartners.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridPartners.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gridPartners.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.gridPartners.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.gridPartners.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.gridPartners.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridPartners.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.gridPartners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridPartners.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.columnPostCode,
            this.columnStreet,
            this.columnStreetNum});
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gridPartners.DefaultCellStyle = dataGridViewCellStyle8;
			this.gridPartners.EnableHeadersVisualStyles = false;
			this.gridPartners.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.gridPartners.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.gridPartners.Location = new System.Drawing.Point(3, 3);
			this.gridPartners.MultiSelect = false;
			this.gridPartners.Name = "gridPartners";
			this.gridPartners.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridPartners.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
			this.gridPartners.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.gridPartners.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridPartners.Size = new System.Drawing.Size(939, 454);
			this.gridPartners.TabIndex = 4;
			this.gridPartners.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPartners_CellDoubleClick);
			this.gridPartners.SelectionChanged += new System.EventHandler(this.gridPartners_SelectionChanged);
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.HeaderText = "Név";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.HeaderText = "Telefon";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.HeaderText = "Email";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn7.ReadOnly = true;
			this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.HeaderText = "Város";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			this.dataGridViewTextBoxColumn8.ReadOnly = true;
			// 
			// columnPostCode
			// 
			this.columnPostCode.HeaderText = "Irányítószám";
			this.columnPostCode.Name = "columnPostCode";
			this.columnPostCode.ReadOnly = true;
			// 
			// columnStreet
			// 
			this.columnStreet.HeaderText = "Utca";
			this.columnStreet.Name = "columnStreet";
			this.columnStreet.ReadOnly = true;
			// 
			// columnStreetNum
			// 
			this.columnStreetNum.HeaderText = "Házszám";
			this.columnStreetNum.Name = "columnStreetNum";
			this.columnStreetNum.ReadOnly = true;
			// 
			// pageStock
			// 
			this.pageStock.Controls.Add(this.panelStock);
			this.pageStock.Location = new System.Drawing.Point(4, 38);
			this.pageStock.Name = "pageStock";
			this.pageStock.Size = new System.Drawing.Size(945, 499);
			this.pageStock.TabIndex = 3;
			this.pageStock.Text = "Készlet";
			// 
			// panelStock
			// 
			this.panelStock.BackColor = System.Drawing.Color.White;
			this.panelStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelStock.Controls.Add(this.btnStockEdit);
			this.panelStock.Controls.Add(this.gridStock);
			this.panelStock.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelStock.Location = new System.Drawing.Point(0, 0);
			this.panelStock.Name = "panelStock";
			this.panelStock.Size = new System.Drawing.Size(945, 499);
			this.panelStock.TabIndex = 1;
			// 
			// btnStockEdit
			// 
			this.btnStockEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnStockEdit.Enabled = false;
			this.btnStockEdit.Location = new System.Drawing.Point(824, 464);
			this.btnStockEdit.Name = "btnStockEdit";
			this.btnStockEdit.Size = new System.Drawing.Size(116, 30);
			this.btnStockEdit.TabIndex = 8;
			this.btnStockEdit.Text = "Kezelés/Részletek";
			this.btnStockEdit.UseSelectable = true;
			this.btnStockEdit.Click += new System.EventHandler(this.btnStockEdit_Click);
			// 
			// gridStock
			// 
			this.gridStock.AllowUserToAddRows = false;
			this.gridStock.AllowUserToDeleteRows = false;
			this.gridStock.AllowUserToResizeRows = false;
			this.gridStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gridStock.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.gridStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.gridStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.gridStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
			this.gridStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gridStock.DefaultCellStyle = dataGridViewCellStyle11;
			this.gridStock.EnableHeadersVisualStyles = false;
			this.gridStock.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.gridStock.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.gridStock.Location = new System.Drawing.Point(3, 3);
			this.gridStock.MultiSelect = false;
			this.gridStock.Name = "gridStock";
			this.gridStock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridStock.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
			this.gridStock.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.gridStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridStock.Size = new System.Drawing.Size(939, 454);
			this.gridStock.TabIndex = 5;
			this.gridStock.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridStock_CellDoubleClick);
			this.gridStock.SelectionChanged += new System.EventHandler(this.gridStock_SelectionChanged);
			// 
			// dataGridViewTextBoxColumn9
			// 
			this.dataGridViewTextBoxColumn9.HeaderText = "Cikk";
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			this.dataGridViewTextBoxColumn9.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn10
			// 
			this.dataGridViewTextBoxColumn10.HeaderText = "Mennyiség";
			this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
			this.dataGridViewTextBoxColumn10.ReadOnly = true;
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
			this.pagePartners.ResumeLayout(false);
			this.panelPartners.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridPartners)).EndInit();
			this.pageStock.ResumeLayout(false);
			this.panelStock.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridStock)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroTabControl tabs;
		private System.Windows.Forms.TabPage pageWarehouse;
		private System.Windows.Forms.TabPage pageItems;
		private MetroFramework.Controls.MetroPanel panelWarehouseTab;
		private Raktar.App.Controls.FixedDataGridView gridWarehouse;
		private System.Windows.Forms.DataGridViewTextBoxColumn warehouseNAme;
		private System.Windows.Forms.DataGridViewTextBoxColumn warehouseCity;
		private System.Windows.Forms.DataGridViewTextBoxColumn warehousePostCode;
		private System.Windows.Forms.DataGridViewTextBoxColumn warehouseStreet;
		private System.Windows.Forms.DataGridViewTextBoxColumn warehouseStreetNumber;
		private System.Windows.Forms.Panel panelItems;
		private Raktar.App.Controls.FixedDataGridView gridItems;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private MetroFramework.Controls.MetroButton btnDeleteItem;
		private MetroFramework.Controls.MetroButton btnNewItem;
		private System.Windows.Forms.TabPage pagePartners;
		private MetroFramework.Controls.MetroPanel panelPartners;
		private Raktar.App.Controls.FixedDataGridView gridPartners;
		private MetroFramework.Controls.MetroButton btnDeleteWarehouse;
		private MetroFramework.Controls.MetroButton btnNewWarehouse;
		private MetroFramework.Controls.MetroButton btnDeletePartner;
		private MetroFramework.Controls.MetroButton btnNewPartner;
		private System.Windows.Forms.TabPage pageStock;
		private System.Windows.Forms.Panel panelStock;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnPostCode;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnStreet;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnStreetNum;
		private Raktar.App.Controls.FixedDataGridView gridStock;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
		private MetroFramework.Controls.MetroButton btnWarehouseEdit;
		private MetroFramework.Controls.MetroButton btnEditItem;
		private MetroFramework.Controls.MetroButton btnEditPartner;
		private MetroFramework.Controls.MetroButton btnStockEdit;
	}
}