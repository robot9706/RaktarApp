namespace Raktar.App.Forms
{
	partial class TextEnterForm
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
			this.lblMessage = new MetroFramework.Controls.MetroLabel();
			this.tbText = new MetroFramework.Controls.MetroTextBox();
			this.btnOK = new MetroFramework.Controls.MetroButton();
			this.btnCancel = new MetroFramework.Controls.MetroButton();
			this.SuspendLayout();
			// 
			// lblMessage
			// 
			this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblMessage.Location = new System.Drawing.Point(30, 65);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new System.Drawing.Size(591, 28);
			this.lblMessage.TabIndex = 0;
			this.lblMessage.Text = "???";
			this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tbText
			// 
			this.tbText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// 
			// 
			this.tbText.CustomButton.Image = null;
			this.tbText.CustomButton.Location = new System.Drawing.Point(517, 1);
			this.tbText.CustomButton.Name = "";
			this.tbText.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.tbText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.tbText.CustomButton.TabIndex = 1;
			this.tbText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.tbText.CustomButton.UseSelectable = true;
			this.tbText.CustomButton.Visible = false;
			this.tbText.Lines = new string[] {
        "metroTextBox1"};
			this.tbText.Location = new System.Drawing.Point(56, 103);
			this.tbText.MaxLength = 32767;
			this.tbText.Name = "tbText";
			this.tbText.PasswordChar = '\0';
			this.tbText.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.tbText.SelectedText = "";
			this.tbText.SelectionLength = 0;
			this.tbText.SelectionStart = 0;
			this.tbText.ShortcutsEnabled = true;
			this.tbText.Size = new System.Drawing.Size(539, 23);
			this.tbText.TabIndex = 1;
			this.tbText.Text = "metroTextBox1";
			this.tbText.UseSelectable = true;
			this.tbText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.tbText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.tbText.TextChanged += new System.EventHandler(this.tbText_TextChanged);
			// 
			// btnOK
			// 
			this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnOK.Location = new System.Drawing.Point(333, 140);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(106, 30);
			this.btnOK.TabIndex = 2;
			this.btnOK.Text = "OK";
			this.btnOK.UseSelectable = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnCancel.Location = new System.Drawing.Point(215, 140);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(106, 30);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "Mégse";
			this.btnCancel.UseSelectable = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// TextEnterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(653, 190);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.tbText);
			this.Controls.Add(this.lblMessage);
			this.Name = "TextEnterForm";
			this.Text = "TextEnterForm";
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroLabel lblMessage;
		private MetroFramework.Controls.MetroTextBox tbText;
		private MetroFramework.Controls.MetroButton btnOK;
		private MetroFramework.Controls.MetroButton btnCancel;
	}
}