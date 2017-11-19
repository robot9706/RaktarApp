using Raktar.App.Data;
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
			SuspendLayout();
			{
				LoadWarehouseTab();
				LoadItemsTab();
				LoadPartnersTab();
				LoadStockTab();
			}
			ResumeLayout();
		}

		#region Warehouse tab
		private void LoadWarehouseTab()
		{
			gridWarehouse.Rows.Clear();

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
			btnWarehouseEdit.Enabled = (gridWarehouse.SelectedRows.Count == 1);
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

		private void btnWarehouseEdit_Click(object sender, System.EventArgs e)
		{
			gridWarehouse_CellDoubleClick(gridWarehouse, new DataGridViewCellEventArgs(0, gridWarehouse.SelectedRows[0].Index));
		}
		#endregion

		#region Items tab
		private void LoadItemsTab()
		{
			gridItems.Rows.Clear();

			List<ItemWithCategory> items = ComplexQueries.GetItemsWithCategories();

			foreach (ItemWithCategory w in items)
			{
				AddItemEntry(w);
			}
		}

		private void AddItemEntry(ItemWithCategory i)
		{
			DataGridViewRow row = new DataGridViewRow();
			row.CreateCells(gridItems);

			UpdateItemRowCells(row, i);

			gridItems.Rows.Add(row);
		}

		private void UpdateItemRowCells(DataGridViewRow row, ItemWithCategory i)
		{
			row.Cells[0].Value = i.Name;
			row.Cells[1].Value = i.Price;
			row.Cells[2].Value = i.CategoryName;
			row.Cells[3].Value = i.Description;

			row.Tag = i;
		}

		private void gridItems_SelectionChanged(object sender, System.EventArgs e)
		{
			btnDeleteItem.Enabled = (gridItems.SelectedRows.Count > 0);
			btnEditItem.Enabled = (gridItems.SelectedRows.Count == 1);
		}

		private void btnDeleteItem_Click(object sender, System.EventArgs e)
		{
			DataGridViewRow[] selected = new DataGridViewRow[gridItems.SelectedRows.Count];
			gridItems.SelectedRows.CopyTo(selected, 0);

			foreach (DataGridViewRow row in selected)
			{
				ItemWithCategory item = (ItemWithCategory)row.Tag;

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
					ItemWithCategory newItem = edit.EditedItem;

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

			using (ItemEditForm itemEdit = new ItemEditForm((ItemWithCategory)row.Tag))
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

		private void btnEditItem_Click(object sender, System.EventArgs e)
		{
			gridItems_CellDoubleClick(gridItems, new DataGridViewCellEventArgs(0, gridItems.SelectedRows[0].Index));
		}
		#endregion

		#region Partners tab
		private void LoadPartnersTab()
		{
			gridPartners.Rows.Clear();

			List<Partner> partners = Global.Database.SelectAll<Partner>("partner");

			foreach (Partner p in partners)
			{
				AddPartnerEntry(p);
			}
		}

		private void AddPartnerEntry(Partner p)
		{
			DataGridViewRow row = new DataGridViewRow();
			row.CreateCells(gridPartners);

			UpdatePartnerRowCells(row, p);

			gridPartners.Rows.Add(row);
		}

		private void UpdatePartnerRowCells(DataGridViewRow row, Partner p)
		{
			row.Cells[0].Value = p.Name;
			row.Cells[1].Value = p.Telephone;
			row.Cells[2].Value = p.Email;
			row.Cells[3].Value = p.City;
			row.Cells[4].Value = p.PostCode;
			row.Cells[5].Value = p.Street;
			row.Cells[6].Value = p.StreetNumber;

			row.Tag = p;
		}

		private void gridPartners_SelectionChanged(object sender, System.EventArgs e)
		{
			btnDeletePartner.Enabled = (gridPartners.SelectedRows.Count > 0);
			btnEditPartner.Enabled = (gridPartners.SelectedRows.Count == 1);
		}

		private void btnDeletePartner_Click(object sender, System.EventArgs e)
		{
			DataGridViewRow[] selected = new DataGridViewRow[gridPartners.SelectedRows.Count];
			gridPartners.SelectedRows.CopyTo(selected, 0);

			foreach (DataGridViewRow row in selected)
			{
				Partner partner = (Partner)row.Tag;

				if (!Global.Database.DeleteFrom<Partner>("partner", partner))
				{
					Error("Hiba a sor törlése közben! \"" + partner.Name + "\"", "Hiba!");
					return;
				}

				gridPartners.Rows.Remove(row);
			}
		}

		private void btnNewPartner_Click(object sender, System.EventArgs e)
		{
			using (PartnerEditForm edit = new PartnerEditForm())
			{
				if (edit.ShowDialog(this) == DialogResult.OK)
				{
					Partner newPartner = edit.EditPartner;

					if (Global.Database.InsertInto<Partner>("partner", newPartner))
					{
						AddPartnerEntry(newPartner);
					}
					else
					{
						Error("Hiba a(z) \"" + edit.EditPartner.Name + "\" hozzáadása közben!", "Hiba!");
					}
				}
			}
		}

		private void gridPartners_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0 || e.RowIndex >= gridPartners.Rows.Count)
				return;

			DataGridViewRow row = gridPartners.Rows[e.RowIndex];

			using (PartnerEditForm partnerEdit = new PartnerEditForm((Partner)row.Tag))
			{
				if (partnerEdit.ShowDialog(this) == DialogResult.OK)
				{
					if (Global.Database.Update<Partner>("partner", partnerEdit.EditPartner))
					{
						UpdatePartnerRowCells(row, partnerEdit.EditPartner);
					}
					else
					{
						Error("Hiba a(z) \"" + partnerEdit.EditPartner.Name + "\" frissítése közben!", "Hiba");
					}
				}
			}
		}

		private void btnEditPartner_Click(object sender, System.EventArgs e)
		{
			gridPartners_CellDoubleClick(gridPartners, new DataGridViewCellEventArgs(0, gridPartners.SelectedRows[0].Index));
		}
		#endregion

		#region Stock tab
		private void LoadStockTab()
		{
			int selectedEntryID = -1;
			if (gridStock.SelectedRows.Count > 0)
			{
				selectedEntryID = ((StockSummary)gridStock.SelectedRows[0].Tag).ItemID;
			}

			gridStock.Rows.Clear();

			List<StockSummary> summary = ComplexQueries.GetStockSummary();

			foreach (StockSummary sum in summary)
			{
				DataGridViewRow newRow = AddStockEntry(sum);

				if (selectedEntryID != -1 && sum.ItemID == selectedEntryID)
				{
					newRow.Selected = true;
				}
			}
		}

		private DataGridViewRow AddStockEntry(StockSummary w)
		{
			DataGridViewRow row = new DataGridViewRow();
			row.CreateCells(gridStock);

			UpdateStockRowCells(row, w);

			gridStock.Rows.Add(row);

			return row;
		}

		private void UpdateStockRowCells(DataGridViewRow row, StockSummary w)
		{
			row.Cells[0].Value = w.ItemName;
			row.Cells[1].Value = w.Count;

			row.Tag = w;
		}

		private void gridStock_SelectionChanged(object sender, System.EventArgs e)
		{
			btnStockEdit.Enabled = (gridStock.SelectedRows.Count == 1);
		}

		private void gridStock_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0 || e.RowIndex >= gridStock.Rows.Count)
				return;

			DataGridViewRow row = gridStock.Rows[e.RowIndex];
			StockSummary stock = (StockSummary)row.Tag;

			using (StockManagerForm stockDialog = new StockManagerForm(stock.ItemID))
			{
				if (stockDialog.ShowDialog(this) == DialogResult.OK && stockDialog.DataChanged)
				{
					LoadStockTab();
				}
			}
		}

		private void btnStockEdit_Click(object sender, System.EventArgs e)
		{
			gridStock_CellDoubleClick(gridStock, new DataGridViewCellEventArgs(0, gridStock.SelectedRows[0].Index));
		}
		#endregion
	}
}
