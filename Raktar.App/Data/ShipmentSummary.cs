using Raktar.Database;

namespace Raktar.App.Data
{
	public class ShipmentSummary : Shipment
	{
		[DatabaseColumn(5, "WarehouseFromName")]
		public string WarehouseFromName;

		[DatabaseColumn(6, "WarehouseToName")]
		public string WarehouseToName;

		[DatabaseColumn(7, "ItemName")]
		public string ItemName;
	}
}
