using System;

namespace Raktar.Database
{
	public class PartnerShipment
	{
		[DatabaseColumn(0, "PartnerID", true, false)]
		public int PartnerID;

		[DatabaseColumn(1, "ItemID", true, false)]
		public int ItemID;

		[DatabaseColumn(2, "WarehouseID", true, false)]
		public int WarehouseID;

		[DatabaseColumn(3, "Date")]
		public DateTime Date;

		[DatabaseColumn(4, "Count")]
		public int Count;

		[DatabaseColumn(5, "Sell")]
		public bool IsSelling;
	}
}
