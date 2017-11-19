using System;
using System.Collections.Generic;

namespace Raktar.App.Data
{
	class ComplexQueries
	{
		private static string _itemsWithCategoriesQuery = 
			"SELECT items.ItemID, items.Name, items.Price, items.Description, items.CategoryID, category.Name AS 'CategoryName' " + 
			"FROM `items`, `category` " +
			"WHERE category.CategoryID = items.CategoryID;";

		private static string _stockSummaryQuery =
			"SELECT stock.ItemID as 'ItemID', items.Name AS 'ItemName', SUM(stock.Count) as 'Count' " +
			"FROM stock, items " +
			"WHERE items.ItemID = stock.ItemID GROUP BY stock.ItemID;";

		private static string _warehouseStockQuery =
			"SELECT warehouse.Name AS 'WarehouseName', warehouse.ID AS 'WarehouseID', stock.Count AS 'ItemCount' " +
			"FROM warehouse, stock " +
			"WHERE warehouse.ID = stock.Warehouse AND stock.ItemID = {0};";

		public static List<ItemWithCategory> GetItemsWithCategories()
		{
			return Global.Database.Select<ItemWithCategory>(_itemsWithCategoriesQuery);
		}

		public static List<StockSummary> GetStockSummary()
		{
			return Global.Database.Select<StockSummary>(_stockSummaryQuery);
		}

		public static List<WarehouseStock> GetItemStock(int itemID)
		{
			return Global.Database.Select<WarehouseStock>(String.Format(_warehouseStockQuery, itemID));
		}
	}
}
