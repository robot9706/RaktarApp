using Raktar.Database;
using System.Linq;
using System.Collections.Generic;
using Raktar.App.Data;
using System;

namespace Raktar.App.Forms
{
	public partial class NewPartnerShipmentForm : AppForm
	{
		public PartnerShipment NewShipment
		{
			get
			{
				return new PartnerShipment()
				{
					WarehouseID = ((WarehouseStock)cbWarehouse.Items[cbWarehouse.SelectedIndex]).WarehouseID,
					ItemID = ((Item)cbItem.Items[cbItem.SelectedIndex]).ID,
					PartnerID = ((Partner)cbPartner.Items[cbPartner.SelectedIndex]).ID,
					Count = Convert.ToInt32(tbCount.Text),
					Date = dateTime.Value,
					IsSell = cbSell.Checked
				};
			}
		}

		private List<Warehouse> _allWarehouse;

		public NewPartnerShipmentForm()
		{
			InitializeComponent();

			AppDesign.Apply(this);
		}

		private void NewPartnerShipmentForm_Load(object sender, System.EventArgs e)
		{
			List<Item> items = Global.Database.SelectAll<Item>("item");
			if (items != null)
			{
				items = items.OrderBy(o => o.Name).ToList();

				foreach (Item i in items)
				{
					cbItem.Items.Add(i);
				}
			}

			List<Partner> partners = Global.Database.SelectAll<Partner>("partner");
			if (partners != null)
			{
				partners = partners.OrderBy(o => o.Name).ToList();

				foreach (Partner p in partners)
				{
					cbPartner.Items.Add(p);
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
				WarehouseStock warehouse = ((WarehouseStock)cbWarehouse.Items[cbWarehouse.SelectedIndex]);
				if (warehouse is EmptyWarehouseStock)
				{
					Stock newEmptyStock = new Stock()
					{
						Warehouse = warehouse.WarehouseID,
						ItemID = item.ID,
						Count = 0
					};

					Global.Database.InsertInto<Stock>("stock", newEmptyStock);
				}

				if (cbSell.Checked)
				{
					Stock stock = Global.Database.SelectOne<Stock>("stock", new Dictionary<string, object>()
					{
						{ "ItemID", item.ID },
						{ "WarehouseID", warehouse.WarehouseID }
					});

					int count = Convert.ToInt32(tbCount.Text);

					if (stock.Count < count)
					{
						Error("Nincs elég \"" + item.Name + "\" a \"" + warehouse.WarehouseName + "\" raktárban.\nSzállítnány: " + count.ToString() + "\nRaktárban: " + stock.Count.ToString(), "Hiba");
						return;
					}
				}

				DialogResult = System.Windows.Forms.DialogResult.OK;
			}
		}

		private void cbItem_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			cbWarehouse.SelectedIndex = -1;
			cbWarehouse.Items.Clear();

			if (cbItem.SelectedIndex > -1)
			{
				Item item = ((Item)cbItem.Items[cbItem.SelectedIndex]);

				List<WarehouseStock> stock = ComplexQueries.GetItemStock(item.ID);
				int[] ids = stock.Select(x => x.WarehouseID).ToArray();

				List<Warehouse> emptyWarehouse = _allWarehouse.Where(x => !ids.Contains(x.ID)).ToList();

				if (stock != null && stock.Count > 0)
				{
					stock = stock.OrderBy(s => s.WarehouseName).ToList();

					foreach(WarehouseStock s in stock)
					{
						cbWarehouse.Items.Add(s);
					}
				}

				if (emptyWarehouse != null && emptyWarehouse.Count > 0)
				{
					emptyWarehouse = emptyWarehouse.OrderBy(s => s.Name).ToList();

					foreach (Warehouse s in emptyWarehouse)
					{
						cbWarehouse.Items.Add(new EmptyWarehouseStock()
						{
							WarehouseID = s.ID,
							WarehouseName = s.Name
						});
					}
				}

				cbWarehouse.Enabled = (cbWarehouse.Items.Count > 0);
			}
			else
			{
				cbWarehouse.Enabled = false;
			}

			ValidateInput();
		}

		private void cbWarehouse_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			ValidateInput();
		}

		private void dateTime_ValueChanged(object sender, System.EventArgs e)
		{
			ValidateInput();
		}

		private void tbCount_TextChanged(object sender, System.EventArgs e)
		{
			int count;
			lblCountError.Visible = (!Int32.TryParse(tbCount.Text, out count) || count <= 0);

			ValidateInput();
		}

		private void cbSell_CheckedChanged(object sender, System.EventArgs e)
		{
			ValidateInput();
		}

		private bool ValidateInput()
		{
			return btnShip.Enabled = (
				cbItem.SelectedIndex > -1 &&
				cbWarehouse.SelectedIndex > -1 &&
				cbPartner.SelectedIndex > -1 &&
				!string.IsNullOrEmpty(tbCount.Text) &&
				!lblCountError.Visible
				);
		}
	}
}
