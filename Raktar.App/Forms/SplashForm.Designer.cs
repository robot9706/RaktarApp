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
			this.loaderBar = new MetroFramework.Controls.MetroProgressBar();
			this.lblStatus = new MetroFramework.Controls.MetroLabel();
			this.SuspendLayout();
			// 
			// loaderBar
			// 
			this.loaderBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.loaderBar.Location = new System.Drawing.Point(23, 126);
			this.loaderBar.MarqueeAnimationSpeed = 10000;
			this.loaderBar.Name = "loaderBar";
			this.loaderBar.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Marquee;
			this.loaderBar.Size = new System.Drawing.Size(559, 23);
			this.loaderBar.TabIndex = 0;
			// 
			// lblStatus
			// 
			this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblStatus.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.lblStatus.Location = new System.Drawing.Point(23, 60);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(559, 41);
			this.lblStatus.TabIndex = 1;
			this.lblStatus.Text = "....";
			this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// SplashForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(609, 170);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.loaderBar);
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

		private MetroFramework.Controls.MetroProgressBar loaderBar;
		private MetroFramework.Controls.MetroLabel lblStatus;
	}
}