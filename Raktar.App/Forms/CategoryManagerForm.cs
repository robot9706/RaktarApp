using MetroFramework.Forms;
using Raktar.Database;
using System.Collections.Generic;

namespace Raktar.App.Forms
{
	public partial class CategoryManagerForm : AppForm
	{
		public CategoryManagerForm()
		{
			InitializeComponent();

			metroStyleExtender.SetApplyMetroTheme(listCategory, true);

			AppDesign.Apply(this, metroStyleExtender);
		}

		private void CategoryManagerForm_Load(object sender, System.EventArgs e)
		{
			List<Category> all = Global.Database.SelectAll<Category>("category");

			listCategory.Items.AddRange(all.ToArray());
		}

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void listCategory_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			btnDelete.Enabled = (listCategory.SelectedIndices.Count > 0);
			btnEdit.Enabled = (listCategory.SelectedIndices.Count == 1);
		}

		private void btnNew_Click(object sender, System.EventArgs e)
		{
			using (TextEnterForm te = new TextEnterForm("Új kategória", "Írja be a kategória nevét:", string.Empty, false))
			{
				if (te.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
				{
					Category ct = new Category();
					ct.Name = te.EditText;

					if (Global.Database.InsertInto<Category>("category", ct))
					{
						listCategory.Items.Add(ct);

						Info("\"" + ct.Name + "\" hozzáadva!", Text);
					}
				}
			}
		}

		private void btnDelete_Click(object sender, System.EventArgs e)
		{
			Category[] list = new Category[listCategory.SelectedItems.Count];
			listCategory.SelectedItems.CopyTo(list, 0);

			int ok = 0;

			foreach (Category toDelete in list)
			{
				if (Global.Database.DeleteFrom<Category>("category", toDelete))
				{
					listCategory.Items.Remove(toDelete);

					ok++;
				}
				else
				{
					ok = -1;

					Error("Hiba \"" + toDelete.Name + "\" törlése közben!", Text);

					break;
				}
			}

			if (ok > 0)
			{
				Info(ok.ToString() + " elem törölve!", Text);
			}
		}

		private void btnEdit_Click(object sender, System.EventArgs e)
		{
			Category selected = (Category)listCategory.SelectedItem;

			using (TextEnterForm te = new TextEnterForm("Kategória szerkesztése", "Írja be a kategória nevét:", selected.Name, false))
			{
				if (te.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
				{
					selected.Name = te.EditText;

					if (Global.Database.Update<Category>("category", selected))
					{
						listCategory.Items[listCategory.SelectedIndices[0]] = selected;

						Info("\"" + selected.Name + "\" frissítve!", Text);
					}
					else
					{
						Error("Hiba az elem frissítése közben!", Text);
					}
				}
			}
		}
	}
}
