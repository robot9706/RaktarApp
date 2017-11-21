using Raktar.Database;
using System.Linq;
using System.Collections.Generic;
using System;
using Raktar.App.Data;

namespace Raktar.App.Forms
{
	public partial class NewShipmentForm : AppForm
	{
		public Shipment NewShipment
		{
			get
			{
				return new Shipment()
				{
					WarehouseFrom = ((WarehouseStock)cbFrom.Items[cbFrom.SelectedIndex]).WarehouseID,
					WarehouseTo = ((WarehouseStock)cbTo.Items[cbTo.SelectedIndex]).WarehouseID,
					ItemID = ((Item)cbItem.Items[cbItem.SelectedIndex]).ID,
					Count = Convert.ToInt32(tbCount.Text),
					Date = dateTime.Value
				};
			}
		}

		public NewShipmentForm()
		{
			InitializeComponent();

			AppDesign.Apply(this);
		}

		private void NewShipmentForm_Load(object sender, System.EventArgs e)
		{
			List<Item> items = Global.Database.SelectAll<Item>("items");
			if(items != null)
			{
				items = items.OrderBy(i => i.Name).ToList();

				foreach(Item i in items)
				{
					cbItem.Items.Add(i);
				}
			}
		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			DialogResult = System.Windows.Forms.DialogResult.Cancel;
		}

		private void btnShip_Click(object sender, System.EventArgs e)
		{
			if (ValidateInput())
			{
				Item item = ((Item)cbItem.Items[cbItem.SelectedIndex]);
				WarehouseStock fromStock = ((WarehouseStock)cbFrom.Items[cbFrom.SelectedIndex]);

				int count = Convert.ToInt32(tbCount.Text);

				if (fromStock.ItemCount < count)
				{
					Error("Nincs elég \"" + item.Name + "\" a \"" + fromStock.WarehouseName + "\" raktárban.\nSzállítnány: " + count.ToString() + "\nRaktárban: " + fromStock.ItemCount.ToString(), "Hiba");
				}
				else
				{
					DialogResult = System.Windows.Forms.DialogResult.OK;
				}
			}
		}

		private void cbItem_SelectedIndexChanged(object sender, EventArgs e)
		{
			cbFrom.SelectedIndex = -1;
			cbTo.SelectedIndex = -1;

			cbFrom.Items.Clear();
			cbTo.Items.Clear();

			if (cbItem.SelectedIndex > -1)
			{
				List<WarehouseStock> stock = ComplexQueries.GetItemStock(((Item)cbItem.Items[cbItem.SelectedIndex]).ID);

				stock = stock.OrderBy(s => s.WarehouseName).ToList();

				foreach (WarehouseStock s in stock)
				{
					if (s.ItemCount <= 0)
						continue;

					cbFrom.Items.Add(s);
					cbTo.Items.Add(s);
				}

				cbFrom.Enabled = cbTo.Enabled = (cbFrom.Items.Count > 0);
			}
			else
			{
				cbFrom.Enabled = cbTo.Enabled = false;
			}
		}

		private void cbFrom_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			ValidateInput();
		}

		private void tbCount_TextChanged(object sender, EventArgs e)
		{
			int count;
			lblCountError.Visible = (!Int32.TryParse(tbCount.Text, out count) || count <= 0);

			ValidateInput();
		}

		private void dateTime_ValueChanged(object sender, System.EventArgs e)
		{
			ValidateInput();
		}

		private bool ValidateInput()
		{
			return btnShip.Enabled = (
				cbFrom.SelectedIndex > -1 &&
				cbTo.SelectedIndex > -1 &&
				cbItem.SelectedIndex > -1 &&
				!lblCountError.Visible &&
				!string.IsNullOrEmpty(tbCount.Text) &&
				cbFrom.SelectedIndex != cbTo.SelectedIndex
			);
		}
	}
}
