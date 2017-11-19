namespace Raktar.App.Forms
{
	partial class StockManagerForm
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
			this.btnOK = new MetroFramework.Controls.MetroButton();
			this.gridStock = new Raktar.App.Controls.FixedDataGridView();
			this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panelManage = new MetroFramework.Controls.MetroPanel();
			this.btnUpdate = new MetroFramework.Controls.MetroButton();
			this.tbNumber = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.lblWarehouse = new MetroFramework.Controls.MetroLabel();
			this.lblNumberError = new MetroFramework.Controls.MetroLabel();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			((System.ComponentModel.ISupportInitialize)(this.gridStock)).BeginInit();
			this.panelManage.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.Location = new System.Drawing.Point(518, 473);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(123, 40);
			this.btnOK.TabIndex = 4;
			this.btnOK.Text = "OK";
			this.btnOK.UseSelectable = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
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
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.gridStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gridStock.DefaultCellStyle = dataGridViewCellStyle2;
			this.gridStock.EnableHeadersVisualStyles = false;
			this.gridStock.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.gridStock.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.gridStock.Location = new System.Drawing.Point(23, 63);
			this.gridStock.MultiSelect = false;
			this.gridStock.Name = "gridStock";
			this.gridStock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridStock.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.gridStock.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.gridStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridStock.Size = new System.Drawing.Size(622, 315);
			this.gridStock.TabIndex = 1;
			this.gridStock.SelectionChanged += new System.EventHandler(this.gridStock_SelectionChanged);
			// 
			// dataGridViewTextBoxColumn9
			// 
			this.dataGridViewTextBoxColumn9.HeaderText = "Raktár";
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			this.dataGridViewTextBoxColumn9.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn10
			// 
			this.dataGridViewTextBoxColumn10.HeaderText = "Mennyiség";
			this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
			this.dataGridViewTextBoxColumn10.ReadOnly = true;
			// 
			// panelManage
			// 
			this.panelManage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelManage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelManage.Controls.Add(this.btnUpdate);
			this.panelManage.Controls.Add(this.tbNumber);
			this.panelManage.Controls.Add(this.metroLabel3);
			this.panelManage.Controls.Add(this.lblWarehouse);
			this.panelManage.Controls.Add(this.lblNumberError);
			this.panelManage.Enabled = false;
			this.panelManage.HorizontalScrollbarBarColor = true;
			this.panelManage.HorizontalScrollbarHighlightOnWheel = false;
			this.panelManage.HorizontalScrollbarSize = 10;
			this.panelManage.Location = new System.Drawing.Point(23, 392);
			this.panelManage.Name = "panelManage";
			this.panelManage.Size = new System.Drawing.Size(622, 75);
			this.panelManage.TabIndex = 7;
			this.panelManage.VerticalScrollbarBarColor = true;
			this.panelManage.VerticalScrollbarHighlightOnWheel = false;
			this.panelManage.VerticalScrollbarSize = 10;
			// 
			// btnUpdate
			// 
			this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnUpdate.Enabled = false;
			this.btnUpdate.Location = new System.Drawing.Point(494, 40);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(123, 30);
			this.btnUpdate.TabIndex = 3;
			this.btnUpdate.Text = "Frissítés";
			this.btnUpdate.UseSelectable = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// tbNumber
			// 
			// 
			// 
			// 
			this.tbNumber.CustomButton.Image = null;
			this.tbNumber.CustomButton.Location = new System.Drawing.Point(160, 1);
			this.tbNumber.CustomButton.Name = "";
			this.tbNumber.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.tbNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.tbNumber.CustomButton.TabIndex = 1;
			this.tbNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.tbNumber.CustomButton.UseSelectable = true;
			this.tbNumber.CustomButton.Visible = false;
			this.tbNumber.Lines = new string[0];
			this.tbNumber.Location = new System.Drawing.Point(88, 40);
			this.tbNumber.MaxLength = 32767;
			this.tbNumber.Name = "tbNumber";
			this.tbNumber.PasswordChar = '\0';
			this.tbNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.tbNumber.SelectedText = "";
			this.tbNumber.SelectionLength = 0;
			this.tbNumber.SelectionStart = 0;
			this.tbNumber.ShortcutsEnabled = true;
			this.tbNumber.Size = new System.Drawing.Size(182, 23);
			this.tbNumber.TabIndex = 2;
			this.tbNumber.UseSelectable = true;
			this.tbNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.tbNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.tbNumber.TextChanged += new System.EventHandler(this.tbNumber_TextChanged);
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.Location = new System.Drawing.Point(8, 40);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(78, 19);
			this.metroLabel3.TabIndex = 3;
			this.metroLabel3.Tag = "";
			this.metroLabel3.Text = "Darabszám:";
			// 
			// lblWarehouse
			// 
			this.lblWarehouse.AutoSize = true;
			this.lblWarehouse.Location = new System.Drawing.Point(36, 11);
			this.lblWarehouse.Name = "lblWarehouse";
			this.lblWarehouse.Size = new System.Drawing.Size(50, 19);
			this.lblWarehouse.TabIndex = 2;
			this.lblWarehouse.Tag = "Raktár: {0}";
			this.lblWarehouse.Text = "Raktár:";
			// 
			// lblNumberError
			// 
			this.lblNumberError.AutoSize = true;
			this.lblNumberError.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.lblNumberError.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.lblNumberError.ForeColor = System.Drawing.Color.Red;
			this.lblNumberError.Location = new System.Drawing.Point(272, 38);
			this.lblNumberError.Name = "lblNumberError";
			this.lblNumberError.Size = new System.Drawing.Size(18, 25);
			this.lblNumberError.TabIndex = 20;
			this.lblNumberError.Text = "!";
			this.lblNumberError.Visible = false;
			// 
			// metroLabel1
			// 
			this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(32, 381);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(54, 19);
			this.metroLabel1.TabIndex = 2;
			this.metroLabel1.Text = "Kezelés:";
			// 
			// StockManagerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(668, 536);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.panelManage);
			this.Controls.Add(this.gridStock);
			this.Controls.Add(this.btnOK);
			this.Name = "StockManagerForm";
			this.Text = "Készlet";
			this.Load += new System.EventHandler(this.StockManagerForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridStock)).EndInit();
			this.panelManage.ResumeLayout(false);
			this.panelManage.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroButton btnOK;
		private Raktar.App.Controls.FixedDataGridView gridStock;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
		private MetroFramework.Controls.MetroPanel panelManage;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroLabel lblWarehouse;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroTextBox tbNumber;
		private MetroFramework.Controls.MetroLabel lblNumberError;
		private MetroFramework.Controls.MetroButton btnUpdate;
	}
}