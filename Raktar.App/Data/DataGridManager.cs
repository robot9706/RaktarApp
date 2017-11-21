using Raktar.Database;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Raktar.App.Data
{
	class DataGridManager
	{
		private static Dictionary<Type, Action<DataGridViewRow, object>> _fillers = new Dictionary<Type, Action<DataGridViewRow, object>>()
		{
			{ typeof(Warehouse), new Action<DataGridViewRow, object>(FillWarehouse) },
			{ typeof(ItemWithCategory), new Action<DataGridViewRow, object>(FillItemWithCategory) },
			{ typeof(Partner), new Action<DataGridViewRow, object>(FillPartner) },
			{ typeof(StockSummary), new Action<DataGridViewRow, object>(FillStockSummary) },
			{ typeof(WarehouseStock), new Action<DataGridViewRow, object>(FillWarehouseStock) },
		};

		public static void AddDataGridEntries<T>(DataGridView grid, List<T> values, bool clear = true, Action<DataGridViewRow> rowAction = null)
		{
			if (clear)
			{
				grid.Rows.Clear();
			}

			if (values == null)
				return;

			foreach (T val in values)
			{
				DataGridViewRow newRow = AddDataGridEntry<T>(grid, val);

				if (rowAction != null)
					rowAction(newRow);
			}
		}

		public static DataGridViewRow AddDataGridEntry<T>(DataGridView grid, T value)
		{
			DataGridViewRow row = new DataGridViewRow();
			row.CreateCells(grid);

			UpdateRow<T>(row, value);

			grid.Rows.Add(row);

			return row;
		}

		public static void UpdateRow<T>(DataGridViewRow row, T value)
		{
			if (value == null)
				return;

			Type t = typeof(T);

			if (!_fillers.ContainsKey(t))
			{
				throw new Exception("Ismeretlen típus: \"" + t.FullName + "\"");
			}

			_fillers[t](row, value);

			row.Tag = value;
		}

		private static void FillWarehouse(DataGridViewRow row, object data)
		{
			if (data is Warehouse warehouse)
			{
				row.Cells[0].Value = warehouse.Name;
				row.Cells[1].Value = warehouse.City;
				row.Cells[2].Value = warehouse.PostCode;
				row.Cells[3].Value = warehouse.Street;
				row.Cells[4].Value = warehouse.StreetNumber;
			}
		}

		private static void FillItemWithCategory(DataGridViewRow row, object data)
		{
			if(data is ItemWithCategory item)
			{
				row.Cells[0].Value = item.Name;
				row.Cells[1].Value = item.Price;
				row.Cells[2].Value = item.CategoryName;
				row.Cells[3].Value = item.Description;
			}
		}

		private static void FillPartner(DataGridViewRow row, object data)
		{
			if(data is Partner partner)
			{
				row.Cells[0].Value = partner.Name;
				row.Cells[1].Value = partner.Telephone;
				row.Cells[2].Value = partner.Email;
				row.Cells[3].Value = partner.City;
				row.Cells[4].Value = partner.PostCode;
				row.Cells[5].Value = partner.Street;
				row.Cells[6].Value = partner.StreetNumber;
			}
		}

		private static void FillStockSummary(DataGridViewRow row, object data)
		{
			if (data is StockSummary summary)
			{
				row.Cells[0].Value = summary.ItemName;
				row.Cells[1].Value = summary.Count;
			}
		}

		private static void FillWarehouseStock(DataGridViewRow row, object data)
		{
			if (data is WarehouseStock stock)
			{
				row.Cells[0].Value = stock.WarehouseName;
				row.Cells[1].Value = stock.ItemCount;
			}
		}
	}
}
