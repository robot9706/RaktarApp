using MetroFramework;
using Raktar.App.Data;
using Raktar.Database;
using System;
using System.ComponentModel;
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
				LoadShipmentTab();
				LoadPartnerShipmentTab();
			}
			ResumeLayout();
		}

		#region Warehouse tab
		private void LoadWarehouseTab()
		{
			DataGridManager.AddDataGridEntries<Warehouse>(gridWarehouse, Global.Database.SelectAll<Warehouse>("warehouse"));
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
						DataGridManager.AddDataGridEntry<Warehouse>(gridWarehouse, newWarehouse);
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
						DataGridManager.UpdateRow<Warehouse>(row, whEdit.EditedWarehouse);
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
			DataGridManager.AddDataGridEntries<ItemWithCategory>(gridItems, ComplexQueries.GetItemsWithCategories());
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
						DataGridManager.AddDataGridEntry<ItemWithCategory>(gridItems, newItem);
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
						DataGridManager.UpdateRow<ItemWithCategory>(row, itemEdit.EditedItem);
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
			DataGridManager.AddDataGridEntries<Partner>(gridPartners, Global.Database.SelectAll<Partner>("partner"));
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
						DataGridManager.AddDataGridEntry<Partner>(gridPartners, newPartner);
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
						DataGridManager.UpdateRow<Partner>(row, partnerEdit.EditPartner);
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

			DataGridManager.AddDataGridEntries<StockSummary>(gridStock, ComplexQueries.GetStockSummary(), true, new Action<DataGridViewRow>(
				(DataGridViewRow row) =>
				{
					StockSummary sum = (StockSummary)row.Tag;

					if (selectedEntryID != -1 && sum.ItemID == selectedEntryID)
					{
						row.Selected = true;
					}
				}
			));
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

		#region Shipment tab
		private void LoadShipmentTab()
		{
			int selectedEntryID = -1;
			if (gridShipment.SelectedRows.Count > 0)
			{
				selectedEntryID = ((ShipmentSummary)gridShipment.SelectedRows[0].Tag).ItemID;
			}

			DataGridManager.AddDataGridEntries<ShipmentSummary>(gridShipment, ComplexQueries.GetShipmentSummary(), true, new Action<DataGridViewRow>(
				(DataGridViewRow row) =>
				{
					ShipmentSummary sum = (ShipmentSummary)row.Tag;

					if (selectedEntryID != -1 && sum.ItemID == selectedEntryID)
					{
						row.Selected = true;
					}
				}
			));

			gridShipment.Sort(gridShipment.Columns["colDate"], ListSortDirection.Ascending);
		}

		private void gridShipment_SelectionChanged(object sender, EventArgs e)
		{
			btnDeleteShipment.Enabled = btnShipmentRevert.Enabled = (gridShipment.SelectedRows.Count == 1);
		}

		private void btnDeleteShipment_Click(object sender, EventArgs e)
		{
			if (MetroMessageBox.Show(this, "Biztosan törölni akarja a szállítmányt?", "Biztos?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
				return;

			DataGridViewRow row = gridShipment.SelectedRows[0];

			ShipmentSummary shipment = (ShipmentSummary)row.Tag;

			if(!Global.Database.DeleteFrom<Shipment>("shipment", shipment))
			{
				Error("Hiba a szállitmány törlése közben!", "Hiba");
			}
			else
			{
				gridShipment.Rows.Remove(row);

				LoadShipmentTab();
			}
		}

		private void btnShipmentRevert_Click(object sender, EventArgs e)
		{
			if (MetroMessageBox.Show(this, "Biztosan vissza akarja vonni a szállítmányt?", "Biztos?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
				return;

			DataGridViewRow row = gridShipment.SelectedRows[0];

			ShipmentSummary shipment = (ShipmentSummary)row.Tag;

			switch (ComplexQueries.RevertShipment(shipment))
			{
				case ComplexQueries.ShipmentStatus.DatabaseError:
					Error("Adatbázis hiba!", "Hiba");
					break;
				case ComplexQueries.ShipmentStatus.InvalidItemCount:
					Error("A cél raktárban nincs elég a cikkből, hogy csökkenteni lehessen!", "Hiba");
					break;
				case ComplexQueries.ShipmentStatus.OK:
					LoadStockTab();

					LoadShipmentTab();

					Info("Szállítmány visszavonva!", "Kész");
					break;
			}
		}

		private void btnNewShipment_Click(object sender, EventArgs e)
		{
			using (NewShipmentForm newShipment = new NewShipmentForm())
			{
				if (newShipment.ShowDialog(this) == DialogResult.OK)
				{
					Shipment shipment = newShipment.NewShipment;

					if (!Global.Database.InsertInto<Shipment>("shipment", shipment))
					{
						Error("Hiba a szállítmány létrehozása közben!", "Hiba");
						return;
					}

					ShipmentSummary newSummary = ComplexQueries.GetShipmentSummary(shipment);

					if (newSummary == null)
					{
						Error("Hiba a szállítmány létrehozása közben!", "Hiba");
						return;
					}

					switch (ComplexQueries.DoShipment(newSummary))
					{
						case ComplexQueries.ShipmentStatus.DatabaseError:
							Error("Adatbázis hiba!", "Hiba");
							break;
						case ComplexQueries.ShipmentStatus.InvalidItemCount:
							Error("Nincs elég a szállított tárgyból a raktárban!", "Hiba");
							break;
						case ComplexQueries.ShipmentStatus.OK:
							DataGridManager.AddDataGridEntry<ShipmentSummary>(gridShipment, newSummary);

							LoadStockTab();
							break;
					}
				}
			}
		}
		#endregion

		#region PartnerShipment tab
		private void LoadPartnerShipmentTab()
		{
			int selectedEntryID = -1;
			if (gridPartnerShipment.SelectedRows.Count > 0)
			{
				selectedEntryID = ((PartnerShipmentSummary)gridPartnerShipment.SelectedRows[0].Tag).ItemID;
			}

			DataGridManager.AddDataGridEntries<PartnerShipmentSummary>(gridPartnerShipment, ComplexQueries.GetPartnerShipmentSummary(), true, new Action<DataGridViewRow>(
				(DataGridViewRow row) =>
				{
					PartnerShipmentSummary sum = (PartnerShipmentSummary)row.Tag;

					if (selectedEntryID != -1 && sum.ItemID == selectedEntryID)
					{
						row.Selected = true;
					}
				}
			));

			gridPartnerShipment.Sort(gridPartnerShipment.Columns["colPartnerDate"], ListSortDirection.Ascending);
		}

		private void gridPartnerShipment_SelectionChanged(object sender, EventArgs e)
		{
			btnDeletePShipment.Enabled = btnRevertPShipment.Enabled = (gridPartnerShipment.SelectedRows.Count == 1);
		}

		private void btnDeletePShipment_Click(object sender, EventArgs e)
		{
			if (MetroMessageBox.Show(this, "Biztosan törölni akarja a szállítmányt?", "Biztos?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
				return;

			DataGridViewRow row = gridPartnerShipment.SelectedRows[0];

			PartnerShipmentSummary pshipment = (PartnerShipmentSummary)row.Tag;

			if (!Global.Database.DeleteFrom<PartnerShipmentSummary>("partnershipment", pshipment))
			{
				Error("Hiba a szállitmány törlése közben!", "Hiba");
			}
			else
			{
				gridPartnerShipment.Rows.Remove(row);

				LoadPartnerShipmentTab();
			}
		}

		private void btnRevertPShipment_Click(object sender, EventArgs e)
		{
			if (MetroMessageBox.Show(this, "Biztosan vissza akarja vonni a szállítmányt?", "Biztos?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
				return;

			DataGridViewRow row = gridPartnerShipment.SelectedRows[0];

			PartnerShipmentSummary shipment = (PartnerShipmentSummary)row.Tag;

			switch (ComplexQueries.RevertPartnerShipment(shipment))
			{
				case ComplexQueries.ShipmentStatus.DatabaseError:
					Error("Adatbázis hiba!", "Hiba");
					break;
				case ComplexQueries.ShipmentStatus.InvalidItemCount:
					Error("A cél raktárban nincs elég a cikkből, hogy csökkenteni lehessen!", "Hiba");
					break;
				case ComplexQueries.ShipmentStatus.OK:
					LoadStockTab();

					LoadPartnerShipmentTab();

					Info("Szállítmány visszavonva!", "Kész");
					break;
			}
		}

		private void btnNewPShipment_Click(object sender, EventArgs e)
		{
			using (NewPartnerShipmentForm newPartnerShipment = new NewPartnerShipmentForm())
			{
				if (newPartnerShipment.ShowDialog(this) == DialogResult.OK)
				{
					PartnerShipment pshipment = newPartnerShipment.NewShipment;

					if (!Global.Database.InsertInto<PartnerShipment>("partnershipment", pshipment))
					{
						Error("Hiba a szállítmány létrehozása közben!", "Hiba");
						return;
					}

					PartnerShipmentSummary newSummary = ComplexQueries.GetPartnerShipmentSummary(pshipment);

					if (newSummary == null)
					{
						Error("Hiba a szállítmány létrehozása közben!", "Hiba");
						return;
					}

					switch (ComplexQueries.DoPartnerShipment(newSummary))
					{
						case ComplexQueries.ShipmentStatus.DatabaseError:
							Error("Adatbázis hiba!", "Hiba");
							break;
						case ComplexQueries.ShipmentStatus.InvalidItemCount:
							Error("Nincs elég a szállított tárgyból a raktárban!", "Hiba");
							break;
						case ComplexQueries.ShipmentStatus.OK:
							DataGridManager.AddDataGridEntry<PartnerShipmentSummary>(gridPartnerShipment, newSummary);

							LoadStockTab();
							break;
					}
				}
			}
		}
		#endregion
	}
}
