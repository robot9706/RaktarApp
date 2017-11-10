using System;

namespace Raktar.Database
{
	public class Shipment
	{
		[DatabaseColumn(0)]
		public int WarehouseFrom;

		[DatabaseColumn(1)]
		public int WarehouseTo;

		[DatabaseColumn(2)]
		public int ItemID;

		[DatabaseColumn(3)]
		public DateTime Date;

		[DatabaseColumn(4)]
		public int Count;
	}
}
