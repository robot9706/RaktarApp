namespace Raktar.App.Forms
{
	partial class SplashForm
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
			this.lblStatus = new MetroFramework.Controls.MetroLabel();
			this.loaderSpinner = new MetroFramework.Controls.MetroProgressSpinner();
			this.SuspendLayout();
			// 
			// lblStatus
			// 
			this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblStatus.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.lblStatus.Location = new System.Drawing.Point(23, 60);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(360, 41);
			this.lblStatus.TabIndex = 1;
			this.lblStatus.Text = "....";
			this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// loaderSpinner
			// 
			this.loaderSpinner.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.loaderSpinner.Location = new System.Drawing.Point(171, 104);
			this.loaderSpinner.Maximum = 100;
			this.loaderSpinner.Minimum = 1;
			this.loaderSpinner.Name = "loaderSpinner";
			this.loaderSpinner.Size = new System.Drawing.Size(64, 64);
			this.loaderSpinner.Speed = 2F;
			this.loaderSpinner.TabIndex = 2;
			this.loaderSpinner.UseSelectable = true;
			this.loaderSpinner.Value = 25;
			// 
			// SplashForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(410, 180);
			this.Controls.Add(this.loaderSpinner);
			this.Controls.Add(this.lblStatus);
			this.MaximizeBox = false;
			this.Movable = false;
			this.Name = "SplashForm";
			this.Resizable = false;
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Raktár App";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.SplashForm_Load);
			this.ResumeLayout(false);

		}

		#endregion
		private MetroFramework.Controls.MetroLabel lblStatus;
		private MetroFramework.Controls.MetroProgressSpinner loaderSpinner;
	}
}