﻿using System;

namespace Raktar.Database
{
	public class Shipment
	{
		[DatabaseColumn(0, "WarehouseFrom", true, false)]
		public int WarehouseFrom;

		[DatabaseColumn(1, "WarehouseTo", true, false)]
		public int WarehouseTo;

		[DatabaseColumn(2, "ItemID", true, false)]
		public int ItemID;

		[DatabaseColumn(3, "Date", true, false)]
		public DateTime Date;

		[DatabaseColumn(4, "Count")]
		public int Count;
	}
}
