using Raktar.Database;

namespace Raktar.App.Data
{
	class WarehouseStockStatistics
	{
		[DatabaseColumn(0, "WarehouseName")]
		public string WarehouseName;

		[DatabaseColumn(1, "ItemName")]
		public string ItemName;
	}
}
