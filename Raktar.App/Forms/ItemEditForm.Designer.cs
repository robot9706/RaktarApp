namespace Raktar.App.Forms
{
	partial class ItemEditForm
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
			this.tbName = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.tbPrice = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.lblPriceError = new MetroFramework.Controls.MetroLabel();
			this.tbDescription = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
			this.cbCategory = new MetroFramework.Controls.MetroComboBox();
			this.metroButton1 = new MetroFramework.Controls.MetroButton();
			this.btnCancel = new MetroFramework.Controls.MetroButton();
			this.btnOK = new MetroFramework.Controls.MetroButton();
			this.SuspendLayout();
			// 
			// tbName
			// 
			this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// 
			// 
			this.tbName.CustomButton.Image = null;
			this.tbName.CustomButton.Location = new System.Drawing.Point(137, 1);
			this.tbName.CustomButton.Name = "";
			this.tbName.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.tbName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.tbName.CustomButton.TabIndex = 1;
			this.tbName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.tbName.CustomButton.UseSelectable = true;
			this.tbName.CustomButton.Visible = false;
			this.tbName.Lines = new string[0];
			this.tbName.Location = new System.Drawing.Point(84, 75);
			this.tbName.MaxLength = 32767;
			this.tbName.Name = "tbName";
			this.tbName.PasswordChar = '\0';
			this.tbName.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.tbName.SelectedText = "";
			this.tbName.SelectionLength = 0;
			this.tbName.SelectionStart = 0;
			this.tbName.ShortcutsEnabled = true;
			this.tbName.Size = new System.Drawing.Size(159, 23);
			this.tbName.TabIndex = 3;
			this.tbName.UseSelectable = true;
			this.tbName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.tbName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.tbName.TextChanged += new System.EventHandler(this.tbDescription_TextChanged);
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(44, 77);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(35, 19);
			this.metroLabel1.TabIndex = 2;
			this.metroLabel1.Text = "Név:";
			// 
			// tbPrice
			// 
			this.tbPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// 
			// 
			this.tbPrice.CustomButton.Image = null;
			this.tbPrice.CustomButton.Location = new System.Drawing.Point(137, 1);
			this.tbPrice.CustomButton.Name = "";
			this.tbPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.tbPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.tbPrice.CustomButton.TabIndex = 1;
			this.tbPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.tbPrice.CustomButton.UseSelectable = true;
			this.tbPrice.CustomButton.Visible = false;
			this.tbPrice.Lines = new string[0];
			this.tbPrice.Location = new System.Drawing.Point(84, 104);
			this.tbPrice.MaxLength = 32767;
			this.tbPrice.Name = "tbPrice";
			this.tbPrice.PasswordChar = '\0';
			this.tbPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.tbPrice.SelectedText = "";
			this.tbPrice.SelectionLength = 0;
			this.tbPrice.SelectionStart = 0;
			this.tbPrice.ShortcutsEnabled = true;
			this.tbPrice.Size = new System.Drawing.Size(159, 23);
			this.tbPrice.TabIndex = 5;
			this.tbPrice.UseSelectable = true;
			this.tbPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.tbPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.tbPrice.TextChanged += new System.EventHandler(this.tbPrice_TextChanged);
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(51, 106);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(27, 19);
			this.metroLabel2.TabIndex = 4;
			this.metroLabel2.Text = "Ár:";
			// 
			// lblPriceError
			// 
			this.lblPriceError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblPriceError.AutoSize = true;
			this.lblPriceError.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.lblPriceError.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.lblPriceError.ForeColor = System.Drawing.Color.Red;
			this.lblPriceError.Location = new System.Drawing.Point(247, 102);
			this.lblPriceError.Name = "lblPriceError";
			this.lblPriceError.Size = new System.Drawing.Size(18, 25);
			this.lblPriceError.TabIndex = 15;
			this.lblPriceError.Text = "!";
			this.lblPriceError.Visible = false;
			// 
			// tbDescription
			// 
			this.tbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// 
			// 
			this.tbDescription.CustomButton.Image = null;
			this.tbDescription.CustomButton.Location = new System.Drawing.Point(362, 1);
			this.tbDescription.CustomButton.Name = "";
			this.tbDescription.CustomButton.Size = new System.Drawing.Size(121, 121);
			this.tbDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.tbDescription.CustomButton.TabIndex = 1;
			this.tbDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.tbDescription.CustomButton.UseSelectable = true;
			this.tbDescription.CustomButton.Visible = false;
			this.tbDescription.Lines = new string[0];
			this.tbDescription.Location = new System.Drawing.Point(84, 133);
			this.tbDescription.MaxLength = 32767;
			this.tbDescription.Multiline = true;
			this.tbDescription.Name = "tbDescription";
			this.tbDescription.PasswordChar = '\0';
			this.tbDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.tbDescription.SelectedText = "";
			this.tbDescription.SelectionLength = 0;
			this.tbDescription.SelectionStart = 0;
			this.tbDescription.ShortcutsEnabled = true;
			this.tbDescription.Size = new System.Drawing.Size(484, 123);
			this.tbDescription.TabIndex = 16;
			this.tbDescription.UseSelectable = true;
			this.tbDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.tbDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.tbDescription.TextChanged += new System.EventHandler(this.tbDescription_TextChanged);
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.Location = new System.Drawing.Point(34, 133);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(45, 19);
			this.metroLabel3.TabIndex = 17;
			this.metroLabel3.Text = "Leírás:";
			// 
			// metroLabel4
			// 
			this.metroLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.metroLabel4.AutoSize = true;
			this.metroLabel4.Location = new System.Drawing.Point(249, 75);
			this.metroLabel4.Name = "metroLabel4";
			this.metroLabel4.Size = new System.Drawing.Size(68, 19);
			this.metroLabel4.TabIndex = 18;
			this.metroLabel4.Text = "Kategória:";
			// 
			// cbCategory
			// 
			this.cbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbCategory.FormattingEnabled = true;
			this.cbCategory.ItemHeight = 23;
			this.cbCategory.Location = new System.Drawing.Point(323, 72);
			this.cbCategory.Name = "cbCategory";
			this.cbCategory.Size = new System.Drawing.Size(164, 29);
			this.cbCategory.TabIndex = 19;
			this.cbCategory.UseSelectable = true;
			this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
			// 
			// metroButton1
			// 
			this.metroButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.metroButton1.Location = new System.Drawing.Point(493, 71);
			this.metroButton1.Name = "metroButton1";
			this.metroButton1.Size = new System.Drawing.Size(75, 30);
			this.metroButton1.TabIndex = 20;
			this.metroButton1.Text = "Kezelés";
			this.metroButton1.UseSelectable = true;
			this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.Location = new System.Drawing.Point(314, 274);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(124, 38);
			this.btnCancel.TabIndex = 22;
			this.btnCancel.Text = "Mégse";
			this.btnCancel.UseSelectable = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.Enabled = false;
			this.btnOK.Location = new System.Drawing.Point(444, 274);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(124, 38);
			this.btnOK.TabIndex = 21;
			this.btnOK.Text = "Mentés";
			this.btnOK.UseSelectable = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// ItemEditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(604, 343);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.metroButton1);
			this.Controls.Add(this.cbCategory);
			this.Controls.Add(this.metroLabel4);
			this.Controls.Add(this.metroLabel3);
			this.Controls.Add(this.tbDescription);
			this.Controls.Add(this.lblPriceError);
			this.Controls.Add(this.tbPrice);
			this.Controls.Add(this.metroLabel2);
			this.Controls.Add(this.tbName);
			this.Controls.Add(this.metroLabel1);
			this.Name = "ItemEditForm";
			this.Text = "Cikk szerkeszése";
			this.Load += new System.EventHandler(this.ItemEditForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroTextBox tbName;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroTextBox tbPrice;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroLabel lblPriceError;
		private MetroFramework.Controls.MetroTextBox tbDescription;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroLabel metroLabel4;
		private MetroFramework.Controls.MetroComboBox cbCategory;
		private MetroFramework.Controls.MetroButton metroButton1;
		private MetroFramework.Controls.MetroButton btnCancel;
		private MetroFramework.Controls.MetroButton btnOK;
	}
}