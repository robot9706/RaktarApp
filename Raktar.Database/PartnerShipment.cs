using System;

namespace Raktar.Database
{
	public class PartnerShipment
	{
		[DatabaseColumn(0)]
		public int PartnerID;

		[DatabaseColumn(1)]
		public int ItemID;

		[DatabaseColumn(2)]
		public int WarehouseID;

		[DatabaseColumn(3)]
		public DateTime Date;

		[DatabaseColumn(4)]
		public int Count;

		[DatabaseColumn(5)]
		public bool IsSelling;
	}
}
