namespace Raktar.App.Forms
{
	partial class NewShipmentForm
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
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.cbFrom = new MetroFramework.Controls.MetroComboBox();
			this.cbTo = new MetroFramework.Controls.MetroComboBox();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.cbItem = new MetroFramework.Controls.MetroComboBox();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.dateTime = new MetroFramework.Controls.MetroDateTime();
			this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
			this.tbCount = new MetroFramework.Controls.MetroTextBox();
			this.lblCountError = new MetroFramework.Controls.MetroLabel();
			this.btnShip = new MetroFramework.Controls.MetroButton();
			this.btnCancel = new MetroFramework.Controls.MetroButton();
			this.SuspendLayout();
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(33, 117);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(57, 19);
			this.metroLabel1.TabIndex = 0;
			this.metroLabel1.Text = "Honnan:";
			// 
			// cbFrom
			// 
			this.cbFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbFrom.Enabled = false;
			this.cbFrom.FormattingEnabled = true;
			this.cbFrom.ItemHeight = 23;
			this.cbFrom.Location = new System.Drawing.Point(91, 112);
			this.cbFrom.Name = "cbFrom";
			this.cbFrom.Size = new System.Drawing.Size(213, 29);
			this.cbFrom.TabIndex = 1;
			this.cbFrom.UseSelectable = true;
			this.cbFrom.SelectedIndexChanged += new System.EventHandler(this.cbFrom_SelectedIndexChanged);
			// 
			// cbTo
			// 
			this.cbTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbTo.Enabled = false;
			this.cbTo.FormattingEnabled = true;
			this.cbTo.ItemHeight = 23;
			this.cbTo.Location = new System.Drawing.Point(91, 147);
			this.cbTo.Name = "cbTo";
			this.cbTo.Size = new System.Drawing.Size(213, 29);
			this.cbTo.TabIndex = 3;
			this.cbTo.UseSelectable = true;
			this.cbTo.SelectedIndexChanged += new System.EventHandler(this.cbFrom_SelectedIndexChanged);
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(48, 152);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(42, 19);
			this.metroLabel2.TabIndex = 2;
			this.metroLabel2.Text = "Hova:";
			// 
			// cbItem
			// 
			this.cbItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbItem.FormattingEnabled = true;
			this.cbItem.ItemHeight = 23;
			this.cbItem.Location = new System.Drawing.Point(91, 74);
			this.cbItem.Name = "cbItem";
			this.cbItem.Size = new System.Drawing.Size(213, 29);
			this.cbItem.TabIndex = 5;
			this.cbItem.UseSelectable = true;
			this.cbItem.SelectedIndexChanged += new System.EventHandler(this.cbItem_SelectedIndexChanged);
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.Location = new System.Drawing.Point(59, 79);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(31, 19);
			this.metroLabel3.TabIndex = 4;
			this.metroLabel3.Text = "Mit:";
			// 
			// dateTime
			// 
			this.dateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.dateTime.CustomFormat = "";
			this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTime.Location = new System.Drawing.Point(382, 74);
			this.dateTime.MinimumSize = new System.Drawing.Size(0, 29);
			this.dateTime.Name = "dateTime";
			this.dateTime.Size = new System.Drawing.Size(200, 29);
			this.dateTime.TabIndex = 6;
			this.dateTime.ValueChanged += new System.EventHandler(this.dateTime_ValueChanged);
			// 
			// metroLabel4
			// 
			this.metroLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.metroLabel4.AutoSize = true;
			this.metroLabel4.Location = new System.Drawing.Point(333, 79);
			this.metroLabel4.Name = "metroLabel4";
			this.metroLabel4.Size = new System.Drawing.Size(47, 19);
			this.metroLabel4.TabIndex = 7;
			this.metroLabel4.Text = "Mikor:";
			// 
			// metroLabel5
			// 
			this.metroLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.metroLabel5.AutoSize = true;
			this.metroLabel5.Location = new System.Drawing.Point(322, 114);
			this.metroLabel5.Name = "metroLabel5";
			this.metroLabel5.Size = new System.Drawing.Size(58, 19);
			this.metroLabel5.TabIndex = 8;
			this.metroLabel5.Text = "Mennyit:";
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
			this.tbCount.Location = new System.Drawing.Point(382, 112);
			this.tbCount.MaxLength = 32767;
			this.tbCount.Name = "tbCount";
			this.tbCount.PasswordChar = '\0';
			this.tbCount.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.tbCount.SelectedText = "";
			this.tbCount.SelectionLength = 0;
			this.tbCount.SelectionStart = 0;
			this.tbCount.ShortcutsEnabled = true;
			this.tbCount.Size = new System.Drawing.Size(200, 23);
			this.tbCount.TabIndex = 9;
			this.tbCount.UseSelectable = true;
			this.tbCount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.tbCount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.tbCount.TextChanged += new System.EventHandler(this.tbCount_TextChanged);
			// 
			// lblCountError
			// 
			this.lblCountError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblCountError.AutoSize = true;
			this.lblCountError.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.lblCountError.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.lblCountError.ForeColor = System.Drawing.Color.Red;
			this.lblCountError.Location = new System.Drawing.Point(585, 110);
			this.lblCountError.Name = "lblCountError";
			this.lblCountError.Size = new System.Drawing.Size(18, 25);
			this.lblCountError.TabIndex = 16;
			this.lblCountError.Text = "!";
			this.lblCountError.Visible = false;
			// 
			// btnShip
			// 
			this.btnShip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnShip.Enabled = false;
			this.btnShip.Location = new System.Drawing.Point(449, 191);
			this.btnShip.Name = "btnShip";
			this.btnShip.Size = new System.Drawing.Size(133, 40);
			this.btnShip.TabIndex = 17;
			this.btnShip.Text = "Új szállítmány";
			this.btnShip.UseSelectable = true;
			this.btnShip.Click += new System.EventHandler(this.btnShip_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.Location = new System.Drawing.Point(310, 191);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(133, 40);
			this.btnCancel.TabIndex = 18;
			this.btnCancel.Text = "Mégse";
			this.btnCancel.UseSelectable = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// NewShipmentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(631, 255);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnShip);
			this.Controls.Add(this.lblCountError);
			this.Controls.Add(this.tbCount);
			this.Controls.Add(this.dateTime);
			this.Controls.Add(this.cbItem);
			this.Controls.Add(this.cbTo);
			this.Controls.Add(this.cbFrom);
			this.Controls.Add(this.metroLabel5);
			this.Controls.Add(this.metroLabel4);
			this.Controls.Add(this.metroLabel3);
			this.Controls.Add(this.metroLabel2);
			this.Controls.Add(this.metroLabel1);
			this.Name = "NewShipmentForm";
			this.Text = "Új raktárközi szállítmány";
			this.Load += new System.EventHandler(this.NewShipmentForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroComboBox cbFrom;
		private MetroFramework.Controls.MetroComboBox cbTo;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroComboBox cbItem;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroDateTime dateTime;
		private MetroFramework.Controls.MetroLabel metroLabel4;
		private MetroFramework.Controls.MetroLabel metroLabel5;
		private MetroFramework.Controls.MetroTextBox tbCount;
		private MetroFramework.Controls.MetroLabel lblCountError;
		private MetroFramework.Controls.MetroButton btnShip;
		private MetroFramework.Controls.MetroButton btnCancel;
	}
}