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

		private List<Warehouse> _allWarehouse;

		public NewShipmentForm()
		{
			InitializeComponent();

			AppDesign.Apply(this);
		}

		private void NewShipmentForm_Load(object sender, System.EventArgs e)
		{
			List<Item> items = Global.Database.SelectAll<Item>("item");
			if(items != null)
			{
				items = items.OrderBy(i => i.Name).ToList();

				foreach(Item i in items)
				{
					cbItem.Items.Add(i);
				}
			}

			_allWarehouse = Global.Database.SelectAll<Warehouse>("warehouse");
			if (_allWarehouse == null)
				_allWarehouse = new List<Warehouse>();
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
				CheckEmptyStock(fromStock, item);

				WarehouseStock toStock = ((WarehouseStock)cbTo.Items[cbTo.SelectedIndex]);
				CheckEmptyStock(toStock, item);

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

		private void CheckEmptyStock(WarehouseStock stock, Item item)
		{
			if (!(stock is EmptyWarehouseStock))
				return;

			Stock newEmptyStock = new Stock()
			{
				Warehouse = stock.WarehouseID,
				ItemID = item.ID,
				Count = 0
			};

			Global.Database.InsertInto<Stock>("stock", newEmptyStock);
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
				int[] ids = stock.Select(x => x.WarehouseID).ToArray();

				List<Warehouse> emptyWarehouse = _allWarehouse.Where(x => !ids.Contains(x.ID)).ToList();

				if (stock != null && stock.Count > 0)
				{
					stock = stock.OrderBy(s => s.WarehouseName).ToList();

					foreach (WarehouseStock s in stock)
					{
						if (s.ItemCount <= 0)
							continue;

						cbFrom.Items.Add(s);
						cbTo.Items.Add(s);
					}
				}
				if (emptyWarehouse != null && emptyWarehouse.Count > 0)
				{
					emptyWarehouse = emptyWarehouse.OrderBy(s => s.Name).ToList();

					foreach (Warehouse s in emptyWarehouse)
					{
						cbFrom.Items.Add(new EmptyWarehouseStock()
						{
							WarehouseID = s.ID,
							WarehouseName = s.Name
						});

						cbTo.Items.Add(new EmptyWarehouseStock()
						{
							WarehouseID = s.ID,
							WarehouseName = s.Name
						});
					}
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
