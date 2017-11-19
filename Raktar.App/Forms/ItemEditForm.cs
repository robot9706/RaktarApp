using MetroFramework.Controls;
using Raktar.Database;
using System;
using System.Globalization;
using Raktar.App.Data;

namespace Raktar.App.Forms
{
	public partial class ItemEditForm : AppForm
	{
		private ItemWithCategory _edit;

		public ItemWithCategory EditedItem
		{
			get
			{
				ItemWithCategory item = new ItemWithCategory();

				if (_edit != null)
					item.ID = _edit.ID;

				item.Name = tbName.Text;

				Double.TryParse(tbPrice.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out item.Price);

				item.Description = tbDescription.Text;

				Category cat = ((Category)cbCategory.SelectedItem);
				item.CategoryID = cat.CategoryID;
				item.CategoryName = cat.Name;

				return item;
			}
		}

		public ItemEditForm()
		{
			InitializeComponent();

			AppDesign.Apply(this);
		}

		public ItemEditForm(ItemWithCategory edit)
			: this()
		{
			_edit = edit;

			tbName.Text = edit.Name;
			tbDescription.Text = edit.Description;
			tbPrice.Text = edit.Price.ToString();
		}

		private void ItemEditForm_Load(object sender, EventArgs e)
		{
			LoadCategoryList(true);
		}

		private void LoadCategoryList(bool selectEditCategory)
		{
			int lastSelectedID = -1;
			if (cbCategory.SelectedIndex > -1)
				lastSelectedID = ((Category)cbCategory.SelectedItem).CategoryID;

			if (selectEditCategory)
				lastSelectedID = _edit.CategoryID;

			cbCategory.Items.Clear();
			cbCategory.Items.AddRange(Global.Database.SelectAll<Category>("category").ToArray());

			if (lastSelectedID != -1)
			{
				cbCategory.SelectedIndex = -1;

				for (int x = 0; x < cbCategory.Items.Count; x++)
				{
					if (((Category)cbCategory.Items[x]).CategoryID == lastSelectedID)
					{
						cbCategory.SelectedIndex = x;
						break;
					}
				}
			}
		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			DialogResult = System.Windows.Forms.DialogResult.Cancel;
		}

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			DialogResult = System.Windows.Forms.DialogResult.OK;
		}

		private void tbPrice_TextChanged(object sender, System.EventArgs e)
		{
			MetroTextBox box = (MetroTextBox)sender;

			double priceTest;
			lblPriceError.Visible = (!Double.TryParse(box.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out priceTest) || priceTest < 0);

			ValidateInput();
		}

		private void metroButton1_Click(object sender, EventArgs e)
		{
			using (CategoryManagerForm cmgr = new CategoryManagerForm())
			{
				cmgr.ShowDialog(this);

				LoadCategoryList(false);
			}
		}

		private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
		{
			ValidateInput();
		}

		private void tbDescription_TextChanged(object sender, EventArgs e)
		{
			ValidateInput();
		}

		private void ValidateInput()
		{
			btnOK.Enabled = (!string.IsNullOrEmpty(tbName.Text) &&
				!string.IsNullOrEmpty(tbPrice.Text) &&
				!string.IsNullOrEmpty(tbDescription.Text) &&
				!lblPriceError.Visible &&
				cbCategory.SelectedIndex > -1);
		}
	}
}
