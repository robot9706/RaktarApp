using Raktar.Database;
using System.Collections.Generic;
using System.Data.Odbc;

namespace Raktar.App.Data
{
	class ComplexQueries
	{
		#region Stock handling queries
		public enum ShipmentStatus
		{
			DatabaseError,
			InvalidItemCount,
			OK
		}

		private static string _itemsWithCategoriesQuery =
			"SELECT item.ID, item.Name, item.Price, item.Description, item.CategoryID, category.Name AS 'CategoryName' " +
			"FROM `item`, `category` " +
			"WHERE category.ID = item.CategoryID;";

		private static string _stockSummaryQuery =
			"SELECT stock.ItemID as 'ItemID', item.Name AS 'ItemName', SUM(stock.Count) as 'Count' " +
			"FROM stock, item " +
			"WHERE item.ID = stock.ItemID GROUP BY stock.ItemID;";

		private static string _warehouseStockQuery =
			"SELECT warehouse.Name AS 'WarehouseName', warehouse.ID AS 'WarehouseID', stock.Count AS 'ItemCount' " +
			"FROM warehouse, stock " +
			"WHERE warehouse.ID = stock.Warehouse AND stock.ItemID = ?;";

		private static string _shipmentSummaryQuery =
			"SELECT shipment.WarehouseFrom, shipment.WarehouseTo, shipment.ItemID, shipment.Date, shipment.Count, " +
			"W1.Name AS 'WarehouseFromName', W2.Name AS 'WarehouseToName', item.Name as 'ItemName' " +
			"FROM shipment, warehouse AS W1, warehouse as W2, item " +
			"WHERE item.ID = shipment.ItemID AND W1.ID = shipment.WarehouseFrom AND W2.ID = shipment.WarehouseTo;";

		private static string _shipmentSummaryDetailedQuery =
			"SELECT shipment.WarehouseFrom, shipment.WarehouseTo, shipment.ItemID, shipment.Date, shipment.Count, " +
			"W1.Name AS 'WarehouseFromName', W2.Name AS 'WarehouseToName', item.Name as 'ItemName' " +
			"FROM shipment, warehouse AS W1, warehouse as W2, item " +
			"WHERE item.ID = shipment.ItemID AND W1.ID = shipment.WarehouseFrom AND W2.ID = shipment.WarehouseTo AND " +
			"shipment.WarehouseFrom = ? AND shipment.WarehouseTo = ? AND shipment.ItemID = ? AND shipment.Date = ?;";

		private static string _partnerShipmentSummaryQuery =
			"SELECT partnershipment.PartnerID, partnershipment.ItemID, partnershipment.WarehouseID, partnershipment.Date, partnershipment.Count, partnershipment.Sell, " +
			"partner.Name AS 'PartnerName', warehouse.Name AS 'WarehouseName', item.Name AS 'ItemName' " +
			"FROM partnershipment, partner, item, warehouse " +
			"WHERE partnershipment.ItemID = item.ID AND partnershipment.PartnerID = partner.ID AND partnershipment.WarehouseID = warehouse.ID;";

		private static string _partnerShipmentDetailedSummaryQuery =
			"SELECT partnershipment.PartnerID, partnershipment.ItemID, partnershipment.WarehouseID, partnershipment.Date, partnershipment.Count, partnershipment.Sell, " +
			"partner.Name AS 'PartnerName', warehouse.Name AS 'WarehouseName', item.Name AS 'ItemName' " +
			"FROM partnershipment, partner, item, warehouse " +
			"WHERE partnershipment.ItemID = item.ID AND partnershipment.PartnerID = partner.ID AND partnershipment.WarehouseID = warehouse.ID AND " +
			"partnershipment.PartnerID = ? AND partnershipment.ItemID = ? AND partnershipment.WarehouseID = ? AND partnershipment.Date = ?;";

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
			return Global.Database.Select<WarehouseStock>(_warehouseStockQuery, new OdbcParameter("@itemID", itemID));
		}

		public static List<PartnerShipmentSummary> GetPartnerShipmentSummary()
		{
			return Global.Database.Select<PartnerShipmentSummary>(_partnerShipmentSummaryQuery);
		}

		public static PartnerShipmentSummary GetPartnerShipmentSummary(PartnerShipment source)
		{
			List<PartnerShipmentSummary> data = Global.Database.Select<PartnerShipmentSummary>(
				_partnerShipmentDetailedSummaryQuery,
				new OdbcParameter("@PartnerID", source.PartnerID),
				new OdbcParameter("@ItemID", source.ItemID),
				new OdbcParameter("@WarehouseID", source.WarehouseID),
				new OdbcParameter("@Date", OdbcType.Date) { Value = source.Date }
				);

			if (data != null && data.Count > 0)
				return data[0];

			return null;
		}

		public static ShipmentStatus DoPartnerShipment(PartnerShipment shipment)
		{
			Stock stock = Global.Database.SelectOne<Stock>("stock", new Dictionary<string, object>()
			{
				{ "ItemID", shipment.ItemID },
				{ "Warehouse", shipment.WarehouseID }
			});

			if (stock == null)
				return ShipmentStatus.DatabaseError;

			if (shipment.IsSell && stock.Count < shipment.Count)
				return ShipmentStatus.InvalidItemCount;

			if (shipment.IsSell)
			{
				stock.Count -= shipment.Count;
			}
			else
			{
				stock.Count += shipment.Count;
			}

			if (!Global.Database.Update<Stock>("stock", stock))
				return ShipmentStatus.DatabaseError;

			return ShipmentStatus.OK;
		}

		public static ShipmentStatus RevertPartnerShipment(PartnerShipment shipment)
		{
			Stock stock = Global.Database.SelectOne<Stock>("stock", new Dictionary<string, object>()
			{
				{ "ItemID", shipment.ItemID },
				{ "Warehouse", shipment.WarehouseID }
			});

			if (stock == null)
				return ShipmentStatus.DatabaseError;

			if (!shipment.IsSell && stock.Count < shipment.Count)
				return ShipmentStatus.InvalidItemCount;

			if (shipment.IsSell)
			{
				stock.Count += shipment.Count;
			}
			else
			{
				stock.Count -= shipment.Count;
			}

			if (!Global.Database.Update<Stock>("stock", stock))
				return ShipmentStatus.DatabaseError;

			if (!Global.Database.DeleteFrom<PartnerShipment>("partnershipment", shipment))
				return ShipmentStatus.DatabaseError;

			return ShipmentStatus.OK;
		}

		public static List<ShipmentSummary> GetShipmentSummary()
		{
			return Global.Database.Select<ShipmentSummary>(_shipmentSummaryQuery);
		}

		public static ShipmentSummary GetShipmentSummary(Shipment source)
		{
			List<ShipmentSummary> data = Global.Database.Select<ShipmentSummary>(
				_shipmentSummaryDetailedQuery,
				new OdbcParameter("@WarehouseFrom", source.WarehouseFrom),
				new OdbcParameter("@WarehouseTo", source.WarehouseTo),
				new OdbcParameter("@ItemID", source.ItemID),
				new OdbcParameter("@Date", OdbcType.Date) { Value = source.Date }
				);

			if (data != null && data.Count > 0)
				return data[0];

			return null;
		}

		public static ShipmentStatus DoShipment(Shipment shipment)
		{
			Stock stockFrom = Global.Database.SelectOne<Stock>("stock", new Dictionary<string, object>()
			{
				{ "ItemID", shipment.ItemID },
				{ "Warehouse", shipment.WarehouseFrom }
			});

			Stock stockTo = Global.Database.SelectOne<Stock>("stock", new Dictionary<string, object>()
			{
				{ "ItemID", shipment.ItemID },
				{ "Warehouse", shipment.WarehouseTo }
			});

			if (stockFrom == null || stockTo == null)
				return ShipmentStatus.DatabaseError;

			if (stockFrom.Count < shipment.Count)
				return ShipmentStatus.InvalidItemCount;

			stockFrom.Count -= shipment.Count;
			stockTo.Count += shipment.Count;

			if (!Global.Database.Update<Stock>("stock", stockFrom))
				return ShipmentStatus.DatabaseError;

			if (!Global.Database.Update<Stock>("stock", stockTo))
				return ShipmentStatus.DatabaseError;

			return ShipmentStatus.OK;
		}

		public static ShipmentStatus RevertShipment(Shipment shipment)
		{
			Stock stockFrom = Global.Database.SelectOne<Stock>("stock", new Dictionary<string, object>()
			{
				{ "ItemID", shipment.ItemID },
				{ "Warehouse", shipment.WarehouseFrom }
			});

			Stock stockTo = Global.Database.SelectOne<Stock>("stock", new Dictionary<string, object>()
			{
				{ "ItemID", shipment.ItemID },
				{ "Warehouse", shipment.WarehouseTo }
			});

			if (stockFrom == null || stockTo == null)
				return ShipmentStatus.DatabaseError;

			if (stockTo.Count < shipment.Count)
				return ShipmentStatus.InvalidItemCount;

			stockFrom.Count += shipment.Count;
			stockTo.Count -= shipment.Count;

			if (!Global.Database.Update<Stock>("stock", stockFrom))
				return ShipmentStatus.DatabaseError;

			if (!Global.Database.Update<Stock>("stock", stockTo))
				return ShipmentStatus.DatabaseError;

			if (!Global.Database.DeleteFrom<Shipment>("shipment", shipment))
				return ShipmentStatus.DatabaseError;

			return ShipmentStatus.OK;
		}
		#endregion

		#region Statistics queries
		private static string _statQuery1 =
			"SELECT Count(*) AS 'Count', partner.Name AS 'PartnerName', partnershipment.Date AS 'Date' " +
			"FROM partnershipment, partner " +
			"WHERE partnershipment.Sell = 1 AND partner.ID = partnershipment.PartnerID " +
			"GROUP BY partnershipment.Date, partnershipment.PartnerID " +
			"ORDER BY partnershipment.Date DESC";

		public static List<PartnerSellStatistics> GetPartnerSellStatistics()
		{
			return Global.Database.Select<PartnerSellStatistics>(_statQuery1);
		}

		private static string _statQuery2 =
			"SELECT partner.Name AS 'PartnerName', item.Name AS 'ItemName', SUM(partnershipment.Count) AS 'ItemCount' " +
			"FROM partnershipment, item, partner " +
			"WHERE item.ID = partnershipment.ItemID AND partner.ID = partnershipment.PartnerID AND partnershipment.Sell = 0 " +
			"GROUP BY partnershipment.PartnerID, partnershipment.ItemID " +
			"ORDER BY SUM(partnershipment.Count) DESC, partnershipment.Date DESC";

		public static List<PartnerBuyStatistics> GetPartnerBuyStatistics()
		{
			return Global.Database.Select<PartnerBuyStatistics>(_statQuery2);
		}

		private static string _statQuery3 =
			"SELECT warehouse.Name AS 'WarehouseName', items.Name AS 'ItemName' " +
			"FROM stock, warehouse, items " +
			"WHERE warehouse.ID = stock.Warehouse AND items.ItemID = stock.ItemID " +
			"AND stock.ItemID = " +
			"( " +
				"SELECT stock.ItemID " +
				"FROM stock " +
				"GROUP BY stock.ItemID " +
				"ORDER BY SUM(stock.Count) DESC " +
				"LIMIT 1 " +
			") " + 
			"ORDER BY warehouse.Name";

		public static List<WarehouseStockStatistics> GetWarehouseStatistics()
		{
			return Global.Database.Select<WarehouseStockStatistics>(_statQuery3);
		}
		#endregion
	}
}
