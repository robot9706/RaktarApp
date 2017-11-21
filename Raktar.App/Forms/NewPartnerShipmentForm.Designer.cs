namespace Raktar.App.Forms
{
	partial class NewPartnerShipmentForm
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
			this.btnCancel = new MetroFramework.Controls.MetroButton();
			this.btnShip = new MetroFramework.Controls.MetroButton();
			this.lblCountError = new MetroFramework.Controls.MetroLabel();
			this.tbCount = new MetroFramework.Controls.MetroTextBox();
			this.dateTime = new MetroFramework.Controls.MetroDateTime();
			this.cbPartner = new MetroFramework.Controls.MetroComboBox();
			this.cbWarehouse = new MetroFramework.Controls.MetroComboBox();
			this.cbItem = new MetroFramework.Controls.MetroComboBox();
			this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.cbSell = new MetroFramework.Controls.MetroCheckBox();
			this.SuspendLayout();
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.Location = new System.Drawing.Point(279, 229);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(133, 40);
			this.btnCancel.TabIndex = 20;
			this.btnCancel.Text = "Mégse";
			this.btnCancel.UseSelectable = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnShip
			// 
			this.btnShip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnShip.Enabled = false;
			this.btnShip.Location = new System.Drawing.Point(418, 229);
			this.btnShip.Name = "btnShip";
			this.btnShip.Size = new System.Drawing.Size(133, 40);
			this.btnShip.TabIndex = 19;
			this.btnShip.Text = "Új szállítmány";
			this.btnShip.UseSelectable = true;
			this.btnShip.Click += new System.EventHandler(this.btnShip_Click);
			// 
			// lblCountError
			// 
			this.lblCountError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblCountError.AutoSize = true;
			this.lblCountError.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.lblCountError.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.lblCountError.ForeColor = System.Drawing.Color.Red;
			this.lblCountError.Location = new System.Drawing.Point(553, 130);
			this.lblCountError.Name = "lblCountError";
			this.lblCountError.Size = new System.Drawing.Size(18, 25);
			this.lblCountError.TabIndex = 17;
			this.lblCountError.Text = "!";
			this.lblCountError.Visible = false;
			// 
			// tbCount
			// 
			this.tbCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// 
			// 
			this.tbCount.CustomButton.Image = null;
			this.tbCount.CustomButton.Location = new System.Drawing.Point(178, 1);
			this.tbCount.CustomButton.Name = "";
			this.tbCount.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.tbCount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.tbCount.CustomButton.TabIndex = 1;
			this.tbCount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.tbCount.CustomButton.UseSelectable = true;
			this.tbCount.CustomButton.Visible = false;
			this.tbCount.Lines = new string[0];
			this.tbCount.Location = new System.Drawing.Point(351, 131);
			this.tbCount.MaxLength = 32767;
			this.tbCount.Name = "tbCount";
			this.tbCount.PasswordChar = '\0';
			this.tbCount.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.tbCount.SelectedText = "";
			this.tbCount.SelectionLength = 0;
			this.tbCount.SelectionStart = 0;
			this.tbCount.ShortcutsEnabled = true;
			this.tbCount.Size = new System.Drawing.Size(200, 23);
			this.tbCount.TabIndex = 10;
			this.tbCount.UseSelectable = true;
			this.tbCount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.tbCount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.tbCount.TextChanged += new System.EventHandler(this.tbCount_TextChanged);
			// 
			// dateTime
			// 
			this.dateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTime.Location = new System.Drawing.Point(351, 82);
			this.dateTime.MinimumSize = new System.Drawing.Size(0, 29);
			this.dateTime.Name = "dateTime";
			this.dateTime.Size = new System.Drawing.Size(200, 29);
			this.dateTime.TabIndex = 9;
			this.dateTime.ValueChanged += new System.EventHandler(this.dateTime_ValueChanged);
			// 
			// cbPartner
			// 
			this.cbPartner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbPartner.FormattingEnabled = true;
			this.cbPartner.ItemHeight = 23;
			this.cbPartner.Location = new System.Drawing.Point(85, 165);
			this.cbPartner.Name = "cbPartner";
			this.cbPartner.Size = new System.Drawing.Size(196, 29);
			this.cbPartner.TabIndex = 8;
			this.cbPartner.UseSelectable = true;
			this.cbPartner.SelectedIndexChanged += new System.EventHandler(this.cbWarehouse_SelectedIndexChanged);
			// 
			// cbWarehouse
			// 
			this.cbWarehouse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbWarehouse.Enabled = false;
			this.cbWarehouse.FormattingEnabled = true;
			this.cbWarehouse.ItemHeight = 23;
			this.cbWarehouse.Location = new System.Drawing.Point(85, 126);
			this.cbWarehouse.Name = "cbWarehouse";
			this.cbWarehouse.Size = new System.Drawing.Size(196, 29);
			this.cbWarehouse.TabIndex = 7;
			this.cbWarehouse.UseSelectable = true;
			this.cbWarehouse.SelectedIndexChanged += new System.EventHandler(this.cbWarehouse_SelectedIndexChanged);
			// 
			// cbItem
			// 
			this.cbItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbItem.FormattingEnabled = true;
			this.cbItem.ItemHeight = 23;
			this.cbItem.Location = new System.Drawing.Point(85, 82);
			this.cbItem.Name = "cbItem";
			this.cbItem.Size = new System.Drawing.Size(196, 29);
			this.cbItem.TabIndex = 6;
			this.cbItem.UseSelectable = true;
			this.cbItem.SelectedIndexChanged += new System.EventHandler(this.cbItem_SelectedIndexChanged);
			// 
			// metroLabel6
			// 
			this.metroLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.metroLabel6.AutoSize = true;
			this.metroLabel6.Location = new System.Drawing.Point(300, 170);
			this.metroLabel6.Name = "metroLabel6";
			this.metroLabel6.Size = new System.Drawing.Size(49, 19);
			this.metroLabel6.TabIndex = 5;
			this.metroLabel6.Text = "Eladás:";
			// 
			// metroLabel5
			// 
			this.metroLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.metroLabel5.AutoSize = true;
			this.metroLabel5.Location = new System.Drawing.Point(301, 131);
			this.metroLabel5.Name = "metroLabel5";
			this.metroLabel5.Size = new System.Drawing.Size(48, 19);
			this.metroLabel5.TabIndex = 4;
			this.metroLabel5.Text = "Darab:";
			// 
			// metroLabel4
			// 
			this.metroLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.metroLabel4.AutoSize = true;
			this.metroLabel4.Location = new System.Drawing.Point(298, 87);
			this.metroLabel4.Name = "metroLabel4";
			this.metroLabel4.Size = new System.Drawing.Size(51, 19);
			this.metroLabel4.TabIndex = 3;
			this.metroLabel4.Text = "Dátum:";
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.Location = new System.Drawing.Point(32, 131);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(50, 19);
			this.metroLabel3.TabIndex = 2;
			this.metroLabel3.Text = "Raktár:";
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(26, 170);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(56, 19);
			this.metroLabel2.TabIndex = 1;
			this.metroLabel2.Text = "Partner:";
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(46, 87);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(36, 19);
			this.metroLabel1.TabIndex = 0;
			this.metroLabel1.Text = "Cikk:";
			// 
			// cbSell
			// 
			this.cbSell.Location = new System.Drawing.Point(351, 166);
			this.cbSell.Name = "cbSell";
			this.cbSell.Size = new System.Drawing.Size(34, 29);
			this.cbSell.TabIndex = 21;
			this.cbSell.UseSelectable = true;
			this.cbSell.CheckedChanged += new System.EventHandler(this.cbSell_CheckedChanged);
			// 
			// NewPartnerShipmentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(599, 294);
			this.Controls.Add(this.cbSell);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnShip);
			this.Controls.Add(this.tbCount);
			this.Controls.Add(this.dateTime);
			this.Controls.Add(this.cbPartner);
			this.Controls.Add(this.cbWarehouse);
			this.Controls.Add(this.cbItem);
			this.Controls.Add(this.metroLabel6);
			this.Controls.Add(this.metroLabel5);
			this.Controls.Add(this.metroLabel4);
			this.Controls.Add(this.metroLabel3);
			this.Controls.Add(this.metroLabel2);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.lblCountError);
			this.Name = "NewPartnerShipmentForm";
			this.Text = "Új szállítmány partnernak";
			this.Load += new System.EventHandler(this.NewPartnerShipmentForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroLabel metroLabel4;
		private MetroFramework.Controls.MetroLabel metroLabel5;
		private MetroFramework.Controls.MetroLabel metroLabel6;
		private MetroFramework.Controls.MetroComboBox cbItem;
		private MetroFramework.Controls.MetroComboBox cbWarehouse;
		private MetroFramework.Controls.MetroComboBox cbPartner;
		private MetroFramework.Controls.MetroDateTime dateTime;
		private MetroFramework.Controls.MetroTextBox tbCount;
		private MetroFramework.Controls.MetroLabel lblCountError;
		private MetroFramework.Controls.MetroButton btnCancel;
		private MetroFramework.Controls.MetroButton btnShip;
		private MetroFramework.Controls.MetroCheckBox cbSell;
	}
}