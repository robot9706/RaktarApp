using MetroFramework;
using Raktar.Database;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Raktar.App.Forms
{
	public partial class MainForm : AppForm
	{
		public MainForm()
		{
			InitializeComponent();

			AppDesign.Apply(this);
		}

		private void MainForm_Load(object sender, System.EventArgs e)
		{
			LoadWarehouseTab();
			LoadItemsTab();
		}

		#region Warehouse tab
		private void LoadWarehouseTab()
		{
			List<Warehouse> ws = Global.Database.SelectAll<Warehouse>("warehouse");

			foreach (Warehouse w in ws)
			{
				AddWarehouseEntry(w);
			}
		}

		private void AddWarehouseEntry(Warehouse w)
		{
			DataGridViewRow row = new DataGridViewRow();
			row.CreateCells(gridWarehouse);

			UpdateWarehouseRowCells(row, w);

			gridWarehouse.Rows.Add(row);
		}

		private void UpdateWarehouseRowCells(DataGridViewRow row, Warehouse w)
		{
			row.Cells[0].Value = w.Name;
			row.Cells[1].Value = w.City;
			row.Cells[2].Value = w.PostCode;
			row.Cells[3].Value = w.Street;
			row.Cells[4].Value = w.StreetNumber;

			row.Tag = w;
		}

		private void gridWarehouse_SelectionChanged(object sender, System.EventArgs e)
		{
			btnDeleteWarehouse.Enabled = (gridWarehouse.SelectedRows.Count > 0);
		}

		private void btnDeleteWarehouse_Click(object sender, System.EventArgs e)
		{
			DataGridViewRow[] selected = new DataGridViewRow[gridWarehouse.SelectedRows.Count];
			gridWarehouse.SelectedRows.CopyTo(selected, 0);

			foreach (DataGridViewRow row in selected)
			{
				Warehouse wh = (Warehouse)row.Tag;

				if (!Global.Database.DeleteFrom<Warehouse>("warehouse", wh))
				{
					Error("Hiba a sor törlése közben! \"" + wh.Name + "\"", "Hiba!");
					return;
				}

				gridWarehouse.Rows.Remove(row);
			}
		}

		private void btnNewWarehouse_Click(object sender, System.EventArgs e)
		{
			using (WarehouseEditForm whEdit = new WarehouseEditForm())
			{
				if (whEdit.ShowDialog(this) == DialogResult.OK)
				{
					Warehouse newWarehouse = whEdit.EditedWarehouse;

					if (Global.Database.InsertInto<Warehouse>("warehouse", newWarehouse))
					{
						AddWarehouseEntry(newWarehouse);
					}
					else
					{
						Error("Hiba a \"" + whEdit.EditedWarehouse.Name + "\" hozzáadása közben!", "Hiba!");
					}
				}
			}
		}

		private void gridWarehouse_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0 || e.RowIndex >= gridWarehouse.Rows.Count)
				return;

			DataGridViewRow row = gridWarehouse.Rows[e.RowIndex];

			using (WarehouseEditForm whEdit = new WarehouseEditForm((Warehouse)row.Tag))
			{
				if (whEdit.ShowDialog(this) == DialogResult.OK)
				{
					if (Global.Database.Update<Warehouse>("warehouse", whEdit.EditedWarehouse))
					{
						UpdateWarehouseRowCells(row, whEdit.EditedWarehouse);
					}
					else
					{
						Error("Hiba a(z) \"" + whEdit.EditedWarehouse.Name + "\" frissítése közben!", "Hiba");
					}
				}
			}
		}
		#endregion

		#region Items tab
		private void LoadItemsTab()
		{
			List<Item> items = Global.Database.SelectAll<Item>("items");

			foreach (Item w in items)
			{
				AddItemEntry(w);
			}
		}

		private void AddItemEntry(Item i)
		{
			DataGridViewRow row = new DataGridViewRow();
			row.CreateCells(gridItems);

			UpdateItemRowCells(row, i);

			gridItems.Rows.Add(row);
		}

		private void UpdateItemRowCells(DataGridViewRow row, Item i)
		{
			Category category = Global.Database.SelectOne<Category>("category", new Dictionary<string, object>() { { "CategoryID", i.CategoryID } });
			string categoryName = (category != null ? category.Name : "?");

			row.Cells[0].Value = i.Name;
			row.Cells[1].Value = i.Price.ToString();
			row.Cells[2].Value = categoryName;
			row.Cells[3].Value = i.Description;

			row.Tag = i;
		}

		private void gridItems_SelectionChanged(object sender, System.EventArgs e)
		{
			btnDeleteItem.Enabled = (gridItems.SelectedRows.Count > 0);
		}

		private void btnDeleteItem_Click(object sender, System.EventArgs e)
		{
			DataGridViewRow[] selected = new DataGridViewRow[gridItems.SelectedRows.Count];
			gridItems.SelectedRows.CopyTo(selected, 0);

			foreach (DataGridViewRow row in selected)
			{
				Item item = (Item)row.Tag;

				if (!Global.Database.DeleteFrom<Item>("items", item))
				{
					Error("Hiba a sor törlése közben! \"" + item.Name + "\"", "Hiba!");
					return;
				}

				gridItems.Rows.Remove(row);
			}
		}

		private void btnNewItem_Click(object sender, System.EventArgs e)
		{
			using (ItemEditForm edit = new ItemEditForm())
			{
				if (edit.ShowDialog(this) == DialogResult.OK)
				{
					Item newItem = edit.EditedItem;

					if (Global.Database.InsertInto<Item>("items", newItem))
					{
						AddItemEntry(newItem);
					}
					else
					{
						Error("Hiba a(z) \"" + edit.EditedItem.Name + "\" hozzáadása közben!", "Hiba!");
					}
				}
			}
		}

		private void gridItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0 || e.RowIndex >= gridItems.Rows.Count)
				return;

			DataGridViewRow row = gridItems.Rows[e.RowIndex];

			using (ItemEditForm itemEdit = new ItemEditForm((Item)row.Tag))
			{
				if (itemEdit.ShowDialog(this) == DialogResult.OK)
				{
					if (Global.Database.Update<Item>("items", itemEdit.EditedItem))
					{
						UpdateItemRowCells(row, itemEdit.EditedItem);
					}
					else
					{
						Error("Hiba a(z) \"" + itemEdit.EditedItem.Name + "\" frissítése közben!", "Hiba");
					}
				}
			}
		}
		#endregion
	}
}
