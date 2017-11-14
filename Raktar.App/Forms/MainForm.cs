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

			UpdateRowCells(row, w);

			gridWarehouse.Rows.Add(row);
		}

		private void UpdateRowCells(DataGridViewRow row, Warehouse w)
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
					if(Global.Database.InsertInto<Warehouse>("warehouse", whEdit.EditedWarehouse))
					{
						AddWarehouseEntry(whEdit.EditedWarehouse);
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
						UpdateRowCells(row, whEdit.EditedWarehouse);
					}
					else
					{
						Error("Hiba a \"" + whEdit.EditedWarehouse.Name + "\" frissítése közben!", "Hiba");
					}
				}
			}
		}
		#endregion
	}
}
