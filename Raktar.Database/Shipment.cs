using System;

namespace Raktar.Database
{
	public class Shipment
	{
		[DatabaseColumn(0, "WarehouseFrom")]
		public int WarehouseFrom;

		[DatabaseColumn(1, "WarehouseT")]
		public int WarehouseTo;

		[DatabaseColumn(2, "ItemID")]
		public int ItemID;

		[DatabaseColumn(3, "Date")]
		public DateTime Date;

		[DatabaseColumn(4, "Count")]
		public int Count;
	}
}
