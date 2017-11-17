namespace Raktar.App.Forms
{
	partial class WarehouseEditForm
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
			this.tbName = new MetroFramework.Controls.MetroTextBox();
			this.tbCity = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.tbStreet = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
			this.tbPostCode = new MetroFramework.Controls.MetroTextBox();
			this.tbStreetNum = new MetroFramework.Controls.MetroTextBox();
			this.btnOK = new MetroFramework.Controls.MetroButton();
			this.btnCancel = new MetroFramework.Controls.MetroButton();
			this.lblStreetNumError = new MetroFramework.Controls.MetroLabel();
			this.SuspendLayout();
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(47, 79);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(35, 19);
			this.metroLabel1.TabIndex = 0;
			this.metroLabel1.Text = "Név:";
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
			this.tbName.Location = new System.Drawing.Point(87, 77);
			this.tbName.MaxLength = 32767;
			this.tbName.Name = "tbName";
			this.tbName.PasswordChar = '\0';
			this.tbName.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.tbName.SelectedText = "";
			this.tbName.SelectionLength = 0;
			this.tbName.SelectionStart = 0;
			this.tbName.ShortcutsEnabled = true;
			this.tbName.Size = new System.Drawing.Size(159, 23);
			this.tbName.TabIndex = 1;
			this.tbName.UseSelectable = true;
			this.tbName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.tbName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
			// 
			// tbCity
			// 
			this.tbCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// 
			// 
			this.tbCity.CustomButton.Image = null;
			this.tbCity.CustomButton.Location = new System.Drawing.Point(137, 1);
			this.tbCity.CustomButton.Name = "";
			this.tbCity.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.tbCity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.tbCity.CustomButton.TabIndex = 1;
			this.tbCity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.tbCity.CustomButton.UseSelectable = true;
			this.tbCity.CustomButton.Visible = false;
			this.tbCity.Lines = new string[0];
			this.tbCity.Location = new System.Drawing.Point(87, 112);
			this.tbCity.MaxLength = 32767;
			this.tbCity.Name = "tbCity";
			this.tbCity.PasswordChar = '\0';
			this.tbCity.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.tbCity.SelectedText = "";
			this.tbCity.SelectionLength = 0;
			this.tbCity.SelectionStart = 0;
			this.tbCity.ShortcutsEnabled = true;
			this.tbCity.Size = new System.Drawing.Size(159, 23);
			this.tbCity.TabIndex = 3;
			this.tbCity.UseSelectable = true;
			this.tbCity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.tbCity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.tbCity.TextChanged += new System.EventHandler(this.tbName_TextChanged);
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(37, 114);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(45, 19);
			this.metroLabel2.TabIndex = 2;
			this.metroLabel2.Text = "Város:";
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.Location = new System.Drawing.Point(252, 114);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(85, 19);
			this.metroLabel3.TabIndex = 4;
			this.metroLabel3.Text = "Irányítószám:";
			// 
			// tbStreet
			// 
			this.tbStreet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// 
			// 
			this.tbStreet.CustomButton.Image = null;
			this.tbStreet.CustomButton.Location = new System.Drawing.Point(137, 1);
			this.tbStreet.CustomButton.Name = "";
			this.tbStreet.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.tbStreet.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.tbStreet.CustomButton.TabIndex = 1;
			this.tbStreet.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.tbStreet.CustomButton.UseSelectable = true;
			this.tbStreet.CustomButton.Visible = false;
			this.tbStreet.Lines = new string[0];
			this.tbStreet.Location = new System.Drawing.Point(87, 149);
			this.tbStreet.MaxLength = 32767;
			this.tbStreet.Name = "tbStreet";
			this.tbStreet.PasswordChar = '\0';
			this.tbStreet.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.tbStreet.SelectedText = "";
			this.tbStreet.SelectionLength = 0;
			this.tbStreet.SelectionStart = 0;
			this.tbStreet.ShortcutsEnabled = true;
			this.tbStreet.Size = new System.Drawing.Size(159, 23);
			this.tbStreet.TabIndex = 7;
			this.tbStreet.UseSelectable = true;
			this.tbStreet.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.tbStreet.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.tbStreet.TextChanged += new System.EventHandler(this.tbName_TextChanged);
			// 
			// metroLabel4
			// 
			this.metroLabel4.AutoSize = true;
			this.metroLabel4.Location = new System.Drawing.Point(44, 151);
			this.metroLabel4.Name = "metroLabel4";
			this.metroLabel4.Size = new System.Drawing.Size(38, 19);
			this.metroLabel4.TabIndex = 6;
			this.metroLabel4.Text = "Utca:";
			// 
			// metroLabel5
			// 
			this.metroLabel5.AutoSize = true;
			this.metroLabel5.Location = new System.Drawing.Point(273, 151);
			this.metroLabel5.Name = "metroLabel5";
			this.metroLabel5.Size = new System.Drawing.Size(64, 19);
			this.metroLabel5.TabIndex = 8;
			this.metroLabel5.Text = "Házszám:";
			// 
			// tbPostCode
			// 
			this.tbPostCode.BackColor = System.Drawing.Color.White;
			// 
			// 
			// 
			this.tbPostCode.CustomButton.Image = null;
			this.tbPostCode.CustomButton.Location = new System.Drawing.Point(89, 1);
			this.tbPostCode.CustomButton.Name = "";
			this.tbPostCode.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.tbPostCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.tbPostCode.CustomButton.TabIndex = 1;
			this.tbPostCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.tbPostCode.CustomButton.UseSelectable = true;
			this.tbPostCode.CustomButton.Visible = false;
			this.tbPostCode.Lines = new string[0];
			this.tbPostCode.Location = new System.Drawing.Point(340, 112);
			this.tbPostCode.MaxLength = 32767;
			this.tbPostCode.Name = "tbPostCode";
			this.tbPostCode.PasswordChar = '\0';
			this.tbPostCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.tbPostCode.SelectedText = "";
			this.tbPostCode.SelectionLength = 0;
			this.tbPostCode.SelectionStart = 0;
			this.tbPostCode.ShortcutsEnabled = true;
			this.tbPostCode.Size = new System.Drawing.Size(111, 23);
			this.tbPostCode.TabIndex = 9;
			this.tbPostCode.Tag = "";
			this.tbPostCode.UseSelectable = true;
			this.tbPostCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.tbPostCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// tbStreetNum
			// 
			// 
			// 
			// 
			this.tbStreetNum.CustomButton.Image = null;
			this.tbStreetNum.CustomButton.Location = new System.Drawing.Point(89, 1);
			this.tbStreetNum.CustomButton.Name = "";
			this.tbStreetNum.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.tbStreetNum.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.tbStreetNum.CustomButton.TabIndex = 1;
			this.tbStreetNum.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.tbStreetNum.CustomButton.UseSelectable = true;
			this.tbStreetNum.CustomButton.Visible = false;
			this.tbStreetNum.Lines = new string[0];
			this.tbStreetNum.Location = new System.Drawing.Point(340, 149);
			this.tbStreetNum.MaxLength = 32767;
			this.tbStreetNum.Name = "tbStreetNum";
			this.tbStreetNum.PasswordChar = '\0';
			this.tbStreetNum.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.tbStreetNum.SelectedText = "";
			this.tbStreetNum.SelectionLength = 0;
			this.tbStreetNum.SelectionStart = 0;
			this.tbStreetNum.ShortcutsEnabled = true;
			this.tbStreetNum.Size = new System.Drawing.Size(111, 23);
			this.tbStreetNum.TabIndex = 10;
			this.tbStreetNum.Tag = "";
			this.tbStreetNum.UseSelectable = true;
			this.tbStreetNum.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.tbStreetNum.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.tbStreetNum.TextChanged += new System.EventHandler(this.tbStreetNum_TextChanged);
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.Enabled = false;
			this.btnOK.Location = new System.Drawing.Point(365, 198);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(124, 38);
			this.btnOK.TabIndex = 11;
			this.btnOK.Text = "Mentés";
			this.btnOK.UseSelectable = true;
			this.btnOK.Click += new System.EventHandler(this.metroButton1_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.Location = new System.Drawing.Point(235, 198);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(124, 38);
			this.btnCancel.TabIndex = 12;
			this.btnCancel.Text = "Mégse";
			this.btnCancel.UseSelectable = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// lblStreetNumError
			// 
			this.lblStreetNumError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblStreetNumError.AutoSize = true;
			this.lblStreetNumError.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.lblStreetNumError.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.lblStreetNumError.ForeColor = System.Drawing.Color.Red;
			this.lblStreetNumError.Location = new System.Drawing.Point(453, 147);
			this.lblStreetNumError.Name = "lblStreetNumError";
			this.lblStreetNumError.Size = new System.Drawing.Size(18, 25);
			this.lblStreetNumError.TabIndex = 14;
			this.lblStreetNumError.Text = "!";
			this.lblStreetNumError.Visible = false;
			// 
			// WarehouseEditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(512, 254);
			this.Controls.Add(this.lblStreetNumError);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.tbStreetNum);
			this.Controls.Add(this.tbPostCode);
			this.Controls.Add(this.tbStreet);
			this.Controls.Add(this.tbCity);
			this.Controls.Add(this.tbName);
			this.Controls.Add(this.metroLabel5);
			this.Controls.Add(this.metroLabel4);
			this.Controls.Add(this.metroLabel3);
			this.Controls.Add(this.metroLabel2);
			this.Controls.Add(this.metroLabel1);
			this.Name = "WarehouseEditForm";
			this.Resizable = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Raktár szerkesztése";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroTextBox tbName;
		private MetroFramework.Controls.MetroTextBox tbCity;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroTextBox tbStreet;
		private MetroFramework.Controls.MetroLabel metroLabel4;
		private MetroFramework.Controls.MetroLabel metroLabel5;
		private MetroFramework.Controls.MetroTextBox tbPostCode;
		private MetroFramework.Controls.MetroTextBox tbStreetNum;
		private MetroFramework.Controls.MetroButton btnOK;
		private MetroFramework.Controls.MetroButton btnCancel;
		private MetroFramework.Controls.MetroLabel lblStreetNumError;
	}
}