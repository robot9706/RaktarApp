namespace Raktar.App.Forms
{
	partial class CategoryManagerForm
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
			this.components = new System.ComponentModel.Container();
			this.btnOK = new MetroFramework.Controls.MetroButton();
			this.metroStyleExtender = new MetroFramework.Components.MetroStyleExtender(this.components);
			this.listCategory = new System.Windows.Forms.ListBox();
			this.btnNew = new MetroFramework.Controls.MetroButton();
			this.btnDelete = new MetroFramework.Controls.MetroButton();
			this.btnEdit = new MetroFramework.Controls.MetroButton();
			this.SuspendLayout();
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.Location = new System.Drawing.Point(273, 345);
			this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(91, 37);
			this.btnOK.TabIndex = 1;
			this.btnOK.Text = "OK";
			this.btnOK.UseSelectable = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// listCategory
			// 
			this.listCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.listCategory.FormattingEnabled = true;
			this.listCategory.IntegralHeight = false;
			this.listCategory.ItemHeight = 18;
			this.listCategory.Location = new System.Drawing.Point(28, 58);
			this.listCategory.Name = "listCategory";
			this.listCategory.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.listCategory.Size = new System.Drawing.Size(238, 324);
			this.listCategory.TabIndex = 2;
			this.listCategory.SelectedIndexChanged += new System.EventHandler(this.listCategory_SelectedIndexChanged);
			// 
			// btnNew
			// 
			this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNew.Location = new System.Drawing.Point(273, 215);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(91, 32);
			this.btnNew.TabIndex = 3;
			this.btnNew.Text = "Új";
			this.btnNew.UseSelectable = true;
			this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDelete.Enabled = false;
			this.btnDelete.Location = new System.Drawing.Point(273, 253);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(91, 32);
			this.btnDelete.TabIndex = 4;
			this.btnDelete.Text = "Törlés";
			this.btnDelete.UseSelectable = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEdit.Enabled = false;
			this.btnEdit.Location = new System.Drawing.Point(273, 291);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(91, 32);
			this.btnEdit.TabIndex = 5;
			this.btnEdit.Text = "Szerkesztés";
			this.btnEdit.UseSelectable = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// CategoryManagerForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(393, 408);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnNew);
			this.Controls.Add(this.listCategory);
			this.Controls.Add(this.btnOK);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "CategoryManagerForm";
			this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
			this.Text = "Kategória kezelő";
			this.Load += new System.EventHandler(this.CategoryManagerForm_Load);
			this.ResumeLayout(false);

		}

		#endregion
		private MetroFramework.Controls.MetroButton btnOK;
		private MetroFramework.Components.MetroStyleExtender metroStyleExtender;
		private System.Windows.Forms.ListBox listCategory;
		private MetroFramework.Controls.MetroButton btnNew;
		private MetroFramework.Controls.MetroButton btnDelete;
		private MetroFramework.Controls.MetroButton btnEdit;
	}
}