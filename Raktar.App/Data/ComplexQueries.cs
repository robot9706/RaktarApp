using Raktar.Database;
using System;
using System.Collections.Generic;

namespace Raktar.App.Data
{
	class ComplexQueries
	{
		public enum ShipmentStatus
		{
			DatabaseError,
			InvalidItemCount,
			OK
		}

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

		private static string _shipmentSummaryQuery =
			"SELECT shipment.WarehouseFrom, shipment.WarehouseTo, shipment.ItemID, shipment.Date, shipment.Count, " +
			"W1.Name AS 'WarehouseFromName', W2.Name AS 'WarehouseToName', items.Name as 'ItemName' " +
			"FROM shipment, warehouse AS W1, warehouse as W2, items " +
			"WHERE items.ItemID = shipment.ItemID AND W1.ID = shipment.WarehouseFrom AND W2.ID = shipment.WarehouseTo;";

		private static string _shipmentSummaryDetailedQuery =
			"SELECT shipment.WarehouseFrom, shipment.WarehouseTo, shipment.ItemID, shipment.Date, shipment.Count, " +
			"W1.Name AS 'WarehouseFromName', W2.Name AS 'WarehouseToName', items.Name as 'ItemName' " +
			"FROM shipment, warehouse AS W1, warehouse as W2, items " +
			"WHERE items.ItemID = shipment.ItemID AND W1.ID = shipment.WarehouseFrom AND W2.ID = shipment.WarehouseTo AND " +
			"shipment.WarehouseFrom = {0} AND shipment.WarehouseTo = {1} AND shipment.ItemID = {2} AND shipment.Date = {3};";

		private static string _partnerShipmentSummaryQuery =
			"SELECT partnershipment.PartnerID, partnershipment.ItemID, partnershipment.WarehouseID, partnershipment.Date, partnershipment.Count, partnershipment.Sell, " +
			"partner.Name AS 'PartnerName', warehouse.Name AS 'WarehouseName', items.Name AS 'ItemName' " +
			"FROM partnershipment, partner, items, warehouse " +
			"WHERE partnershipment.ItemID = items.ItemID AND partnershipment.PartnerID = partner.ID AND partnershipment.WarehouseID = warehouse.ID;";

		private static string _partnerShipmentDetailedSummaryQuery =
			"SELECT partnershipment.PartnerID, partnershipment.ItemID, partnershipment.WarehouseID, partnershipment.Date, partnershipment.Count, partnershipment.Sell, " +
			"partner.Name AS 'PartnerName', warehouse.Name AS 'WarehouseName', items.Name AS 'ItemName' " +
			"FROM partnershipment, partner, items, warehouse " +
			"WHERE partnershipment.ItemID = items.ItemID AND partnershipment.PartnerID = partner.ID AND partnershipment.WarehouseID = warehouse.ID AND " +
			"partnershipment.PartnerID = {0} AND partnershipment.ItemID = {1} AND partnershipment.WarehouseID = {2} AND partnershipment.Date = {3};";

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

		public static List<PartnerShipmentSummary> GetPartnerShipmentSummary()
		{
			return Global.Database.Select<PartnerShipmentSummary>(_partnerShipmentSummaryQuery);
		}

		public static PartnerShipmentSummary GetPartnerShipmentSummary(PartnerShipment source)
		{
			List<PartnerShipmentSummary> data = Global.Database.Select<PartnerShipmentSummary>(String.Format(
				_partnerShipmentDetailedSummaryQuery,
				ObjectParser.FormatPrimitiveValue(source.PartnerID),
				ObjectParser.FormatPrimitiveValue(source.ItemID),
				ObjectParser.FormatPrimitiveValue(source.WarehouseID),
				ObjectParser.FormatPrimitiveValue(source.Date)
				));

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
			List<ShipmentSummary> data = Global.Database.Select<ShipmentSummary>(String.Format(
				_shipmentSummaryDetailedQuery,
				ObjectParser.FormatPrimitiveValue(source.WarehouseFrom),
				ObjectParser.FormatPrimitiveValue(source.WarehouseTo),
				ObjectParser.FormatPrimitiveValue(source.ItemID),
				ObjectParser.FormatPrimitiveValue(source.Date)
				));

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
	}
}
