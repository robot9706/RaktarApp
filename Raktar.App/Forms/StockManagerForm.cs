using MetroFramework;
using Raktar.App.Data;
using Raktar.Database;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Raktar.App.Forms
{
	public partial class StockManagerForm : AppForm
	{
		public bool DataChanged
		{
			get;
			private set;
		}

		private int _stockItemID;

		public StockManagerForm(int itemID)
		{
			InitializeComponent();

			AppDesign.Apply(this);

			DataChanged = false;

			_stockItemID = itemID;
		}

		private void StockManagerForm_Load(object sender, System.EventArgs e)
		{
			SuspendLayout();
			{
				//Fejléc
				Item item = Global.Database.SelectOne<Item>("item", new Dictionary<string, object>() { { "ItemID", _stockItemID } });
				if (item != null)
				{
					this.Text = "Készlet - \"" + item.Name + "\"";
				}

				//Adat
				DataGridManager.AddDataGridEntries<WarehouseStock>(gridStock, ComplexQueries.GetItemStock(_stockItemID));

				gridStock.Focus();
			}
			ResumeLayout();
		}

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			DialogResult = System.Windows.Forms.DialogResult.OK;
		}

		private void gridStock_SelectionChanged(object sender, System.EventArgs e)
		{
			UpdateManagePanel(gridStock.SelectedRows.Count == 1);
		}

		private void UpdateManagePanel(bool enabled)
		{
			panelManage.Enabled = enabled;

			if (panelManage.Enabled)
			{
				WarehouseStock stock = ((WarehouseStock)gridStock.SelectedRows[0].Tag);

				lblWarehouse.Text = String.Format((string)lblWarehouse.Tag, stock.WarehouseName);

				tbNumber.Tag = stock.ItemCount;
				tbNumber.Text = stock.ItemCount.ToString();
			}
		}

		private void tbNumber_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(tbNumber.Text))
			{
				btnUpdate.Enabled = false;
				lblNumberError.Visible = false;

				return;
			}

			int count;
			bool valid = (Int32.TryParse(tbNumber.Text, out count) && count >= 0);

			int originalCount = (int)tbNumber.Tag;

			lblNumberError.Visible = (!valid);
			btnUpdate.Enabled = (valid && count != originalCount);
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			WarehouseStock stock = ((WarehouseStock)gridStock.SelectedRows[0].Tag);
			if (stock == null)
				return;

			int count;
			if (!Int32.TryParse(tbNumber.Text, out count) || count < 0)
				return;

			if (tbNumber.Tag == null)
				return;

			int originalCount = (int)tbNumber.Tag;

			if (MetroMessageBox.Show(this, "Frissíteni akarja a cikk \""  + stock.WarehouseName + "\" raktárban lévő számát?\nEredeti darabszám: " + originalCount.ToString() +
				"\nÚj darabszám: " + count.ToString(),
				"Módosítás",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question) == DialogResult.Yes)
			{
				Stock stockRow = Global.Database.SelectOne<Stock>("stock", new Dictionary<string, object>()
				{
					{ "ItemID", _stockItemID },
					{ "Warehouse", stock.WarehouseID }
				});

				if(stockRow == null)
				{
					Error("Hiba az adatbázis elérése közben!", "Hiba");
					return;
				}

				stockRow.Count = count;

				if (Global.Database.Update<Stock>("stock", stockRow))
				{
					stock.ItemCount = count;

					DataGridManager.UpdateRow<WarehouseStock>(gridStock.SelectedRows[0], stock);

					DataChanged = true;

					tbNumber.Tag = count;
					btnUpdate.Enabled = false;
				}
				else
				{
					Error("Hiba az adat módosítása közben!", "Hiba");
				}
			}
		}
	}
}
