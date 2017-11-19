using Raktar.Database;

namespace Raktar.App.Data
{
	class WarehouseStock
	{
		[DatabaseColumn(0, "WarehouseName")]
		public string WarehouseName;

		[DatabaseColumn(1, "WarehouseID")]
		public int WarehouseID;

		[DatabaseColumn(2, "ItemCount")]
		public int ItemCount;
	}
}
